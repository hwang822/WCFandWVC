# WCFandWVC

full stack from WPF desktop client to REST APIs – for our proprietary application located within the Azure Cloud. 
**************************
Web Services (REST, WCF, etc.).
representational state transfer application.
HTTP:
CLIENT  ==>  WEB SERVER
link of URL response resource to Brower. Sever does not work with database. just copy of resource.
http://www.eventellect.com/services.html
|     |                   |  
PROTOCOL
      HOST
                          RESOURCE
CLIENT  <==  WEB SERVER
representation of resource
HTML IMAGE XML JSON
such as services.html services.img services.xml services.json ...
http://www.eventellect.com is response state
click different link the state of applications are changed.
REST:
REQUEST verb + URL
action to the web server
GET: click the page to run "GET http://www.eventellect.com"
POST: submit some information to web server, for example log in with user name and password to post UN and PW to the server.
      or send subscription request to the web server.  
PUT 
DELETE 
REST API: (look at many REST APIs go https://apigee.com)
REQUEST:  REST API endpoint URL + API method + parameters
request example
https://api.flickr.com/services/rest/?method=flickr.photos.getinfo&photo_id=2079357948
|                                   |                            |                    |
REST API ENDPOINT URL                METHOD                       PARAMETERS
just as junction location with function(parm).
REST Request Format
REST is the simplest request format to use - it's a simple HTTP GET or POST action.
The REST Endpoint URL is https://api.flickr.com/services/rest/
To request the flickr.test.echo service, invoke like this:
https://api.flickr.com/services/rest/?method=flickr.test.echo&name=value

RESPONSE: the function return with format RESPONSE REST XML-PRC SOAP JSON Serialized PHP ... (NO HTML).
look at
https://www.flickr.com/services/api/

RESPONSE
HTML IMAGE XML JSON
POST twitter just go to twitter REST API and post some to your account.

**************************
back-end and middle tier services utilizing C#
move SQL server to Azure
start Microsoft azure developer studio /SQL Database
select add. put database name: any name
Subscription: Windows Azure Microsoft Network
Resource Group: Create new.
Select source: select Sample, ecom database.
Pricing tier: 4.99$/m form 100mb to 2gb for database server cost.
Server Name: in internet with ms azure account.
Server admin login: and password.
refresh the created database will be on the list.
click the data server. click the server name to get connection string to use at Microsoft SQL Server Management Studio connection.
 
Open MS SQL Management IDE. 
Put connection string database01.database.windows.net to the server name.
using the username and password at login of Connect ot Server dialog.
 
Click connect.
it will ask to sign in Azure database account.
run Microsoft SQL server management locally but connected to Microsoft Azure SQL server.
1. create database and put tables.
   select rows from table.
2. get database connection string from Microsoft Azure Server with format ADO.NET, JOBC, ODBC or PHP. copy the string and past to code.
3. start Microsoft visual studio to code module C#.
   Create project with C#/MVC sampleRESTServer.
   at DBConnection.config. past connection string to <add name="localDB" connectionString="server-12..."
   at c# code file 
using System.Data.SqlClient.
namespace SimpleRESTServer
{
 public class PersonPersistence
 {
  System.Data.SqlClient.SqlConnection sqlconn = new System.Data.SqlClient.SqlConnection(connstring);
  System.Data.SqlClient.SqlDataReader sqlReader = new System.Data.SqlClient.SqlDataReader();
  System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(comstring, sqlconn);
                cmd.ExecutNonQuery();
  }
}
 
create app server Azure
publish the build to Azure as server app.
click build and select publish. input the azure account information to deploy code build to the server app at Azure.
put database connection string to app db connection as in the visual studio local.
select created app at Azure server windows to run GET/POST/PUT/DELETE.

**************************
Windows Presentation Foundation (WPF), MVVM Pattern, or ASP.Net MVC
**************************
relational databases such as Microsoft SQL Server, Oracle, or MySQL

 