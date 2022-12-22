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
    }
}
