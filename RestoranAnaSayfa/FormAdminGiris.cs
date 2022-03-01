using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranAnaSayfa
{
    public partial class adminGiris : Form
    {


        public adminGiris()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        public void ConnectionControl()
        {
            if (_sql.State == ConnectionState.Closed)
            {
                _sql.Open();
            }
        }

        SqlConnection _sql = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Restorant;integrated security=true;");
        public List<Manager> GetAll()
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Select userr, password from Managerr where id=1", _sql);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Manager> manager = new List<Manager>();

            while (reader.Read())
            {
                Manager manager1 = new Manager
                {
                    User = reader["userr"].ToString(),
                    Pass = reader["password"].ToString()
                };
                manager.Add(manager1);

                string admin = Convert.ToString(manager1.User);
                string password = Convert.ToString(manager1.Pass);


                if (admin == tbxadmin.Text && password == tbxpass.Text)
                {
                    adminPanel panel = new adminPanel();
                    panel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı ya da Parola...\n Lütfen Tekrar Deneyiniz");
                }
            }

            

            reader.Close();
            _sql.Close();
            return manager;
        }

        

        private void adminGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri2_Click(object sender, EventArgs e)
        {
            FormAnaSayfa form = new FormAnaSayfa();
            form.Show();
            this.Hide();
        }

        private void btnGİR_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            formSifreYenileme sifreYenileme = new formSifreYenileme();
            sifreYenileme.Show();
            this.Hide();
        }
    }
}
