using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WGSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class WGSService : IWGSService
    {
        #region IWGSService Members
        
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public System.Data.DataSet GetDataSet(string cmdstring)
        {
            SqlConnection MsCon = new SqlConnection();
            MsCon = Connection.GetDBConn();
            SqlCommand MsComm = new SqlCommand( cmdstring, MsCon);
            SqlDataAdapter MsAdap = new SqlDataAdapter(MsComm);
            DataSet ds = new DataSet();

            try {
                //MsCon.ConnectionString = Constr;
                //MsCon.Open();
                MsAdap.Fill(ds);

                return ds;
            }
            catch (Exception e) {
                return null;
            }
            finally {
                
            }

        }

        public System.Data.DataTable GetDataTable(string cmdstring)
        {
            SqlConnection MsCon = new SqlConnection();
            MsCon = Connection.GetDBConn();
            SqlCommand MsCom = new SqlCommand(cmdstring, MsCon);
            SqlDataAdapter MsAdp = new SqlDataAdapter(MsCom);
            DataTable dt = new DataTable();
            MsAdp.Fill(dt);

            return dt;
        }

        public string SQLExeNoPara(string cmdstring)
        {
            SqlConnection MsCon = new SqlConnection();
            MsCon = Connection.GetDBConn();
            SqlCommand MsCom = new SqlCommand(cmdstring, MsCon);
            int result=0;
            result= MsCom.ExecuteNonQuery();
            return result.ToString();
        }

        public int exec(string sqlStr)
        {
            int result;
            SqlConnection MsCon = new SqlConnection();
            MsCon = Connection.GetDBConn();
            SqlCommand MsCom = new SqlCommand(sqlStr, MsCon);
            result = MsCom.ExecuteNonQuery();
            return result;
        }
        #endregion


    }
}
