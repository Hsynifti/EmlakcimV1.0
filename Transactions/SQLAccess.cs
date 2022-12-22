using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transactions
{
    public class SQLAcces
    {
        public SqlConnection baglanti()
        {
            SqlConnection conn = new SqlConnection("Data Source=MAZLUM;Initial Catalog=Emlak;Integrated Security=True");
            conn.Open();
            return conn;
        }
        
    }
}
