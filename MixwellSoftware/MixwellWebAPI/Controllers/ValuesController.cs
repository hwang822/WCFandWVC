using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MixwellWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> strings = new List<string>()
        {
             "value0", "value1", "value2"
        };

        // GET values run http://localhost:13194/api/values
        /*
        <?xml version="1.0" encoding="ISO-8859-1"?>
        <ArrayOfstring xmlns="http://schemas.microsoft.com/2003/10/Serialization/Arrays" xmlns:i="http://www.w3.org/2001/XMLSchema-instance">
        <string>value0</string>
        <string>value1</string>
        <string>value2</string>
        </ArrayOfstring> 
        */

        public IEnumerable<string> Get()
        {
            return strings;
        }

        // GET one value run http://localhost:13194/api/values/1
        //<?xml version="1.0" encoding="ISO-8859-1"?>
        //<string xmlns = "http://schemas.microsoft.com/2003/10/Serialization/" > value1 </ string >
        //
        public string Get(int id)
        {
            return strings[id];
        }

        //https://www.youtube.com/watch?v=GbKBcDX8DDQ&list=PL6n9fhu94yhW7yoUOGNOfHurUE6bpOO2b&index=3

        // POST api/values
        // install and run Telerik 
        public void Post([FromBody]string value)
        {
            strings.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            strings[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }
    }
}