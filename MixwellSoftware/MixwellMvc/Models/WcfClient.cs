using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using MixwellMvc.Models;

namespace MixwellMvc.Models
{
    public static class WcfClient
    {
        public static object WcfClientGet(string url)
        {
            
            WebClient proxy = new WebClient();
            string serviceuri = string.Format(url);
            byte[] _data = proxy.DownloadData(serviceuri);
            Stream _mem = new MemoryStream(_data);

            var reader = new StreamReader(_mem);
            var result = reader.ReadToEnd();
            var model = JsonConvert.DeserializeObject<List<string>>(result);
            return model;
        }
        /*
            WebClient proxy = new WebClient();
            string serviceuri = string.Format("http://localhost:23506/MixwellWCFService.svc/GET");
            byte[] _data = proxy.DownloadData(serviceuri);
            Stream _mem = new MemoryStream(_data);

            var reader = new StreamReader(_mem);
            var result = reader.ReadToEnd();
            var model = JsonConvert.DeserializeObject<List<string>>(result);
        */

    }
}