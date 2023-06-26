using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MuhasebeOtomasyons
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-V1AII2C\SQLEXPRESS;Initial Catalog=MuhasebeODB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
