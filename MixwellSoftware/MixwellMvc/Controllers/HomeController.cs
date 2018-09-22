using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MixwellMvc.Controllers
{
    public class HomeController : Controller
    {
        //home HomeController is defualt start HOmeView
        // public ActionResult Index() will go to HomeView

        // run http://localhost:28327/

        /*   HomeController/GetMVCVersion  hometronroller is default

                  routes.MapRoute(
                        name: "Default",
                        url: "{controller}/{action}/{id}",
                        defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                    );
        */

            //*****************************************************
        //below is Controller without viewer

        public string GetInput(string input)
        {
            // http://localhost:28327/MixwellMvc/Home/GetInput/?input=Henry
            // Invork GetInput: Input = Henry

            return "Invork GetInput:" + " Input = " + Request.QueryString["input"]; ;

        }
        
        public string GetTwoInput(string id, string name)
        {
            //run http://localhost:28327/MixwellMvc/Home/index/?id=10&name=Henry
            //it is not work, need to know multiple input
            //ID: 10; Name = Henry
            return "ID: " + id + ", Name = " + name;
        }
        

        public string GetMVCVersion()
        {
            return "Invork GetMVCVesion: Hello from MVC " + typeof(Controller).Assembly.GetName().Version.ToString(); //display current MVC view at first page

        }
/*
        public string Index()
        {
            //run http://localhost:28327/MixwellMvc
            //ID: 10 Name = Henry
            return GetMVCVersion();
        }
*/

        //*****************************************************
        //below is Controller with viewer

        
                public ActionResult Index()
                {
                    //ActionResult for http://localhost:28327/Home/
                    //ActionResult for http://localhost:28327
                    return View();
                }

                public ActionResult About()
                {
                    //ActionResult for http://localhost:28327/Home/About

                    ViewBag.Message = "Your application description page.";

                    return View();
                }

                public ActionResult Contact()
                {
                    //ActionResult for http://localhost:28327/Home/Contact

                    ViewBag.Message = "Your contact page.";

                    return View();
                }
        
    }
}