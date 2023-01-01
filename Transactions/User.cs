using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transactions
{
    
    public class User
    {
        
        public int User_ID { get; set; }
        private string user_name { get; set; }
        private string password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Contact { get; set; }
        public byte active { get; set; }
        public string User_Name
        {
            get { return user_name; }
            set { user_name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public void Girisyap(string Kullanici_Adi,string Sifre)
        {
            SQLAcces ac = new SQLAcces();
            General genel = new General();
            using (SqlConnection conn = ac.baglanti())
            {
                String query = "Select * from T_Kullanici where user_name=@username AND pass=@password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    cmd.Parameters.AddWithValue("username", Kullanici_Adi);
                    cmd.Parameters.AddWithValue("password", Sifre);
                    SqlDataReader dr = cmd.ExecuteReader();
                }
            }
        }

    }
    
}
