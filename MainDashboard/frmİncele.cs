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
    public partial class frmİncele : Form
    {
        SQLAcces bgl = new SQLAcces();
        General genel=new General();
        public frmİncele()
        {
            InitializeComponent();
        }
        int EmlakID;
        string esyalar,Esyalar;
        private void incele_Load(object sender, EventArgs e)
        {
            //emlak_id datagridten alınır
            EmlakID = Convert.ToInt32(dtgEmlak.Rows[0].Cells[0].Value);
            //BELLİ BİR EMLAĞIN ESYALARINI GETİRİR. 2. parametre,sütun başlığıdır.
            esyalar=(genel.Veri("Esyalar @emlakID='"+EmlakID+"'","Esyalar").ToString());
          
            //veritabanından gelen emlak eşyaları checkedlistboxa aktarır
            var ESYA = esyalar.Split(',');
            lstEsyalar.Items.Clear();
            lstEsyalar.Items.AddRange(ESYA);
            //varolan esyaları işaretler
            for (byte i = 0; i < lstEsyalar.Items.Count; i++)
                lstEsyalar.SetItemChecked(i, true);


            //txtboxlari atama
            aktar();
            

        }
        void aktar()//araclara datagridten veri aktarma
        {
            txtAdi.Text = dtgEmlak.Rows[0].Cells[1].Value.ToString();
            txtOdasayisi.Text = dtgEmlak.Rows[0].Cells[7].Value.ToString();
            txtFiyat.Text = Convert.ToInt32( dtgEmlak.Rows[0].Cells[8].Value).ToString();
            //emlak durumu cmbobox 
            genel.cmbdoldur("Durum", "Durum_id", "Durum_Getir", cmbEmlak_Durum);
            cmbEmlak_Durum.Text = (dtgEmlak.Rows[0].Cells[4].Value).ToString();
            //ısıtma combobox
            genel.cmbdoldur("Isitmaadi", "Isitma_id", "Isitma_Getir", cmbIsitma);
            cmbIsitma.Text = (dtgEmlak.Rows[0].Cells[5].Value).ToString();
            
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }
        //EMLAK DÜZENLEME
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //checkedlistbox secili itemleri aralarına "," atarak degiskene aktarır
            Esyalar = ",";
            foreach (string s in lstEsyalar.CheckedItems)
            {
                Esyalar += s + ",";
            }
            //son "," karakteri siler sonraki satırda insert eder.
            Esyalar = Esyalar.Substring(0, Esyalar.Length - 1);
            genel.ekle("SP_Emlakguncelle @emlak_id = '" + EmlakID + "', " +
                  "@adi='" + txtAdi.Text + "'," +
                  "@durumid='" + cmbEmlak_Durum.SelectedValue + "'," +
                  "@odasayisi='" + txtOdasayisi.Text + "'," +
                  "@isitmaid='" + cmbIsitma.SelectedValue + "'," +
                  "@fiyat='" + txtFiyat.Text + "',"+
                  "@esya='"+Esyalar+"'");
            genel.listele("emlakincele @emlak_id='" + EmlakID + "'", dtgEmlak);
            MessageBox.Show("Emlak Bilgileri Güncellendi", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
        }
        //EMLAK SİLME
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult sil = MessageBox.Show("Seçili Emlak Silinecektir. Emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sil == DialogResult.Yes)
            {
                genel.ekle("SP_Emlaksil @emlak_id = '" + EmlakID + "'");
                this.Close();
            } 

        }
    }
}
