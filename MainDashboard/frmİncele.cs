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
        string esyalar;
        private void incele_Load(object sender, EventArgs e)
        {
            //emlak_id datagridten alınır
            EmlakID = Convert.ToInt32(guna2DataGridView1.Rows[0].Cells[0].Value);
            //BELLİ BİR EMLAĞIN ESYALARINI GETİRİR. 2. parametre,sütun başlığıdır.
            esyalar=(genel.Veri("Esyalar @emlakID='"+EmlakID+"'","Esyalar").ToString());
            //SqlCommand komut = new SqlCommand("select Esyalar  from T_Emlak where Emlak_id='"+EmlakID+"'", bgl.baglanti());
            //SqlDataReader oku = komut.ExecuteReader();
            //while (oku.Read())
            //    esyalar = oku["Esyalar"].ToString();

            //veritabanından gelen emlak eşyaları checkedlistboxa aktarır
            var ESYA = esyalar.Split(',');
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(ESYA);
            //varolan esyaları işaretler
            for (byte i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, true);
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
