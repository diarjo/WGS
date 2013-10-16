using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WGSBase
{
    public sealed class DataService 
    {
        TRANService.CRUDServiceClient mTrans;
        //public DataSet GetDataTable(string sqlStr)
        public DataTable GetDataTable(string sqlStr, string tblName)
        {
            TRANService.CRUDServiceClient myCred;

            if (mTrans == null)
                { myCred = GetCRUDService(); }
            else
                { myCred = mTrans; }

            DataTable ds = new DataTable();
            //DataSet ds = new DataSet();
            ds = myCred.GetDataTable(sqlStr, tblName);
            //ds = myCred.GetDataSet(sqlStr);

            return ds;
        }


        public TRANService.CRUDServiceClient  GetCRUDService() {
            TRANService.CRUDServiceClient mTrans = new TRANService.CRUDServiceClient();
            mTrans.ClientCredentials.Windows.ClientCredential.UserName = "diarjo";
            mTrans.ClientCredentials.Windows.ClientCredential.Password = "123456";

            return mTrans;
        }

        public int exec(string strSql)
        {
            int result;
            TRANService.CRUDServiceClient myCred;

            if (mTrans == null)
            { myCred = GetCRUDService(); }
            else
            { myCred = mTrans; }

            result = myCred.Exec(strSql);
            return result;
        }
    }
}
