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
    public partial class UC_Satislar : UserControl
    {
        SQLAcces bgl = new SQLAcces();
        General genel=new General();
        public int firmaId { get; set; }
        public UC_Satislar(int firma_id)
        {
            firmaId = firma_id;
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //satislar
        private void UC_Satislar_Load(object sender, EventArgs e)
        {
            //SATISLAR DATAGRİDVİEW
            genel.listele("satislar @FirmaId = '"+firmaId+"'", guna2DataGridView1);
        }
    }
}
