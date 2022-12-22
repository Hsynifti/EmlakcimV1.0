using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transactions
{
    
    public class Users
    {
        
        public int User_ID { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Contact { get; set; }
        public IsActive Active { get; set; }

        public void Girisyap()
        {
            SQLAcces ac = new SQLAcces();
            using (SqlConnection conn = ac.baglanti())
            {
                String query = "Select * from T_Kullanici where user_name=@username AND pass=@password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    cmd.Parameters.AddWithValue("username", user_name);
                    cmd.Parameters.AddWithValue("password", password);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                }
            }
        }

    }
    public enum IsActive:byte
    {
        Active = 1,
        Inactive = 0,
    }
    
}
