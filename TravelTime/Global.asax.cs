using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using TravelTime.Models;
using TravelTime.Repositories;

namespace TravelTime
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            // Register your types, for instance using the scoped lifestyle:
            container.Register<IRepository<CUSTOMER>, Repository<CUSTOMER>>(Lifestyle.Scoped);
            container.Register<IRepository<DEPARTURE>, Repository<DEPARTURE>>(Lifestyle.Scoped);
            container.Register<IRepository<DESTINATION>, Repository<DESTINATION>>(Lifestyle.Scoped);
            container.Register<IRepository<DRIVER>, Repository<DRIVER>>(Lifestyle.Scoped);
            container.Register<IRepository<GUIDER>, Repository<GUIDER>>(Lifestyle.Scoped);
            container.Register<IRepository<PROGRAM>, Repository<PROGRAM>>(Lifestyle.Scoped);
            container.Register<IRepository<SERVICEPROVIDER>, Repository<SERVICEPROVIDER>>(Lifestyle.Scoped);
            container.Register<IRepository<TICKET>, Repository<TICKET>>(Lifestyle.Scoped);
            container.Register<IRepository<TOUR>, Repository<TOUR>>(Lifestyle.Scoped);
            container.Register<IRepository<TOURORDER>, Repository<TOURORDER>>(Lifestyle.Scoped);
            container.Register<IRepository<TRANSPORT>, Repository<TRANSPORT>>(Lifestyle.Scoped);

            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            // Here your usual Web API configuration stuff.

        }
    }
}
