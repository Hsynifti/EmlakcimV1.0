﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transactions
{
    
    public class Add_Customer
    {
        SQLAcces bgl = new SQLAcces();
        public string Customer_Name { get; set; }
        public string Customer_Surname { get; set; }
        public string Customer_Phone { get; set; }
        public string Customer_IdentyNo { get; set; }

        public void Musteri_Ekle()
        {
            if (Customer_Name != "" && Customer_Surname != "")
            {
                SqlCommand komut = new SqlCommand("insert into T_Musteri (Musteriadi,Musterisoyadi,Iletisim,TCKimlik) values (@adi,@soyadi,@iletisim,@tckmlk)", bgl.baglanti());
                komut.Parameters.AddWithValue("@adi", Customer_Name);
                komut.Parameters.AddWithValue("@soyadi", Customer_Surname);
                komut.Parameters.AddWithValue("@iletisim", Customer_Phone);
                komut.Parameters.AddWithValue("@tckmlk", Customer_IdentyNo);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Customer_Name = Customer_Surname = Customer_Phone = Customer_IdentyNo = "";


            }
            else
                MessageBox.Show("Lütfen Ad ve Soyad Bilgilerini Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}