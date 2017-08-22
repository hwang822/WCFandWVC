using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MixwellWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMixwellWCFService" in both code and config file together.
    [ServiceContract]
    public interface IMixwellWCFService
    {
        
        [OperationContract]
        //[WebGet] //using AllData Method
        //[WebGet(UriTemplate = "AllData")]   // default xml format
        [WebGet(UriTemplate = "AllData", ResponseFormat=WebMessageFormat.Json)] // for json format
        List<MixwellData> GetAllData();

        [OperationContract]
        //[WebGet] //using GetData Method
        //[WebGet(UriTemplate = "Data/{id}")]  // default xml format
        [WebGet(UriTemplate = "Data/{id}", ResponseFormat = WebMessageFormat.Json)] // for json format        
        MixwellData GetData(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Data/Add", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        int AddData(MixwellData data);

        [OperationContract]
        [WebInvoke(UriTemplate = "Data/Update", Method = "PUT", ResponseFormat = WebMessageFormat.Json)]
        bool UpdateData(MixwellData data);


        //******************************************** 
        // service test method.
/*


        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
*/
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
