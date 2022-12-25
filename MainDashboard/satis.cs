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
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }
        SQLAcces bgl=new SQLAcces();
        //Musteri_id 
        int MusteriID=-1;
        private void rdYeni_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void satis_Load(object sender, EventArgs e)
        {
            musterilistele();
        }
        void musterilistele()
        {
            SqlCommand komut = new SqlCommand("execute musterilistele", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgMusteriler.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void rdVarolan_CheckedChanged(object sender, EventArgs e)
        {
        }
        //sat butonu:eğer emlak boş değilse uyarı verip satışı yapmaz
        private void btnSat_Click(object sender, EventArgs e)
        {
            if (txtMusteriadi.Text == "" && txtMusteriSoyadi.Text == "")
            {
                MessageBox.Show("Tablodan müşteri seçiniz. Eğer müşteri yeniyse \n sol taraftan müşterinin bilgilerini girip \n ardından 'Müşteri Ekle' butonuna tıklayarak tablodan seçiniz.", "Müşteri Seçmediniz!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int tabloemlakid = Convert.ToInt32(guna2DataGridView1.Rows[0].Cells[0].Value);
                int EmlakID = -1;
                SqlCommand komut = new SqlCommand("select * from T_Satis where Emlak_id='" + tabloemlakid + "'", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    EmlakID = Convert.ToInt32(oku["Emlak_id"].ToString());
                }
                if (EmlakID == tabloemlakid)
                {
                    MessageBox.Show("Emlak Başkası Adına Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut1 = new SqlCommand("insert into T_Satis (Emlak_id,Musteri_id) values (@emlakid,@musteriid)", bgl.baglanti());
                    komut1.Parameters.AddWithValue("@emlakid", tabloemlakid);
                    komut1.Parameters.AddWithValue("@musteriid", MusteriID);
                    komut1.ExecuteNonQuery();
                    bgl.baglanti().Close();


                    MessageBox.Show("Emlak Başarıyla Devredildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                bgl.baglanti().Close();
                txtMusteriadi.Text = txtMusteriSoyadi.Text = txtMusteriIletisim.Text = "";
                MusteriID = -1;
            }
        }

        private void dtgMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgMusteriler.SelectedCells[0].RowIndex;
            MusteriID = Convert.ToInt32(dtgMusteriler.Rows[secilen].Cells[0].Value);
            txtMusteriadi.Text = dtgMusteriler.Rows[secilen].Cells[1].Value.ToString();
            txtMusteriSoyadi.Text = dtgMusteriler.Rows[secilen].Cells[2].Value.ToString();
            txtMusteriIletisim.Text = dtgMusteriler.Rows[secilen].Cells[3].Value.ToString();
            TCKmlktxt.Text = dtgMusteriler.Rows[secilen].Cells[4].Value.ToString();
        }

        private void txtIletisim_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTcKmlk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dtgMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
