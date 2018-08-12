using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        public ActionResult Details(int id)
        {
            using (var db = new MixwellDBEntities())
            {
                var model = db.MixwellDatas.ToList<MixwellData>().Single(d=>d.ID==id);
                return View(model);
            }

        }

        public ActionResult Edit(int id)
        {

            WebClient proxy = new WebClient();
            string serviceuri = string.Format("http://localhost:23506/MixwellWCFService.svc/data/{0}", id);
            byte[] _data = proxy.DownloadData(serviceuri);
            Stream _mem = new MemoryStream(_data);

            var reader = new StreamReader(_mem);
            var result = reader.ReadToEnd();
            var model = JsonConvert.DeserializeObject<MixwellData>(result);
            return View(model);
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
