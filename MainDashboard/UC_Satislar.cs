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
            SqlCommand komut = new SqlCommand("execute satislar @FirmaId = @firmaId", bgl.baglanti());
            komut.Parameters.AddWithValue("@firmaId", firmaId);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
    }
}
