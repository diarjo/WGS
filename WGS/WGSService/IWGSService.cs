using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace WGSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode=SessionMode.Required)]
    public interface IWGSService
    {
         
        [OperationContract(IsInitiating=true,IsTerminating=true)]
        string GetData(int value);

        [OperationContract(IsInitiating=true,IsTerminating=false)]
        DataSet GetDataSet(string cmdstring);

        [OperationContract(IsInitiating=true, IsTerminating=true)]
        DataTable GetDataTable(string cmdstring);

        [OperationContract(IsInitiating=false, IsTerminating=true)]
        string SQLExeNoPara(string cmdstring);


    }


}
