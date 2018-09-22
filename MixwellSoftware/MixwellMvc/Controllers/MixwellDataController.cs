using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MixwellMvc.Models;

namespace MixwellMvc.Controllers
{
    public class MixwellDataController : Controller
    {
        // ASP.NET MVC tutorial for beginners
        // https://www.youtube.com/watch?v=-pzwRwYlXMw&list=PL6n9fhu94yhVm6S8I2xd6nYz2ZORd7X2v
        // install mvc 2,3,4
        // GET: /MixwellData/
        [HttpGet]

        public ActionResult Index()
        {
            // Control MxiwellData look at View and trnasfer data to View
            ViewBag.Name = "Mixwell Software";
            ViewData["Addr"] = "808 N. Franklin St, Tampa, FL 33602";

            //var wcfdata = WcfClient.WcfClientGet("http://localhost:23506/MixwellWCFService.svc/GET");

            List<MixwellData> model = new List<MixwellData>()
            {
                new MixwellData(){Name = "Henry", DOB = "8/22/60", ID = 0 },
                new MixwellData() {Name = "Diasy", DOB = "3/31/62", ID = 1  }
            };
            return View(model);
            /*            
                        using (var db = new MixwellDBEntities())
                        {
                            var model = db.MixwellDatas.ToList<MixwellData>();
                            return View(model);
                        }
            */
            //return View();
        }
    }
}