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
    public partial class FormGarsonEkleme : Form
    {
        public FormGarsonEkleme()
        {
            InitializeComponent();

        }

        

        private void btnGarsonAdd_Click(object sender, EventArgs e)
        {
            GarsonDAL garsonDAL = new GarsonDAL();
            garsonDAL.Add(new Garson 
            { 
                Name =tbxName.Text,
                Surname =tbxSurname.Text,
                Age =Convert.ToInt32(tbxAge.Text),
                Mail=tbxMail.Text,
                Salary =Convert.ToInt32(tbxSalary.Text),
                SeriNo=Convert.ToInt32(tbxSeriNo.Text),
            });

            MessageBox.Show("Garson Başarıyla İşe Alındı");


        }

        private void garsonEkleme_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri4_Click(object sender, EventArgs e)
        {
            adminPanel panel=new adminPanel();
            panel.Show();
            this.Hide();
        }
    }
}
