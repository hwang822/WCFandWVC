using System.Linq;
using System.Web.Mvc;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using MixwellMvc.Models;

namespace MixwellMvc.Controllers
{
    //
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

            var wcfdata = WcfClient.WcfClientGet("http://localhost:23506/MixwellWCFService.svc/GET");

            using (var db = new MixwellDBEntities())
            {
                var model = db.MixwellDatas.ToList<MixwellData>();
                return View(model);
            }                        
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            using (var db = new MixwellDBEntities())
            {
                var model = db.MixwellDatas.ToList<MixwellData>().Single(d=>d.ID==id);
                return View(model);
            }

        }

        [HttpPut]
        public ActionResult Edit(int id)
        {

            using (var db = new MixwellDBEntities())
            {
                var model = db.MixwellDatas.ToList<MixwellData>().Single(d => d.ID == id);
                return View(model);
            }

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string name, string place)
        {
            var data = new MixwellData() { Name = name, Place = place };
            using (var db = new MixwellDBEntities())
            {
                db.MixwellDatas.Add(data);
                db.SaveChanges();
                return View();
            }            
        }


        [HttpPost]
        public ActionResult Edit(MixwellData model)
        {
            string serviceuri = string.Format("http://localhost:23506/MixwellWCFService.svc/data/update");
            string myParameters = "id=" + model.ID + "&name=" + model.Name + "&place=" + model.Place;
            using(WebClient ec = new WebClient())
            {
                ec.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                ec.UploadString(serviceuri, myParameters);
            }

            return RedirectToAction("Index");
        }


    }
}
