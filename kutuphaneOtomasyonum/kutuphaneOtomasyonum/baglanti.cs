using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kutuphaneOtomasyonum
{
    class baglanti
    {
        public SqlConnection baglan()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-D42F0SJ\\SQLEXPRESS;Initial Catalog=kutuphaneProjem;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
