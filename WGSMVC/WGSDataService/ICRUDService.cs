using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace WGSDataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode=SessionMode.Required)]
    public interface ICRUDService
    {

        [OperationContract(IsInitiating=true, IsTerminating=false)]
        string GetData(int value);

        [OperationContract(IsInitiating = true, IsTerminating = true)]
        DataSet GetDataSet(string strSQL);

        [OperationContract(IsInitiating = true, IsTerminating = true)]
        DataTable GetDataTable(string strSQL, string tblName);

        [OperationContract(IsInitiating = true, IsTerminating = true)]
        int Exec(string strSQL);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
