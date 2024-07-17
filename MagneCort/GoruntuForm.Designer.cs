namespace MagneCort
{
    partial class GoruntuForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoruntuForm));
            this.radyolojikGoruntuCerceve = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pngKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.hastaIsimSoyisim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.doktorIsmi = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cekimTarihi = new System.Windows.Forms.DateTimePicker();
            this.aciklamaKutusu = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.radyolojikGoruntuCerceve)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radyolojikGoruntuCerceve
            // 
            this.radyolojikGoruntuCerceve.BackColor = System.Drawing.Color.Black;
            this.radyolojikGoruntuCerceve.Location = new System.Drawing.Point(8, 78);
            this.radyolojikGoruntuCerceve.Name = "radyolojikGoruntuCerceve";
            this.radyolojikGoruntuCerceve.Size = new System.Drawing.Size(1158, 648);
            this.radyolojikGoruntuCerceve.TabIndex = 0;
            this.radyolojikGoruntuCerceve.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pngKaydetToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // pngKaydetToolStripMenuItem
            // 
            this.pngKaydetToolStripMenuItem.Name = "pngKaydetToolStripMenuItem";
            this.pngKaydetToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pngKaydetToolStripMenuItem.Text = "Resim Olarak Kaydet";
            this.pngKaydetToolStripMenuItem.Click += new System.EventHandler(this.pngKaydetToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Ad Soyad:";
            // 
            // hastaIsimSoyisim
            // 
            this.hastaIsimSoyisim.AutoSize = true;
            this.hastaIsimSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaIsimSoyisim.ForeColor = System.Drawing.Color.Cyan;
            this.hastaIsimSoyisim.Location = new System.Drawing.Point(172, 13);
            this.hastaIsimSoyisim.Name = "hastaIsimSoyisim";
            this.hastaIsimSoyisim.Size = new System.Drawing.Size(53, 20);
            this.hastaIsimSoyisim.TabIndex = 2;
            this.hastaIsimSoyisim.Text = "{ISIM}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doktor İsmi:";
            // 
            // doktorIsmi
            // 
            this.doktorIsmi.AutoSize = true;
            this.doktorIsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorIsmi.ForeColor = System.Drawing.Color.Cyan;
            this.doktorIsmi.Location = new System.Drawing.Point(135, 47);
            this.doktorIsmi.Name = "doktorIsmi";
            this.doktorIsmi.Size = new System.Drawing.Size(86, 20);
            this.doktorIsmi.TabIndex = 4;
            this.doktorIsmi.Text = "{DOKTOR}";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Cyan;
            this.label12.Location = new System.Drawing.Point(382, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 24);
            this.label12.TabIndex = 5;
            this.label12.Text = "Tarih:";
            // 
            // cekimTarihi
            // 
            this.cekimTarihi.Enabled = false;
            this.cekimTarihi.Location = new System.Drawing.Point(446, 15);
            this.cekimTarihi.Name = "cekimTarihi";
            this.cekimTarihi.Size = new System.Drawing.Size(200, 20);
            this.cekimTarihi.TabIndex = 6;
            // 
            // aciklamaKutusu
            // 
            this.aciklamaKutusu.Location = new System.Drawing.Point(787, 11);
            this.aciklamaKutusu.Name = "aciklamaKutusu";
            this.aciklamaKutusu.Size = new System.Drawing.Size(368, 75);
            this.aciklamaKutusu.TabIndex = 8;
            this.aciklamaKutusu.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.aciklamaKutusu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hastaIsimSoyisim);
            this.panel1.Controls.Add(this.cekimTarihi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.doktorIsmi);
            this.panel1.Location = new System.Drawing.Point(8, 732);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 100);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(684, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Açıklama";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 35);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(65, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 35);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(132, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 35);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(185, 27);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(263, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // GoruntuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1173, 830);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radyolojikGoruntuCerceve);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1189, 869);
            this.Name = "GoruntuForm";
            this.ShowIcon = false;
            this.Text = "MagneCorte Basic PACS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radyolojikGoruntuCerceve)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox radyolojikGoruntuCerceve;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pngKaydetToolStripMenuItem;
        private System.Windows.Forms.Label hastaIsimSoyisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker cekimTarihi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label doktorIsmi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox aciklamaKutusu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

