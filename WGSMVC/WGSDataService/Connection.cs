using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WGSDataService
{
    public class Connection
    {
        public static SqlConnection GetDBConn()
        {

            SqlConnection dbConn = new SqlConnection();
            string ConnectionStringName = System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            dbConn.ConnectionString = ConnectionStringName;

            if (dbConn == null || dbConn.State != System.Data.ConnectionState.Open)
            {
                dbConn.Open();
            }
            return dbConn;
        }
    }
}