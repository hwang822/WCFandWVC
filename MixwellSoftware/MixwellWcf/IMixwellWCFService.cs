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
        //http://localhost:23506/MixwellWCFService.svc/alldata => ["carrot","fox","explorer"]
        [WebGet(UriTemplate = "GET", ResponseFormat=WebMessageFormat.Json)] // for json format
        //List<MixwellData> GetAllData();
        List<string> GetData();

        [OperationContract]
        //[WebGet] //using GetData Method
        //[WebGet(UriTemplate = "Data/{id}")]  // default xml format for sample data transfer all int to string
        //http://localhost:23506/MixwellWCFService.svc/data/1 => "get data for id = 1"
        [WebGet(UriTemplate = "GET/{id}/", ResponseFormat = WebMessageFormat.Json)] // for json format        
        string GetOneData(string id);


        [OperationContract]
        [WebInvoke(UriTemplate = "POST/{data}", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        void PostData(string data);

        [OperationContract]
        [WebInvoke(UriTemplate = "PUT/{data}/{id}", Method = "PUT", ResponseFormat = WebMessageFormat.Json)]
        void PutData(string data, string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "DELETE/{id}", Method = "DELETE", ResponseFormat = WebMessageFormat.Json)]
        void DeleteData(string id);

        // TODO: Add your service operations here
    }
}
