using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagneCort
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void yeniBirDICOMAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSec = new OpenFileDialog();
            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
              GoruntuForm gf = new GoruntuForm(dosyaSec.FileName);
                gf.MdiParent = this;
                gf.Show();
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
