Restful Service with C# WebApi

https://www.youtube.com/watch?v=H9vBxAH4f5E

Creat new c# project for mvc/webapi restful service

Add (default already has one) new Controller ValuesController.cs as ApiController with empty read/wirte action template   
build and run project at IDE
test values api at browser runing localhost:13194
It is not default IIS energing

Respose:	"value1"

http://localhost:13194/api/values  
Will call ValuesController.Get() function to return vlaluses

        static List<string> strings = new List<string>()
        {
             "value0", "value1", "value2"
        };

        public IEnumerable<string> Get()
        {
            return strings;
        }

Response: ["value0","value1","value2"] 

http://localhost:13194/api/values/1
        public string Get(int id)
        {
            return strings[id];
        }
		
Respose:	"value1"

At WebApiConfig.cs

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

def url path api/controller name. remoe api could directly run 

http://localhost:13194/values
restful websderver response: ["value0","value1","value2"]

Also WebApiConfig.cs
def reponse format.
config.Formatters.Remove(config.Formatters.XmlFormatter);  //json format only

http://localhost:13194/values
restful websderver response: ["value0","value1","value2"]

config.Formatters.Remove(config.Formatters.JsonFormatter); //xml format only

http://localhost:13194/values

restful websderver response: 
<?xml version="1.0" encoding="ISO-8859-1"?>
<ArrayOfstring xmlns="http://schemas.microsoft.com/2003/10/Serialization/Arrays" xmlns:i="http://www.w3.org/2001/XMLSchema-instance">
<string>value0</string>
<string>value1</string>
<string>value2</string>
</ArrayOfstring>

The browser only could run GET and GET(id) request. 
using Telerik Fiddler to run Put, Post, Delete functions.

launch Fiddler and lookup localhost:13194
double click localhost:13194
Select Composer. 

Select GET copy URL http://localhost:13194/values
put break point at 

        public IEnumerable<string> Get()
        {
            return strings;
        }

Click Execute button at Fiddler.

It would stop at break point.

The start page could set at project/properties/web/specific page/Employees.html

Default start page Views/Home/index.cshtml