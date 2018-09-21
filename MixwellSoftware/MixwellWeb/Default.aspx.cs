using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MixwellSoftware
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            //GetData(texid.Text);
        }

        private void GetData(string p)
        {
            WebClient proxy = new WebClient();
            string serviceuri = string.Format("http://localhost:23506/MixwellWCFService.svc/data/{0}", p);
            byte[] _data = proxy.DownloadData(serviceuri);
            Stream _mem = new MemoryStream(_data);

            var reader = new StreamReader(_mem);
            var result = reader.ReadToEnd();
        }
    }
}