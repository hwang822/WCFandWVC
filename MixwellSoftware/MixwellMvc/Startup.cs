
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MixwellMvc
{
    public class Startup
    {
    }
}

/*
using System.Web.Mvc;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication1.Startup))]
namespace MixwellMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
        }

        public void ConfigureServices(IServiceCollection services)
        {
           services.AddOptions();
           services.AddConfiguration();
           var resolver = new DefaultDependencyResolver(services.BuildServiceProvider());
           DependencyResolver.SetResolver(resolver);
        }
    }
}
*/