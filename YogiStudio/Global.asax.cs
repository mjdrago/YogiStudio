using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace YogiStudio
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Stripe.StripeConfiguration.SetApiKey(System.Configuration.ConfigurationManager.AppSettings["pk_test_ZAnbP0INntVBj9Q84CNzSpRQ"]);
        }
    }
}
