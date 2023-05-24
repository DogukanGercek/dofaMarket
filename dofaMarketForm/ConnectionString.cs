using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace dofaMarketForm
{
    internal class ConnectionString
    {
        public SqlConnection GetCon() { 
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=DESKTOP-29SJKEI\SQLEXPRESS;Initial Catalog=C:\USERS\NDOGU\DOCUMENTS\DOFAMARKETDB.MDF;Integrated Security=True";
            return baglanti;

        }
    }
}
