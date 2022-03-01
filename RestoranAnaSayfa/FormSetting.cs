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
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void btngeri5_Click(object sender, EventArgs e)
        {
            FormAnaSayfa form = new FormAnaSayfa();
            form.Show();
            this.Hide();
        }

        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            FormYoneticiEkle yoneticiEkle= new FormYoneticiEkle();
            yoneticiEkle.Show();
            this.Hide();
        }
    }
}
