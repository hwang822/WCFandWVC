using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MixwellApiCoreWeb.Moduls;
using MixwellApiCoreWeb.Services;

namespace MixwellApiCoreWeb.Services
{

    public class TestServices : ITestServices
    {
        // servnce methods implementations
        private readonly Dictionary<string, TestItems> _testItems;
        // creeat data list
        //throw new System.NotImplementedException();

        public TestServices() 
        {   
            //services constractor to create data items list
            _testItems = new Dictionary<string, TestItems>();

            //throw new System.NotImplementedException();
        }

        public TestItems AddTestItems(TestItems items)
        {
            // Method to add a items to list.
            _testItems.Add(items.ItemName, items);
            //throw new System.NotImplementedException();
            return items;
        }

        public Dictionary<string, TestItems> GetTestItems()
        {
            // return all added items from list.
            return _testItems;
        }

    }
}
