using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranAnaSayfa
{
    public partial class FormYoneticiEkle : Form
    {
        public FormYoneticiEkle()
        {
            InitializeComponent();
        }
        adminGiris _giris = new adminGiris();
        private void btnGYoneticiEkle_Click(object sender, EventArgs e)
        {
            FormYeniYonetici yeniYonetici = new FormYeniYonetici();
            yeniYonetici.Show();
            this.Hide();
        }
    }
}
