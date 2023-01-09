using System;
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
        General genel = new General();
        public string Customer_Name { get; set; }
        public string Customer_Surname { get; set; }
        public string Customer_Phone { get; set; }
        public string Customer_IdentyNo { get; set; }
        public int Firma_Id { get; set; }

        public void Musteri_Ekle()
        {
            if (Customer_Name != "" && Customer_Surname != "")
            {
                //MUSTERİ EKLEME
                genel.ekle("Musteriekle @adi='" + Customer_Name + "', @soyadi='" + Customer_Surname + "',@iletisim='" + Customer_Phone + "',@tc='" + Customer_IdentyNo + "',@firmaId='" + Firma_Id + "'");
                MessageBox.Show("Müşteri Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Customer_Name = Customer_Surname = Customer_Phone = Customer_IdentyNo = "";


            }
            else
                MessageBox.Show("Lütfen Ad ve Soyad Bilgilerini Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}