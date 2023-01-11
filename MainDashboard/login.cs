using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Transactions;

namespace MainDashboard
{
    public partial class login : System.Windows.Forms.Form
    {
        public login()
        {
            InitializeComponent();
        }
        SQLAcces bgl = new SQLAcces();

        General genel = new General(); 

        User User =new User();
        
        CompanyModel Company = new CompanyModel();
        private void appexit()
        {
            Application.Exit();
        }
        private void Giris()
        {
            User.User_Name = txt_username.Text;
            User.Password = txt_pass.Text;
            User.Company_ID = Company.firmaId;
            User.Company_Name = Company.firma_adi;
            DashBoard dashboard = new DashBoard();
            
            //kullanici adi, şifre ve aktiflik durumu
            string K_Adi = Convert.ToString(genel.Veri("Kullanici @username='" +User.User_Name+ "',@pass='" +User.Password+ "'", "user_name"));
            string Sifre = Convert.ToString(genel.Veri("Kullanici @username='" +User.User_Name+ "',@pass='" +User.Password+ "'", "pass"));
            bool Active = Convert.ToBoolean(genel.Veri("Kullanici @username='" + User.User_Name + "',@pass='" + User.Password + "'", "isActive"));
            bool Admin = Convert.ToBoolean(genel.Veri("Kullanici @username='" + User.User_Name + "',@pass='" + User.Password + "'", "isAdmin"));
            User.User_Name = txt_username.Text;
            User.Password = txt_pass.Text;
            if (K_Adi == User.User_Name && Sifre == User.Password && Active == true)
            {
                //FirmaId-kullaniciid alınır.
                dashboard.firmaId = User.CompanyID_Getir();
                //FirmaAdi alınır.
                dashboard.Firma_Adi = User.CompanyName_Getir();
                dashboard.Show();
                lblHata.Visible = false;
                this.Hide();
                if (Admin)
                {
                    dashboard.btnAdmin.Visible = true;
                }
            }
            else if (Active == false)
            {
                MessageBox.Show("Kullanıcı Aktif Değil. Lütfen Yöneticinizle İrtibata Geçiniz!","Giriş Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                lblHata.Text = "Kullanıcı Adı Veya Şifre Yanlış";
                lblHata.Visible = true;
            }
            
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            User.User_Name = txt_username.Text;
            User.Password = txt_pass.Text;
            if (User.User_Name == "" || User.Password == "")
            {
                lblHata.Text = "Kullanıcı Adı ve Şifre Giriniz.";
                lblHata.Visible = true;
            }
            else
            {
                Giris();
            }
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            appexit();
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_login.PerformClick();
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_login.PerformClick();
        }
        private void login_Load(object sender, EventArgs e)
        {

        }
    }
    


}

