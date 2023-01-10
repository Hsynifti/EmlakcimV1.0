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

        public UC_Musteri_Islemleri(int firma_id)
        {
            InitializeComponent();
            firmaId = firma_id;
             
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
        }
    }
}
