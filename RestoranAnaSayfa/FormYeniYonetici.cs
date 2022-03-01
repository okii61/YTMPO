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
    public partial class FormYeniYonetici : Form
    {
        public FormYeniYonetici()
        {
            InitializeComponent();
        }
        ManagerDAL _managerDal=new ManagerDAL();

        private void button1_Click(object sender, EventArgs e)
        {
            _managerDal.Add(new Manager
            {
                Name = tbxYName.Text,
                SurName = tbxYSurname.Text,
                Mail = tbxYMail.Text,
                User = tbxYUser.Text,
                Pass = tbxYPass.Text
            });

            MessageBox.Show($"İşlem Başarılı Ailemize Hoşgeldin {tbxYUser.Text}");

        }
    }
}
