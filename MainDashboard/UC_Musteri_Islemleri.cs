using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transactions;

namespace MainDashboard
{
    public partial class UC_Musteri_Islemleri : UserControl
    {
        SQLAcces bgl = new SQLAcces();
        public UC_Musteri_Islemleri()
        {
            InitializeComponent();
        }

        private void btn_CustomerAdd_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text != "" && txtCustomerSurname.Text != "")
            {
                SqlCommand komut = new SqlCommand("insert into T_Musteri (Musteriadi,Musterisoyadi,Iletisim,TCKimlik) values (@adi,@soyadi,@iletisim,@tckmlk)", bgl.baglanti());
                komut.Parameters.AddWithValue("@adi", txtCustomerName.Text);
                komut.Parameters.AddWithValue("@soyadi", txtCustomerSurname.Text);
                komut.Parameters.AddWithValue("@iletisim", txtCustomerPhone.Text);
                komut.Parameters.AddWithValue("@tckmlk", txtTRIdentyNo.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerName.Text = txtCustomerSurname.Text = txtCustomerPhone.Text = "";
                

            }
            else
                MessageBox.Show("Lütfen Ad ve Soyad Bilgilerini Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
    }
}
