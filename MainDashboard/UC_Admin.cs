using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transactions;

namespace MainDashboard
{
    public partial class UC_Admin : UserControl
    {
        General genel = new General();
        User kullanici = new User();
        public int firmaId { get; set; }
        public UC_Admin(int firma_id)
        {
            firmaId = firma_id;
            InitializeComponent();
        }
        //Kullanıcı Ekle
        void Bosalt()
        {
            txt_CompanyName.Text = string.Empty;
            txt_Contact.Text = string.Empty;
            txt_Username.Text = string.Empty;
            txt_Pass.Text = string.Empty;
            txt_Name.Text = string.Empty;
            txt_Surname.Text = string.Empty;
        }
        void UserAdd()
        {
            if (txt_Name.Text == string.Empty || txt_Surname.Text == string.Empty || txt_CompanyName.Text == string.Empty || txt_Contact.Text == string.Empty || txt_Username.Text == string.Empty || txt_Pass.Text == string.Empty)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                genel.ekle("SP_KullaniciEkle @user_name=' " + txt_Username.Text + "'," +
                    "@pass = '" + txt_Pass.Text + "'," +
                    "@Kullanici_adi = '" + txt_Name.Text + "'," +
                    "@Kullanici_soyadi ='" + txt_Surname.Text + "'," +
                    "@Iletisim ='" + txt_Contact.Text + "'," +
                    "@FirmaAdi ='" + txt_CompanyName.Text + "'");
                MessageBox.Show("Kullanıcı Başarıyla Eklendi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bosalt();
            }
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            UserAdd();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            UsersList();
        }
        void UsersList()
        {
            genel.listele("SP_USERS", dtg_Users);
        }
        void aktar()
        {
            kullanici.bilgiata(firmaId);
            txtUp_CompanyName.Text = kullanici.Company_Name;
            txtUp_Name.Text = kullanici.Name;
            txtUp_Surname.Text = kullanici.Surname;
            txtUp_Contact.Text = kullanici.Contact;
            txtUp_Username.Text = kullanici.User_Name;
            txtUp_Pass.Text = kullanici.Password;
            chckbxActive.Checked = kullanici.active;
            chckbxAdmin.Checked = kullanici.admin;
        }

        private void btn_UserUpdate_Click(object sender, EventArgs e)
        {
            genel.ekle("SP_KullaniciUpdate @firma_id = '" + firmaId + "'," +
                "@user_name = '" + txtUp_Username.Text + "'," +
                "@pass = '" + txtUp_Pass.Text + "'," +
                "@Kullanici_adi = '" + txtUp_Name.Text + "'," +
                "@Kullanici_soyadi = '" + txtUp_Surname.Text + "'," +
                "@Iletisim = '" + txtUp_Contact.Text + "'," +
                "@FirmaAdi = '" + txtUp_CompanyName.Text + "'," +
                "@isActive = " + chckbxActive.Checked + "," +
                "@isAdmin = " + chckbxAdmin.Checked + "");
            UsersList();
        }

        private void dtg_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int secilen = dtg_Users.SelectedCells[0].RowIndex;
                firmaId = Convert.ToInt32(dtg_Users.Rows[secilen].Cells[0].Value);
                aktar();
            }
        }
    }
}
