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
    public partial class FormGarsonList : Form
    {
        public FormGarsonList()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        GarsonDAL _garsonDAL = new GarsonDAL();


        private void dgwGarsonList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dgwGarsonList.DataSource = _garsonDAL.GetAll();
        }

        private void garsonList_Load(object sender, EventArgs e)
        {
            dgwLoad();
        }

        private void dgwLoad()
        {
            dgwGarsonList.DataSource = _garsonDAL.GetAll();
        }

        private void btnGrsnDel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwGarsonList.CurrentRow.Cells[0].Value);
            _garsonDAL.Delete(id);
            dgwLoad();

            MessageBox.Show("Garson Kaydı Başarıyla Silindi..");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            adminPanel panel=new adminPanel();
            panel.Show();
            this.Hide();

        }
    }
}
