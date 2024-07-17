using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MagneCort
{
    public partial class GoruntuForm : Form
    {
        DicomParsers DCM = new DicomParsers();
        public GoruntuForm(string dosyaYolu)
        {
            InitializeComponent();
            DCM.dcmData_Topla(dosyaYolu);

            try
            {
                hastaIsimSoyisim.Text = DCM.hastaIsmi;
                doktorIsmi.Text = DCM.doktorIsmi;
                cekimTarihi.Value = DateTime.Parse(DCM.tarih);
                aciklamaKutusu.Text = DCM.aciklama;
                this.Text = hastaIsimSoyisim.ToString();
                radyolojikGoruntuCerceve.Image = DCM.bmpDump();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = DCM.Frames.Count-1;
        }

        private void pngKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog pacsKaydet = new SaveFileDialog();
            pacsKaydet.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            if (pacsKaydet.ShowDialog() == DialogResult.OK)
            {
                radyolojikGoruntuCerceve.Image.Save(pacsKaydet.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Size newSize = new Size((int)(radyolojikGoruntuCerceve.Width * 1.0f), (int)(radyolojikGoruntuCerceve.Height * 1.0f));
            Bitmap bmp = new Bitmap(radyolojikGoruntuCerceve.Image, newSize);
            radyolojikGoruntuCerceve.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radyolojikGoruntuCerceve.Image = DCM.bmpDump();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            radyolojikGoruntuCerceve.Image = DCM.Frames[trackBar1.Value];
        }
    }
}
