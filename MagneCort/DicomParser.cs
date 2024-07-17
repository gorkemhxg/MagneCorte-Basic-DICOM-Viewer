using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MagneCort
{
    internal class DicomParsers
    {
        public List<Bitmap> Frames { get; private set; } = new List<Bitmap>();

        // DICOM Temel Bilgiler
        public string hastaIsmi { get; private set; }
        public string doktorIsmi { get; private set; }
        public string tarih { get; private set; }
        public string aciklama { get; private set; }

        // PIKSEL DATALAR
        public byte[] pxVeri { get; private set; }
        public int imajSatir { get; private set; }
        public int imajSutun { get; private set; }
        public int bAlloc { get; private set; }

        // DATA DERLEYİCİ
        public void dcmData_Topla(string dicomFile)
        {
            using (FileStream dicoFs = new FileStream(dicomFile, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader dcmBin = new BinaryReader(dicoFs))
                {
                    byte[] preamble = dcmBin.ReadBytes(128);

                    // DOSYA TAG KONTROL
                    if (Encoding.ASCII.GetString(dcmBin.ReadBytes(4)) != "DICM")
                    {
                        MessageBox.Show("Lütfen geçerli bir görüntü seçiniz.", "Görüntü işleme hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Dosya doğru ise işlemeye devam
                    while (dcmBin.BaseStream.Position < dcmBin.BaseStream.Length)
                    {
                        uint vl = 0;
                        // TAG
                        ushort grpnum = dcmBin.ReadUInt16();
                        ushort elmnum = dcmBin.ReadUInt16();

                        string dcTag = $"({grpnum:X4},{elmnum:X4})";

                        string vrVal = Encoding.ASCII.GetString(dcmBin.ReadBytes(2));
                        if (vrVal == "OB" || vrVal == "OW" || vrVal == "SQ" || vrVal == "UN")
                        {
                            dcmBin.ReadBytes(2);
                            vl = dcmBin.ReadUInt32();
                        }
                        else
                        {
                            vl = dcmBin.ReadUInt16();
                        }
                        byte[] value = dcmBin.ReadBytes((int)vl);


                        switch (dcTag)
                        {
                            case "(0010,0010)":
                                hastaIsmi = Encoding.Default.GetString(value).Trim(); break;

                            case "(0008,1050)":
                                doktorIsmi = Encoding.Default.GetString(value).Trim(); break;

                            case "(0008,0020)":
                                tarih = Encoding.Default.GetString(value).Trim(); break;

                            case "(0008,1030)":
                                aciklama = Encoding.Default.GetString(value).Trim(); break;
                            case "(0028,0010)":
                                imajSatir = BitConverter.ToInt16(value, 0); break;
                            case "(0028,0011)":
                                imajSutun = BitConverter.ToInt16(value, 0); break;
                            case "(0028,0100)":
                                bAlloc = BitConverter.ToInt16(value, 0); break;
                            case "(7FE0,0010)":
                                pxVeri = value;
                                ProcessPixelData(value);
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void ProcessPixelData(byte[] pixelData)
        {
            int frameSize = imajSatir * imajSutun * bAlloc / 8;
            int numberOfFrames = pixelData.Length / frameSize;

            for (int i = 0; i < numberOfFrames; i++)
            {
                byte[] frameData = new byte[frameSize];
                Array.Copy(pixelData, i * frameSize, frameData, 0, frameSize);
                Frames.Add(ConvertToBitmap(frameData));
            }
        }


        // BITMAP IMAJ AKTARICI
        public Bitmap bmpDump()
        {
            if (pxVeri == null || imajSatir == 0 || imajSutun == 0)
            {
                throw new Exception("Piksel verisi veya görüntü boyutları geçersiz.");
            }

            Bitmap bitmap = new Bitmap(imajSutun, imajSatir);
            int pixelIndex = 0;

            for (int y = 0; y < imajSatir; y++)
            {
                for (int x = 0; x < imajSutun; x++)
                {
                    int pixelValue = 0;
                    if (bAlloc == 8)
                    {
                        if (pixelIndex >= pxVeri.Length)
                        {
                            throw new Exception("Piksel verisi boyutu yetersiz.");
                        }
                        pixelValue = pxVeri[pixelIndex++];
                    }
                    else if (bAlloc == 16)
                    {
                        if (pixelIndex + 1 >= pxVeri.Length)
                        {
                            throw new Exception("Piksel verisi boyutu yetersiz.");
                        }
                        pixelValue = BitConverter.ToUInt16(pxVeri, pixelIndex);
                        pixelIndex += 2;
                    }

                    // Grayscale değerini ayarla (0-255 aralığında)
                    int intensity = (int)(255.0 * pixelValue / (Math.Pow(2, bAlloc) - 1));
                    intensity = Math.Max(0, Math.Min(255, intensity)); // Clamp to 0-255 range

                    Color color = Color.FromArgb(intensity, intensity, intensity);
                    bitmap.SetPixel(x, y, color);
                }
            }

            return bitmap;


        }


        private Bitmap ConvertToBitmap(byte[] frameData)
        {
            Bitmap bitmap = new Bitmap(imajSutun, imajSatir);
            int pixelIndex = 0;

            for (int y = 0; y < imajSatir; y++)
            {
                for (int x = 0; x < imajSutun; x++)
                {
                    int pixelValue = 0;
                    if (bAlloc == 8)
                    {
                        pixelValue = frameData[pixelIndex++];
                    }
                    else if (bAlloc == 16)
                    {
                        pixelValue = BitConverter.ToUInt16(frameData, pixelIndex);
                        pixelIndex += 2;
                    }

                    int intensity = (int)(255.0 * pixelValue / (Math.Pow(2, bAlloc) - 1));
                    intensity = Math.Max(0, Math.Min(255, intensity)); // Clamp to 0-255 range

                    Color color = Color.FromArgb(intensity, intensity, intensity);
                    bitmap.SetPixel(x, y, color);
                }
            }

            return bitmap;
        }
    }
}
