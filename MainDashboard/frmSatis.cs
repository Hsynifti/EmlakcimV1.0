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
    public partial class frmSatis : Form
    {
        SQLAcces bgl = new SQLAcces();
        General genel = new General();
        public int firmaId { get; set; }
        public frmSatis()
        {
            InitializeComponent();
        }
        //Musteri_id 
        int MusteriID=-1;
        private void satis_Load(object sender, EventArgs e)
        {
            //MUSTERİ LİSTELEME
            genel.listele("musterilistele @FirmaId ='" + firmaId + "'", dtgMusteriler);
        }
        //sat butonu:eğer emlak boş değilse uyarı verip satışı yapmaz
        private void btnSat_Click(object sender, EventArgs e)
        {
            if (txtMusteriadi.Text == "" && txtMusteriSoyadi.Text == "")
            {
                MessageBox.Show("Tablodan müşteri seçiniz.","Müşteri Seçmediniz!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int tabloemlakid = Convert.ToInt32(dtgEmlakSatis.Rows[0].Cells[0].Value);
                int EmlakID = -1;
                //Satiş tablosundan belli bir Emlak_id'i çekilecek varsa değişkene atar yok ise üstteki mümkün olmayan negatif değer sabit kalır
                EmlakID=Convert.ToInt32(genel.Veri("SatisEmlakID @EmlakId='"+tabloemlakid+"'", "Emlak_id"));
                //seçilen emlağın emlak_id'i satış tablosunda da varsa başkası adına kayıtlı mesajı verip satış işlemi olmaz. 
                if (EmlakID == tabloemlakid)
                {
                    MessageBox.Show("Emlak Başkası Adına Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Satış tablosuna ekleme
                    genel.ekle("Satisekle @EmlakId='" + tabloemlakid + "' ,@MusteriId='" + MusteriID + "',@FirmaId='" + firmaId + "'");
                    MessageBox.Show("Emlak Başarıyla Devredildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                txtMusteriadi.Text = txtMusteriSoyadi.Text = txtMusteriIletisim.Text =TCKmlktxt.Text= "";
                MusteriID = -1;
            }
            
        }

        private void dtgMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgMusteriler.SelectedCells[0].RowIndex;
            MusteriID = Convert.ToInt32(dtgMusteriler.Rows[secilen].Cells[1].Value);
            txtMusteriadi.Text = dtgMusteriler.Rows[secilen].Cells[2].Value.ToString();
            txtMusteriSoyadi.Text = dtgMusteriler.Rows[secilen].Cells[3].Value.ToString();
            txtMusteriIletisim.Text = dtgMusteriler.Rows[secilen].Cells[4].Value.ToString();
            TCKmlktxt.Text = dtgMusteriler.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
