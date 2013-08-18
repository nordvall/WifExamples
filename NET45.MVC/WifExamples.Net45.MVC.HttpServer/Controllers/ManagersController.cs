using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WifExamples.Net45.MVC.HttpServer.Controllers
{
    public class ManagersController : Controller
    {
        //
        // GET: /Managers/

        [Authorize(Roles="Manager")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
