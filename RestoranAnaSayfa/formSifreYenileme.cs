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
using System.Net.Mail;
using System.Net;

namespace RestoranAnaSayfa
{
    public partial class formSifreYenileme : Form
    {
        public formSifreYenileme()
        {
            InitializeComponent();
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
            SqlCommand cmd = new SqlCommand("Select mail from Managerr where id=1", _sql);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Manager> manager = new List<Manager>();

            while (reader.Read())
            {
                Manager manage1 = new Manager
                {
                    Mail = reader["mail"].ToString()
                };
                manager.Add(manage1);

                string maill = Convert.ToString(manage1.Mail);


                if (maill ==tbxFMail.Text)
                {
                    List<int> code=new List<int>();
                    var random = new Random();
                    var realcode = random.Next(65, 91) + random.Next(65, 91).ToString();
                   




                    string text = "<h1>Şifre Yenileme Kodu<h1>"+ realcode + " ";
                    string subject = "Parola Sıfırlama";
                    MailMessage mail=new MailMessage("cevooki@gmail.com",$"{ tbxFMail.Text}",subject,text);
                    mail.IsBodyHtml = true;
                    SmtpClient sc=new SmtpClient("smtp.gmail.com",587);
                    sc.UseDefaultCredentials = false;
                    NetworkCredential cre = new NetworkCredential("cevooki@gmail.com", "YeniSifre.123");
                    sc.Credentials = cre;
                    sc.EnableSsl = true;
                    sc.Send(mail);
                    
                    
                    }
            }

            


            reader.Close();
            _sql.Close();
            return manager;
        }

       
        private void btnCode_Click(object sender, EventArgs e)
        {
            GetAll();
        }
    }
}
