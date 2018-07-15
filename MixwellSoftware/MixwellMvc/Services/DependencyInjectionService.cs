using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixwellMvc.Services
{
    public interface IDependencyInjectionService
    {
        string GetGreeting();
        string GetIntance();
    }

    public class DependencyInjectionService : IDependencyInjectionService
    {
        public string GetGreeting()
        {
            return "Hi, DJ ";
        }

        public string GetIntance()
        {
            return "Instance " + GetHashCode();
        }

    }

}