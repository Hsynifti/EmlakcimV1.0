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
using System.Windows.Forms;
using Transactions;


namespace MainDashboard 
{
    public partial class UC_Mulkiyet_Ekle : UserControl
    {
        SQLAcces bgl = new SQLAcces();
        General genel = new General();

        public UC_Mulkiyet_Ekle()
        {
            InitializeComponent();
        }
        private void UC_Mulkiyet_Ekle_Load(object sender, EventArgs e)
        {
            //Emlak Tipi combobox
            genel.cmbdoldur("Emlaktipiadi", "Emlaktipi_id", "Tip_Getir", cmbEmlak_Tipi);
            //şehir combobox
            genel.cmbdoldur("Iladi", "Il_id", "Sehir_Getir", cmbEmlak_Sehir);
            //durum combobox
            genel.cmbdoldur("Durum", "Durum_id", "Durum_Getir", cmbEmlak_Durum);
            //ısıtma combobox
            genel.cmbdoldur("Isitmaadi", "Isitma_id", "Isitma_Getir", guna2ComboBox6);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into T_Emlak(Emlakadi,Durum_id,Tur_id,Semt_id,Metrekare,Cephe,Kat,Yapiyasi,Odasayisi,Fiyat,Adres,Isitma_id) values (@ad,@durum,@tur,@semt,@mkare,@cephe,@kat,@yas,@odasayisi,@fiyat,@adres,@isitma)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@ad", guna2TextBox1.Text);
            komutekle.Parameters.AddWithValue("@durum", cmbEmlak_Durum.SelectedValue);
            komutekle.Parameters.AddWithValue("@tur", cmbEmlak_Turu.SelectedValue);
            komutekle.Parameters.AddWithValue("@semt", guna2ComboBox11.SelectedValue);
            komutekle.Parameters.AddWithValue("@mkare", Convert.ToInt32(guna2TextBox5.Text));
            komutekle.Parameters.AddWithValue("@cephe", guna2ComboBox4.Text);
            komutekle.Parameters.AddWithValue("@kat", Convert.ToInt32(guna2TextBox3.Text));
            komutekle.Parameters.AddWithValue("@yas", Convert.ToInt32(guna2TextBox7.Text));
            komutekle.Parameters.AddWithValue("@odasayisi", guna2TextBox6.Text);
            komutekle.Parameters.AddWithValue("@fiyat", guna2TextBox4.Text);
            komutekle.Parameters.AddWithValue("@adres", guna2TextBox2.Text);
            komutekle.Parameters.AddWithValue("@isitma", guna2ComboBox6.SelectedValue);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Emlak Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //emlak-türü
            genel.cmbdoldur("Turu", "Tur_id", "Emlakturu_Getir @tipid='" + cmbEmlak_Tipi.SelectedValue + "'", cmbEmlak_Turu);
        }

        private void guna2ComboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //mahalle-köy combobox
            genel.cmbdoldur("Semtadi", "Semt_id", "Semt_Getir @ilceid='" + guna2ComboBox3.SelectedValue + "'", guna2ComboBox11);
        }

        private void guna2ComboBox10_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //ilçeler combobox
            genel.cmbdoldur("Ilceadi", "Ilce_id", "Ilce_Getir @ilid='" + cmbEmlak_Sehir.SelectedValue + "'", guna2ComboBox3);

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox7.SelectedValue != null)
            {
                var item = guna2ComboBox7.SelectedItem.ToString();
                lstEsyalar.Enabled = item == "Evet";
            }
            else
            { 
                lstEsyalar.Enabled = false;
            }
        }
        

    }
    
}
