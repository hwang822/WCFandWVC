using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MixwellMvc.Services;

namespace MixwellMvc.Controllers
{
    //1. Controller for user interaction
    //2. View for UI
    //3. Module data bussiness.

    //Handle user interaction logic

    public class DependencyInjectionController : Controller 
    {
        // Controller is key word

        // GET: /DependencyInjection/

        //default run http://localhost:5557/DependencyInjection
        //IDependencyInjectionService _idjService;
        //DependencyInjectionService _djService;
        /*
                public DependencyInjectionController()
                {
                    _djService = new DependencyInjectionService();

                }

                public DependencyInjectionController()
                {
                    _idjService = new DependencyInjectionService();

                }
        

        public DependencyInjectionController(IDependencyInjectionService idjservice)
        {
            _idjService = idjservice; 

        }
*/

        public string Index()
        {
            //return "Dependency Injection.";
            //return _djService.GetGreeting();
            //return _idjService.GetGreeting();
            return new DependencyInjectionService().GetGreeting() + " " + new DependencyInjectionService().GetIntance() + " " + new DependencyInjectionService().GetIntance(); ;

        }

        //run http://localhost:5557/DependencyInjection/MyFirstMethod
        public string MyFirstMethod()
        {
            return "My first Method";
        }

/*
        public ActionResult Index() //Wirte click the Method to creat DependencyInjectionView code at /Views/DependencyInjection/DependencyInjectionView.aspx
        {
            ViewData["MyData"] = "Henry Wang";
            return View("DependencyInjectionView"); //start this view  //locate and view /Views/ControlName/ControlViewPage.aspx
        }
*/
    }
}
