using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WGSDataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class WGSCRUDService : ICRUDService
    {

        #region ICRUDService Members

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public System.Data.DataSet GetDataSet(string strSQL)
        {
            SqlConnection db = new SqlConnection();
            db = Connection.GetDBConn();
            SqlCommand SQLCom = new SqlCommand(strSQL, db);
            SqlDataAdapter SQLAdap = new SqlDataAdapter(SQLCom);
            DataSet ds = new DataSet();
            SQLAdap.Fill(ds);

            return ds; 
        }

        public DataTable GetDataTable(string strSQL, string tblName)
        {
            SqlConnection db = new SqlConnection();
            db = Connection.GetDBConn();
            SqlCommand SQLCom = new SqlCommand(strSQL, db);
            SqlDataAdapter SQLAdap = new SqlDataAdapter(SQLCom);
            DataTable dt = new DataTable(tblName);
            SQLAdap.Fill(dt);

            return dt; 
        }
        public int Exec(string strSQL)
        {
            int result;
            SqlConnection MsCon = new SqlConnection();
            MsCon = Connection.GetDBConn();
            SqlCommand MsCom = new SqlCommand(strSQL, MsCon);
            result = MsCom.ExecuteNonQuery();
            return result;

        }
        #endregion
    }
}
