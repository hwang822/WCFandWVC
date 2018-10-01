using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MixwellApiCoreWeb.Moduls;
using MixwellApiCoreWeb.Services;

//https://www.youtube.com/watch?v=J_MEscBWJYI
// ASP.NET core 2.1: Building a simple web api.

namespace MixwellApiCoreWeb.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    //ApiCountroller is interface to process client request corss internet at Route format 

    // For test download and run postman

    public class TestController : ControllerBase
    {
        private readonly ITestServices _services;

        public TestController(ITestServices services)  //at controler constraction binding services for call what methods need to do.
        {
            _services = services;
        }

        [HttpPost] //API core default HttpPost
        [Route("AddTesetItmes")]
        public ActionResult<TestItems> AddTesetItmes(TestItems items)
        {   // this service requst AddTestItems to data list
            var TestItems = _services.AddTestItems(items);
            if(TestItems == null)
            {
                return NotFound();
            }
            return TestItems;
        }

        [HttpGet]
        [Route("GetTestItems")]
        public ActionResult<Dictionary<string, TestItems>> GetTestItems()
        {
            // this service requst get all added at data list
            var testItems = _services.GetTestItems();
            if (testItems.Count == 0)
                return NotFound();
            return testItems;
        }
    }
}