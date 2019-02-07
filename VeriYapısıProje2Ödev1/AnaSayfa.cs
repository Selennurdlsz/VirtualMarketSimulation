using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapısıProje2Ödev1
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnPersonelGirisi_Click(object sender, EventArgs e)
        {
            frmUrunEkle u = new frmUrunEkle();
            u.Show();
        }

        private void btnMusteriGirisi_Click(object sender, EventArgs e)
        {
            frmMüsteri m = new frmMüsteri();
            m.Show();
        }
    }
}
