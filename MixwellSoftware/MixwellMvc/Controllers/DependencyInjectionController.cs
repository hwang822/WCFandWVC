using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MixwellMvc.Controllers
{

    //The service you want to use.
    //The client that uses the service.
    //An interface that’s used by the client and implemented by the service.
    //The injector which creates a service instance and injects it into the client.

        //the service has two differnce services function GetGreeting() and GetInstance() with two interface
    public interface IDependencyInjectionService
    {  
        string GetGreeting();
        string GetIntance();
    }

    public class DependencyInjectionService : IDependencyInjectionService
    {  
        public string GetGreeting()
        {
            return "Hi, DJ ";
        }

        public string GetIntance()
        {
            return "Instance " + GetHashCode();
        }

    }

    public class DependencyInjectionController : Controller
    {

        // Controller is key word

        // GET: /DependencyInjection/

        //default run http://localhost:5557/DependencyInjection


        public string Index()
        {
            //this request need two GetIntqace() services and one GetGreeting() service
            //The three service instances are created and push interfaces to client to call.
            //http://localhost:28327/DependencyInjection
            //Hi, DJ Instance 51438283 Instance 15315213
            //it get on greating, two differnece instance ids 

            return new DependencyInjectionService().GetGreeting() + " " 
                 + new DependencyInjectionService().GetIntance() + " " 
                 + new DependencyInjectionService().GetIntance();

        }

        public string RequestGreeting()
        {
            //this request need GetGreeting() service
            //The service instances are created and push interfaces to client to call.
            //http://localhost:28327/DependencyInjection/RequestGreeting
            //Hi, DJ 

            return new DependencyInjectionService().GetGreeting();
        }

        public string RequestInstanceInformation()
        {
            //this request need GetInstanceInfmation() service
            //The service instances are created and push interfaces to client to call.
            //http://localhost:28327/DependencyInjection/RequestInstanceInformation
            //Instance 50757320
            return new DependencyInjectionService().GetIntance();
        }


        // GET: DependencyInjection
        /*
                public ActionResult Index() //Wirte click the Method to creat DependencyInjectionView code at /Views/DependencyInjection/DependencyInjectionView.aspx
                {
                    ViewData["MyData"] = "Henry Wang";
                    return View("DependencyInjectionView"); //start this view  //locate and view /Views/ControlName/ControlViewPage.aspx
                }
        */
    }
}