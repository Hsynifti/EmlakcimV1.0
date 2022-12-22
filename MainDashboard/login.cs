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
        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }
        private void appexit()
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Lütfen boş bırakmayınız.");
            }
            else
            {
                giris();
            }

        }
        private void giris()
        {
            SqlCommand cmd = new SqlCommand("Select * from T_Kullanici where user_name=@username AND pass=@password", bgl.baglanti());
            cmd.Parameters.AddWithValue("username", txt_username.Text);
            cmd.Parameters.AddWithValue("password", txt_pass.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DashBoard dashboard = new DashBoard();
                dashboard.kullaniciadi= txt_username.Text;
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi! Lütfen tekrar deneyiniz.", "KONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            appexit();

        }
    }
    


}

