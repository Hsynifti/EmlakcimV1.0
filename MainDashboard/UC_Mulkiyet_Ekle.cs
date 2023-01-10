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
        public int firmaId { get; set; }

        public UC_Mulkiyet_Ekle(int firma_id)
        {
            firmaId= firma_id;
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
            genel.cmbdoldur("Isitmaadi", "Isitma_id", "Isitma_Getir", txtIsitma);
            // esyalar checkedlistbox veritabanından ceri gelmeyecek şekilde seğiştirildi
            //genel.cboxdoldur("Esya", "Esya_id", "Esya_Getir", lstEsyalar);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //checkedlistbox secili itemleri aralarına "," atarak degiskene aktarır
                string esyalar=",";
                foreach (string s in lstEsyalar.CheckedItems)
                {
                    esyalar += s + ",";
                }
                //son "," karakteri siler sonraki satırda insert eder.
                esyalar = esyalar.Substring(0, esyalar.Length - 1);
                //Emlak Kayıt
                genel.ekle("Emlakekle @adi='"+txtEmlak_Adi.Text+"'," +
                    "@Durumid='"+cmbEmlak_Durum.SelectedValue+"'," +
                    "@turid='"+cmbEmlak_Turu.SelectedValue+"' ," +
                    "@semtid='"+cmb_Semt.SelectedValue+"' ," +
                    "@metrekare='"+int.Parse(txtMetrekare.Text)+"'," +
                    "@cephe='"+cmb_Cephe.Text+"'," +
                    "@kat='"+int.Parse(txtKat.Text)+"'," +
                    "@yapiyasi='"+int.Parse(txtYapi_Yasi.Text)+"'," +
                    "@odasayisi='"+txtOda_Sayisi.Text+"'," +
                    "@fiyat='"+Convert.ToInt32(txtSatisFiyati.Text)+"'," +
                    "@SatinAlinanFiyat='" + Convert.ToInt32(txtSatinAlinanFiyat.Text) + "'," +
                    "@adres='" +txtAdres.Text+"'," +
                    "@isitmaid='"+txtIsitma.SelectedValue+"'," +
                    "@firmaid='"+firmaId+"'," +
                    "@esya='"+esyalar+"'");

            MessageBox.Show("Emlak Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
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
            genel.cmbdoldur("Semtadi", "Semt_id", "Semt_Getir @ilceid='" + cmb_Ilce.SelectedValue + "'", cmb_Semt);
        }

        private void guna2ComboBox10_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //ilçeler combobox
            genel.cmbdoldur("Ilceadi", "Ilce_id", "Ilce_Getir @ilid='" + cmbEmlak_Sehir.SelectedValue + "'", cmb_Ilce);

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstEsyalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
