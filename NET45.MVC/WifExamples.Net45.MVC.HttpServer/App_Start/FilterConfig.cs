using System.Web;
using System.Web.Mvc;

namespace WifExamples.Net45.MVC.HttpServer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}