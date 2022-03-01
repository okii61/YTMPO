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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGarsonEkleme ekleme=new FormGarsonEkleme();
            ekleme.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGarsonList listt=new FormGarsonList();
            listt.Show();
            this.Hide();
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri3_Click(object sender, EventArgs e)
        {
            FormAnaSayfa form1 = new FormAnaSayfa();
            form1.Show();
            this.Hide();
        }
    }
}
