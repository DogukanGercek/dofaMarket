﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.Data.SqlClient;


namespace dofaMarketForm
{
    internal class ConnectionString
    {
        public SqlConnection GetCon() { 
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=34.155.53.38;Initial Catalog=market-database;Persist Security Info=True;User ID=sqlserver;Password=Knmi^$O$tI0)MnG`";
            return baglanti;
            

        }
    }
}
