using ExerciseTracker.Infrastructure;
using StructureMap;
using StructureMap.TypeRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ExerciseTracker
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public IContainer Container
        {
            get
            {
                return (IContainer)HttpContext.Current.Items["_Container"];
            }
            set
            {
                HttpContext.Current.Items["_Container"] = value;
            }
        }

        protected void Application_Start()
        {

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            DependencyResolver.SetResolver(
                new StructureMapDependencyResolver(() => Container ?? IoC.Container));

            IoC.Container.Configure(cfg =>
            {
                cfg.AddRegistry(new StandardRegistry());
                //cfg.AddRegistry(new ControllerRegistry());
                //cfg.AddRegistry(new ActionFilterRegistry(
                //    () => Container ?? IoC.Container));
                //cfg.AddRegistry(new MvcRegistry());
                //cfg.AddRegistry(new TaskRegistry());
                //cfg.AddRegistry(new ModelMetadataRegistry());
            });
        }
    }
}