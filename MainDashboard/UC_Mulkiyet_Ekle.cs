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
            genel.cmbdoldur("Isitmaadi", "Isitma_id", "Isitma_Getir", guna2ComboBox6);
            // esyalar checkedlistbox veritabanından ceri gelmeyecek şekilde seğiştirildi
            //genel.cboxdoldur("Esya", "Esya_id", "Esya_Getir", lstEsyalar);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //checkedlistbox secili itemleri aralarına "," atarak degiskene aktarır
                string esyalar="";
                foreach (string s in lstEsyalar.CheckedItems)
                {
                    esyalar += s + ",";
                }
                //son "," karakteri siler sonraki satırda insert eder.
                esyalar = esyalar.Substring(0, esyalar.Length - 1);
                //Emlak Kayıt
                genel.ekle("Emlakekle @adi='"+guna2TextBox1.Text+"',@Durumid='"+cmbEmlak_Durum.SelectedValue+"',@turid='"+cmbEmlak_Turu.SelectedValue+"' ,@semtid='"+guna2ComboBox11.SelectedValue+"' ,@metrekare='"+int.Parse(guna2TextBox5.Text)+"',@cephe='"+guna2ComboBox4.Text+"',@kat='"+int.Parse(guna2TextBox3.Text)+"',@yapiyasi='"+int.Parse(guna2TextBox7.Text)+"',@odasayisi='"+guna2TextBox6.Text+"',@fiyat='"+guna2TextBox4.Text+"',@adres='"+guna2TextBox2.Text+"',@isitmaid='"+guna2ComboBox6.SelectedValue+"',@firmaid='"+firmaId+"',@esya='"+esyalar+"'");
                //MessageBox.Show(esyalar.ToString());
            //    SqlCommand komutekle = new SqlCommand("insert into T_Emlak(Emlakadi,Durum_id,Tur_id,Semt_id,Metrekare,Cephe,Kat,Yapiyasi,Odasayisi,Fiyat,Adres,Isitma_id,Firma_id,Esyalar) values (@ad,@durum,@tur,@semt,@mkare,@cephe,@kat,@yas,@odasayisi,@fiyat,@adres,@isitma,@firmaId,@esyalar)", bgl.baglanti());
            //komutekle.Parameters.AddWithValue("@ad", guna2TextBox1.Text);
            //komutekle.Parameters.AddWithValue("@durum", cmbEmlak_Durum.SelectedValue);
            //komutekle.Parameters.AddWithValue("@tur", cmbEmlak_Turu.SelectedValue);
            //komutekle.Parameters.AddWithValue("@semt", guna2ComboBox11.SelectedValue);
            //komutekle.Parameters.AddWithValue("@mkare", int.Parse(guna2TextBox5.Text));
            //komutekle.Parameters.AddWithValue("@cephe", guna2ComboBox4.Text);
            //komutekle.Parameters.AddWithValue("@kat", int.Parse(guna2TextBox3.Text));
            //komutekle.Parameters.AddWithValue("@yas", int.Parse(guna2TextBox7.Text));
            //komutekle.Parameters.AddWithValue("@odasayisi", guna2TextBox6.Text);
            //komutekle.Parameters.AddWithValue("@fiyat", guna2TextBox4.Text);
            //komutekle.Parameters.AddWithValue("@adres", guna2TextBox2.Text);
            //komutekle.Parameters.AddWithValue("@isitma", guna2ComboBox6.SelectedValue);
            //komutekle.Parameters.AddWithValue("@firmaId", firmaId);
            //komutekle.Parameters.AddWithValue("@esyalar", esyalar);
            //komutekle.ExecuteNonQuery();
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
        //Eşyalı mı combobox , GEREK YOK SİLİNMELİ m.
        private void guna2ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (guna2ComboBox7.SelectedValue != null)
            //{
            //    var item = guna2ComboBox7.SelectedItem.ToString();
            //    lstEsyalar.Enabled = item == "Evet";
            //}
            //else
            //{ 
            //    lstEsyalar.Enabled = false;
            //}
            if (guna2ComboBox7.Text == "Evet")
                lstEsyalar.Enabled = true;
            else
                lstEsyalar.Enabled = false;
        }

        private void lstEsyalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
