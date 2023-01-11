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
    public partial class UC_Hesap : UserControl
    {
        General genel = new General();
        User kullanici=new User();
        public int FirmaId { get; set; }
        public UC_Hesap()
        {
            InitializeComponent();
        }
        void aktar()
        {
            kullanici.bilgiata(FirmaId);
            guna2TextBox1.Text = kullanici.Company_Name;
            guna2TextBox3.Text = kullanici.Name;
            guna2TextBox5.Text = kullanici.Surname;
            guna2TextBox6.Text = kullanici.Contact;
            guna2TextBox2.Text = kullanici.User_Name;
            guna2TextBox4.Text = kullanici.Password;
            guna2TextBox7.Text = kullanici.profit.ToString();
        }
        private void UC_Hesap_Load(object sender, EventArgs e)
        {
            aktar();
            guna2TextBox3.Text = kullanici.User_Name.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            genel.ekle("HesapGuncelle @firmaId='"+FirmaId+"'," +
                "@user_name='"+guna2TextBox2.Text+"'," +
                "@pass='"+guna2TextBox4.Text+"'," +
                "@Kullanici_adi='"+guna2TextBox3.Text+"'," +
                "@Kullanici_soyadi='"+guna2TextBox5.Text+"'," +
                "@Iletisim='"+guna2TextBox6.Text+"'," +
                "@FirmaAdi='"+guna2TextBox1.Text+"'," +
                "@Profit='"+int.Parse(guna2TextBox7.Text)+"'");
            MessageBox.Show("Kullanıcı Bilgileri Güncellendi", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            DialogResult onay = MessageBox.Show("Hesabınızı Donduracağınıza Emin Misiniz?\nEvet Derseniz Hesabınıza Erişemeyeceksiniz!", "Hesap Dondurma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(onay==DialogResult.Yes)
            {
            genel.ekle("Aktif_Pasif @aktif='" + 0 + "'," +
                "@firmaId='"+FirmaId+"'");
            MessageBox.Show(kullanici.Company_Name.ToString()+" Hesabınız Donduruldu.", "Hesap Yetkisi Alındı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Application.Exit();
                Environment.Exit(0);
            }

        }
    }
}
