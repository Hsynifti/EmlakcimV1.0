using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Transactions;

namespace MainDashboard
{
    public partial class UC_Musteri_Islemleri : UserControl
    {
        SQLAcces bgl = new SQLAcces();
        General genel = new General();
        public int firmaId { get; set; }
        public int MusteriID = -1;
        Add_Customer Musteri = new Add_Customer();

        public UC_Musteri_Islemleri()
        {
            InitializeComponent();
        }

        private void btn_CustomerAdd_Click(object sender, EventArgs e)
        {
            Musteri.Customer_Name = txtCustomerName.Text;
            Musteri.Customer_Surname = txtCustomerSurname.Text;
            Musteri.Customer_Phone = txtCustomerPhone.Text;
            Musteri.Customer_IdentyNo = txtTRIdentyNo.Text;
            Musteri.Firma_Id = firmaId;
            Musteri.Musteri_Ekle();
        }

        private void dtgMusteriIslemleri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int secilen = dtgMusteriIslemleri.SelectedCells[0].RowIndex;
                MusteriID = Convert.ToInt32(dtgMusteriIslemleri.Rows[secilen].Cells["Musteri_id"].Value);
            }
        }

        private void UC_Musteri_Islemleri_Load(object sender, EventArgs e)
        {
            genel.listele("execute musterilistele @FirmaId ='" + firmaId + "'", dtgMusteriIslemleri);
            genel.listele("execute musterilistele @FirmaId ='" + firmaId + "'", dtg_CustomerUpdate);

        }

        private void dtg_CustomerUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int secilen = dtg_CustomerUpdate.SelectedCells[0].RowIndex;
                MusteriID = Convert.ToInt32(dtgMusteriIslemleri.Rows[secilen].Cells["Musteri_id"].Value);
                aktar();
            }
        }
        void aktar()
        {
            Musteri.MusteriAta(MusteriID);
            txtMusteri_adi.Text = Musteri.Customer_Name;
            txtMusteri_soyadi.Text = Musteri.Customer_Surname;
            txtContact.Text = Musteri.Customer_Phone;
            txtTC_identyNo.Text = Musteri.Customer_IdentyNo;
            chckActive.Checked = Musteri.isActive;

        }

        private void btnCustomer_update_Click(object sender, EventArgs e)
        {
            
             DialogResult guncelle = MessageBox.Show("Seçilen müşteri bilgileri değiştirilecektir. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
             if (guncelle == DialogResult.Yes)
             {
                 genel.ekle("MusteriGuncelle @Musteri_id=" + MusteriID + "," +
                 "@Musteri_adi='" + txtMusteri_adi.Text + "'," +
                 "@Musteri_soyadi='" + txtMusteri_soyadi.Text + "'," +
                 "@Iletisim='" + txtContact.Text + "'," +
                 "@TcKimlik='" + Convert.ToDecimal(txtTC_identyNo.Text) + "',"+
                 "@isActive="+chckActive.Checked+"");
                 MessageBox.Show("Bilgiler başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                 genel.listele("execute musterilistele @FirmaId ='" + firmaId + "'", dtg_CustomerUpdate);
             }
             else
             {
                 MessageBox.Show("İşlem Gerçekleştirilmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            
            
        }
    }
}
