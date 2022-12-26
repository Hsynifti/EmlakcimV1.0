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
        Add_Customer Musteri = new Add_Customer();
        public UC_Musteri_Islemleri()
        {
            InitializeComponent();
        }

        private void btn_CustomerAdd_Click(object sender, EventArgs e)
        {
            Musteri.Customer_Name = txtCustomerName.Text;
            Musteri.Customer_Surname= txtCustomerSurname.Text;
            Musteri.Customer_Phone = txtCustomerPhone.Text;
            Musteri.Customer_IdentyNo = txtTRIdentyNo.Text;
            Musteri.Musteri_Ekle();   
        }
    }
}
