using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestoranAnaSayfa
{
    public class GarsonDAL
    {
        SqlConnection _sql = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Restorant;integrated security=true;");

        public void ConnectionControl()
        {
            if (_sql.State==ConnectionState.Closed)
            {
                _sql.Open();
            }
        }

        public List<Garson> GetAll()
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Select * from Garsonnn",_sql);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Garson> garsonn = new List<Garson>();
            
            while (reader.Read())
            {
                Garson garson = new Garson
                {
                    id=Convert.ToInt32(reader["id"]),
                    Name=reader["Name"].ToString(),
                    Surname=reader["Surname"].ToString(),
                    Mail=reader["Mail"].ToString(),
                    Age=Convert.ToInt32(reader["age"]),
                    Salary=Convert.ToInt32(reader["Salary"]),
                    SeriNo=Convert.ToInt32(reader["SeriNo"])
                };
                garsonn.Add(garson);
            }
            reader.Close();
            _sql.Close();
            return garsonn;
        }

        public void Add(Garson garson)
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("insert into Garsonnn values(@name, @surname, @age, @mail, @salary, @serino)",_sql);
            cmd.Parameters.AddWithValue("@name", garson.Name);
            cmd.Parameters.AddWithValue("@surname",garson.Surname);
            cmd.Parameters.AddWithValue("@age",garson.Age);
            cmd.Parameters.AddWithValue("@mail", garson.Mail);
            cmd.Parameters.AddWithValue("@salary", garson.Salary);
            cmd.Parameters.AddWithValue("@serino", garson.SeriNo);
            cmd.ExecuteNonQuery();
            
            
            _sql.Close();

        }
        
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Delete Garsonnn where id=@id", _sql);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.ExecuteNonQuery ();

            _sql.Close ();
        }
    }
}
