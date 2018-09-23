https://www.youtube.com/watch?v=AMO6aIXRp1U&t=1278s

Creating WCF REST Service Setp by Step

Add New Project

Visual C#/WCF/WCF Service Application/MixwellWcf

It added two Classes: 
IMixwellDataService.cs
MixwellDataService.cs

Or you can add new item at Visual C#/Web/WCF Service
Click Add button.

MixwellDataService and IMixwellDataService

IMixwellDataService is interface of service and operation contracot defination

    [ServiceContract]
    public interface IMixwellDataService
    {
        [OperationContract]
        [WebGet(UriTemplate = "GET", ResponseFormat=WebMessageFormat.Json)] // for json format
        List<string> GetData();
    }
	this defin request format
	http://localhost:23506/MixwellWCFService.svc/GET

MixwellDataService.cs is implatation of interace.
Righ click IMixwellDataService select Show Partential fixes it cratet code body.

Build and run from IMixwellWCFService to bring up browser for service list. Click MixwellWCFService.svc to go
http://localhost:23506/MixwellWCFService.svc
trpe in http://localhost:23506/MixwellWCFService.svc/GET 
to get return ["carrot","fox","explorer"]

To Test to type at browser
http://localhost:23506/MixwellWCFService.svc/GET/1
to get reutn "fox"


