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
    public partial class UC_Mulkiyetler : UserControl
    {
        SQLAcces bgl = new SQLAcces();
        General genel = new General();  
        satis frmSatis=new satis();
        incele frmIncele = new incele();
        public UC_Mulkiyetler()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection("Data Source=MAZLUM;Initial Catalog=Emlak;Integrated Security=True");
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        #region İL-İLÇE-MAHALLE comboboxlara atama
        
        private void UC_Mulkiyetler_Load(object sender, EventArgs e)
        {
            //şehir combobox
            genel.cmbdoldur("Iladi", "Il_id", "Sehir_Getir", cmbEmlak_Sehir);
            //durum combobox
            genel.cmbdoldur("Durum", "Durum_id", "Durum_Getir", cmbEmlak_Durum);
            //emlak tipi
            genel.cmbdoldur("Emlaktipiadi", "Emlaktipi_id", "Tip_Getir", cmbEmlak_Tipi);
            //emlaklar datagrid
            emlaklar();

        }
        public void emlaklar()
        {
            //emlaklar datagrid
            SqlCommand komut4 = new SqlCommand("execute emlaklar", bgl.baglanti());
            SqlDataAdapter da4 = new SqlDataAdapter(komut4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            guna2DataGridView1.DataSource = dt4;
            bgl.baglanti().Close();
        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //ilçeler combobox
            genel.cmbdoldur("Ilceadi","Ilce_id","Ilce_Getir @ilid='"+cmbEmlak_Sehir.SelectedValue+"'",guna2ComboBox3);
        }

        private void guna2ComboBox6_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //mahalle-köy combobox
            genel.cmbdoldur("Semtadi", "Semt_id", "Semt_Getir @ilceid='"+guna2ComboBox3.SelectedValue+"'", guna2ComboBox6);

        }
        #endregion

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //emlak türü
        private void guna2ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            genel.cmbdoldur("Turu","Tur_id","Emlakturu_Getir @tipid='"+cmbEmlak_Tipi.SelectedValue+"'",guna2ComboBox2);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //incele
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    SqlCommand komut = new SqlCommand("execute emlakincele @emlak_id=@emlakid", bgl.baglanti());
                    komut.Parameters.AddWithValue("@emlakid", guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    frmIncele.guna2DataGridView1.DataSource = dt;
                    frmIncele.ShowDialog();
                }
                if (e.ColumnIndex == 1)
                {
                    SqlCommand komut = new SqlCommand("execute emlakincele @emlak_id=@emlakid", bgl.baglanti());
                    komut.Parameters.AddWithValue("@emlakid", guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    frmSatis.guna2DataGridView1.DataSource = dt;
                    frmSatis.ShowDialog();
                }

            }
        }
    }
}
