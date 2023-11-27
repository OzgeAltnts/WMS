using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WMS_Project
{
     class SqlBaglanti 
    {
        public SqlConnection baglanti()
        {
            SqlConnection b = new SqlConnection(@"Data Source = DESKTOP-F2SN8FC;Initial Catalog = WMS;Integrated Security=True");
            b.Open();
            return b;
        }
  
    }
}
