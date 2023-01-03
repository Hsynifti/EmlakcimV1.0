using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transactions
{
    public class General
    {
        SQLAcces ac = new SQLAcces();

        public void cmbdoldur(string _DisplayMember, string _ValueMember, string _StoredProcedure, ComboBox  cmb)
        {
            DataTable dtb = new DataTable();
            using (SqlConnection conn = ac.baglanti())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                    {
                    cmd.CommandText = _StoredProcedure;
                    //aşağıdaki satır parametreli procedurlerde hata verir
                    //cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                    {
                        adap.Fill(dtb);
                    }
                 }
                conn.Close();
               
            }
            cmb.DataSource = dtb;
            cmb.DisplayMember = _DisplayMember;
            cmb.ValueMember = _ValueMember;
            
        }
        //CHECKEDLİSTBOX VERİ AKTARMA
        public void cboxdoldur(string _DisplayMember, string _ValueMember, string _StoredProcedure, CheckedListBox clbox)
        {
            DataTable dtb = new DataTable();
            using (SqlConnection conn = ac.baglanti())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = _StoredProcedure;
                    using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                    {
                        adap.Fill(dtb);
                    }
                }
                conn.Close();

            }
            clbox.DataSource = dtb;
            clbox.DisplayMember = _DisplayMember;
            clbox.ValueMember = _ValueMember;
        }
        //EKLEME
        public void ekle(string _StoredProcedure)
        {
            SqlCommand Ekle = new SqlCommand(_StoredProcedure, ac.baglanti());
            Ekle.ExecuteNonQuery();
            ac.baglanti().Close();
        }
        //DATAGRİDVİEW VERİ AKTARMA
        public void listele(string _StoredProcedure,DataGridView dtg)
        {
            DataTable dtb = new DataTable();
            using (SqlConnection conn = ac.baglanti())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = _StoredProcedure;
                    using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                    {
                        adap.Fill(dtb);
                    }
                }
                conn.Close();

            }
            dtg.DataSource = dtb;
        }
        //SÜTUNDAN VERİ ÇEKME
        public object Veri(string _StoredProcedure,string sutun)
        {
            object veri=-1;
            SqlCommand komut = new SqlCommand(_StoredProcedure,ac.baglanti());
            SqlDataReader oku=komut.ExecuteReader();
            while(oku.Read())
            {
                veri = oku[sutun];
            }
            ac.baglanti().Close();
            return veri;
        }
        
    }
}
