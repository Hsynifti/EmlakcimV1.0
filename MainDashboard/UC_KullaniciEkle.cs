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
    public partial class UC_KullaniciEkle : UserControl
    {
        General genel = new General();
        public int firmaId { get; set; }
        public UC_KullaniciEkle(int firma_id)
        {
            firmaId = firma_id;
            InitializeComponent();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            UserAdd();
        }
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
    }
}
