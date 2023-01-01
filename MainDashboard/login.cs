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
        User Login=new User();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }
        private void appexit()
        {
            Application.Exit();
        }
        private void Giris()
        {
            Login.User_Name = txt_username.Text;
            Login.Password = txt_pass.Text;
            DashBoard dashboard = new DashBoard();
            //FirmaId-kullaniciid alınır.
            dashboard.firmaId = Convert.ToInt32(genel.Veri("Kullanici @username='" + Login.User_Name+ "',@pass='" + Login.Password + "'", "Kullanici_id"));
            //FirmaAdi alınır.
            dashboard.Firma_Adi = Convert.ToString(genel.Veri("Kullanici @username='" +Login.User_Name+ "',@pass='" +Login.Password+ "'", "Firma_Adi"));
            //kullanici adi ve sifre
            string K_Adi = Convert.ToString(genel.Veri("Kullanici @username='" +Login.User_Name+ "',@pass='" +Login.Password+ "'", "user_name"));
            string Sifre = Convert.ToString(genel.Veri("Kullanici @username='" +Login.User_Name+ "',@pass='" +Login.Password+ "'", "pass"));
            //Boolean active = Convert.ToBoolean(genel.Veri("Kullanici_Active", "@active"));
            if(K_Adi == Login.User_Name && Sifre == Login.Password )
            {            
                dashboard.Show();
                lblHata.Visible = false;
                this.Hide();
            }
            else
            {
                lblHata.Text = "Kullanıcı Adı veya Şifre Hatalı!";
                lblHata.Visible = true;
                //MessageBox.Show("Hatalı bilgi girişi! Lütfen tekrar deneyiniz.", "KONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        //eski
        private void giris()
        {
            DashBoard dashboard = new DashBoard();
            //FirmaId-kullaniciid alınır.
            dashboard.firmaId=Convert.ToInt32(genel.Veri("Kullanici @username='"+ txt_username.Text+"',@pass='"+txt_pass.Text+"'","Kullanici_id"));
            //FirmaAdi alınır.
            dashboard.Firma_Adi=Convert.ToString(genel.Veri("Kullanici @username='"+ txt_username.Text+"',@pass='"+txt_pass.Text+"'","Firma_Adi"));



            SqlCommand cmd = new SqlCommand("Kullanici @username='"+txt_username.Text+"' ,@pass='"+txt_pass.Text+"'", bgl.baglanti());
            //cmd.Parameters.AddWithValue("K_adi", txt_username.Text);
            //cmd.Parameters.AddWithValue("password", txt_pass.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi! Lütfen tekrar deneyiniz.", "KONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_pass.Text == "")
            {
                lblHata.Text = "Kullanıcı Adı ve Şifre Giriniz.";
                lblHata.Visible = true;
                //MessageBox.Show("Lütfen boş bırakmayınız.","Giriş Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
    }
    


}

