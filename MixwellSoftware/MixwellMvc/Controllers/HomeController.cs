using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MixwellMvc.Controllers
{
    //home HomeController is defualt start HOmeView
    // public ActionResult Index() will go to HomeView

    public class HomeController : Controller
    {
        // run http://localhost:5557/

        /*   HomeController/GetMVCVersion  hometronroller is default

                  routes.MapRoute(
                        name: "Default",
                        url: "{controller}/{action}/{id}",
                        defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                    );
        */

        public string GetInput(string input)
        {
            // http://localhost:5557/MixwellMvc/Home/GetInput/?input=Henry
            // Invork GetInput: Input = Henry

            return "Invork GetInput:" + " Input = " + Request.QueryString["input"]; ;

        }


        public string GetMVCVersion()
        {
            return "Invork GetMVCVesion: Hello from MVC " + typeof(Controller).Assembly.GetName().Version.ToString(); //display current MVC view at first page

        }
/*
        public string Index(string id, string name)
        {
            //run http://localhost:5557/MixwellMvc/Home/index/10?name=Henry
            //ID: 10 Name = Henry
            return "ID: " + id + " Name = " + name;
        }
*/
        
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
