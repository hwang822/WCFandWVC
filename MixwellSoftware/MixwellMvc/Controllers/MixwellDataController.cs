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
    public class MixwellDataController : Controller
    {
        //
        // GET: /MixwellData/

        public ActionResult Index()
        {

            WebClient proxy = new WebClient();
            string serviceuri = string.Format("http://localhost:23506/MixwellWCFService.svc/alldata");
            byte[] _data = proxy.DownloadData(serviceuri);
            Stream _mem = new MemoryStream(_data);

            var reader = new StreamReader(_mem);
            var result = reader.ReadToEnd();
            var model = JsonConvert.DeserializeObject<List<MixwellData>>(result);
            return View(model);
        }

        public ActionResult Details(int id)
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
            string myParameters = "id=" + model.id + "&name=" + model.name + "&place=" + model.place;
            using(WebClient ec = new WebClient())
            {
                ec.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                ec.UploadString(serviceuri, myParameters);
            }

            return RedirectToAction("Index");
        }


    }
}
