using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using WifExamples.Common;

namespace WifExamples.MVC5.HttpServer.Controllers
{
    public class DemoServiceController : ApiController, IDemoService
    {
        [HttpGet]
        public string WhoAmI()
        {
            ClaimsPrincipal claimsPrincipal = User as ClaimsPrincipal;
            return "According to the token service, you are: " + claimsPrincipal.Identity.Name;
        }


        [HttpGet, Authorize(Roles="Manager")]
        public string RestrictedMethod()
        {
            return "You have the necessary role to access this method.";
        }
    }
}
