using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MixwellApiCoreWeb.Moduls;

namespace MixwellApiCoreWeb.Services
{
    public interface ITestServices
    {   // define service method interface 
        TestItems AddTestItems(TestItems itesm);
        Dictionary<string, TestItems> GetTestItems();
    }
}
