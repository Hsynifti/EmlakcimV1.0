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
        private string user_name;
        private string password;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Contact { get; set; }
        public string Company_Name { get; set; }
        public bool active { get; set; }
        public int profit { get; set; }
        public bool admin { get; set; }
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
        public void bilgiata(int Firma_ID)
        {
            Company_ID = Firma_ID;
            user_name= Convert.ToString(genel.Veri("KullaniciHesap @firmaId='" + Firma_ID + "'", "user_name"));
            password= Convert.ToString(genel.Veri("KullaniciHesap @firmaId='" + Firma_ID + "'", "pass"));
            Name= Convert.ToString(genel.Veri("KullaniciHesap @firmaId='" + Firma_ID + "'", "Kullaniciadi"));
            Surname= Convert.ToString(genel.Veri("KullaniciHesap @firmaId='" + Firma_ID + "'", "Kullanicisoyadi"));
            Contact= Convert.ToString(genel.Veri("KullaniciHesap @firmaId='" + Firma_ID + "'", "Iletisim"));
            Company_Name= Convert.ToString(genel.Veri("KullaniciHesap @firmaId='" + Firma_ID + "'", "Firma_Adi"));
            active= Convert.ToBoolean(genel.Veri("KullaniciHesap @firmaId='" + Firma_ID + "'", "isActive"));
            admin = Convert.ToBoolean(genel.Veri("KullaniciHesap @firmaId='" + Firma_ID + "'", "isAdmin"));
            profit= Convert.ToInt32(genel.Veri("KullaniciHesap @firmaId='" + Firma_ID + "'", "profit"));
        }
    }
    
}
