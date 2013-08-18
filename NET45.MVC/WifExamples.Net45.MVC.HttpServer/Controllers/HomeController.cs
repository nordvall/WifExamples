using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace WifExamples.Net45.MVC.HttpServer.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Index()
        {
            ClaimsPrincipal claimsPrincipal = User as ClaimsPrincipal;
            return View(claimsPrincipal.Claims);
        }

    }
}
