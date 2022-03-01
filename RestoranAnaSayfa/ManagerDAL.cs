using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranAnaSayfa
{
    public class ManagerDAL
    {
        SqlConnection _sql = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Restorant;integrated security=true;");

        public void ConnectionControl()
        {
            if (_sql.State == ConnectionState.Closed)
            {
                _sql.Open();
            }
        }
        //public List<Manager> GetAll()
        //{
        //    ConnectionControl();
        //    SqlCommand cmd = new SqlCommand("Select mail, password from Managerr where id=4", _sql);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    List<Manager> manager = new List<Manager>();

        //    while (reader.Read())
        //    {
        //        Manager manager1 = new Manager
        //        {
        //            id = Convert.ToInt32(reader["id"]),
        //            Name = reader["Name"].ToString(),
        //            SurName = reader["Surname"].ToString(),
        //            Mail = reader["Mail"].ToString(),
        //            User = reader["user"].ToString(),
        //            Pass = reader["password"].ToString()
        //        };
        //        manager.Add(manager1);
               
                
        //    }
        //    reader.Close();
        //    _sql.Close();
        //    return manager;
        //}

        public void Add(Manager manager)
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("insert into Managerr values(@name, @surname, @userr, @mail, @password)", _sql);
            cmd.Parameters.AddWithValue("@name", manager.Name);
            cmd.Parameters.AddWithValue("@surname", manager.SurName);
            cmd.Parameters.AddWithValue("@userr", manager.User);
            cmd.Parameters.AddWithValue("@mail", manager.Mail);
            cmd.Parameters.AddWithValue("@password", manager.Pass);
      
            cmd.ExecuteNonQuery();


            _sql.Close();
        }

    }
}
