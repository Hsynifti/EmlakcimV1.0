using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Transactions
{
    
    public class User
    {
        General genel = new General();
        SQLAcces ac = new SQLAcces();
        
        public int Company_ID { get; set; }
        private string user_name { get; set; }
        private string password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Contact { get; set; }
        public string Company_Name { get; set; }
        public bool active { get; set; }
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
        /*
        public void Girisyap(string Kullanici_Adi, string Sifre)
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
        */
        public int CompanyID_Getir()
        {
            Company_ID = Convert.ToInt32(genel.Veri("Kullanici @username='" + user_name + "',@pass='" + password + "'", "Kullanici_id"));
            return Company_ID;
        }
        public string CompanyName_Getir()
        {
            Company_Name = Convert.ToString(genel.Veri("Kullanici @username='" + user_name + "',@pass='" + password + "'", "Firma_Adi"));
            return Company_Name;
        }
    }
    
}
