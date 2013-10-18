using System.Web;
using System.Web.Mvc;

namespace WifExamples.MVC5.HttpServer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
