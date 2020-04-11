using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastane_projesi
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            baglantiyolu yol = new baglantiyolu();
            SqlConnection baglan = new SqlConnection(yol.adres);
            baglan.Open();
            return baglan;
        }
    }
}
