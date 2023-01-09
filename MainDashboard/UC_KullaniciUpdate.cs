using Guna.UI2.WinForms;
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
    public partial class UC_KullaniciUpdate : UserControl
    {
        General genel = new General();  
        User kullanici = new User();
        public int firmaId;
        public UC_KullaniciUpdate()
        {
            InitializeComponent();

        }

        private void UC_KullaniciUpdate_Load(object sender, EventArgs e)
        {
            UsersList();
        }
        void UsersList ()
        {
            genel.listele("SP_USERS", dtg_Users);
        }

        private void dtg_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >=0)
            {
                int secilen = dtg_Users.SelectedCells[0].RowIndex;
                firmaId = Convert.ToInt32(dtg_Users.Rows[secilen].Cells[0].Value);
                aktar();
            }
        }
        void aktar()
        {
            kullanici.bilgiata(firmaId);
            txt_CompanyName.Text = kullanici.Company_Name;
            txt_Name.Text = kullanici.Name;
            txt_Surname.Text = kullanici.Surname;
            txt_Contact.Text = kullanici.Contact;
            txt_Username.Text = kullanici.User_Name;
            txt_Pass.Text = kullanici.Password;
            chckbxActive.Checked = kullanici.active;
            chckbxAdmin.Checked = kullanici.admin;
        }

        private void btn_UserUpdate_Click(object sender, EventArgs e)
        {
            genel.ekle("SP_KullaniciUpdate @firma_id = '"+firmaId+"'," +
                "@user_name = '"+txt_Username.Text+"'," +
                "@pass = '"+txt_Pass.Text+"'," +
                "@Kullanici_adi = '"+txt_Name.Text+"'," +
                "@Kullanici_soyadi = '"+txt_Surname.Text+"'," +
                "@Iletisim = '"+txt_Contact.Text+"'," +
                "@FirmaAdi = '"+txt_CompanyName.Text+"'," +
                "@isActive = "+chckbxActive.Checked+"," +
                "@isAdmin = "+chckbxAdmin.Checked+"");
            UsersList();
        }
    }
}
