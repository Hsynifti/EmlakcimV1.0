using Guna.Charts.WinForms;
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
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainDashboard
{
    public partial class UC_AnaSayfa : UserControl
    {
        General genel = new General();
        SQLAcces ac = new SQLAcces();
        public UC_AnaSayfa()
        {
            InitializeComponent();
        }

        private void UC_AnaSayfa_Load(object sender, EventArgs e)
        {
            

        }







        /*private void ChartDoldur(string _StoredProcedure)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = ac.baglanti())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = _StoredProcedure;
                    using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                    {
                        adap.Fill(ds);
                    }
                }
                conn.Close();

            }
            /*SqlDataAdapter adapt = new SqlDataAdapter("Select ad,maas from personel", con);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            chart1.Series["Maas"].XValueMember = "ad";
            chart1.Series["Maas"].YValueMembers = "maas";
            chart1.Titles.Add("Maaş Grafiği");
            con.Close();*/


    }
}
