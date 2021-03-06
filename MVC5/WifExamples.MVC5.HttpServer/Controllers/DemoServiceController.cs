﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using WifExamples.Common;

namespace WifExamples.MVC5.HttpServer.Controllers
{
    [Authorize]
    public class DemoServiceController : ApiController, IDemoService
    {
        [HttpGet, Route("WhoAmI")]
        public string WhoAmI()
        {
            ClaimsPrincipal claimsPrincipal = User as ClaimsPrincipal;
            return "According to the token service, you are: " + claimsPrincipal.Identity.Name;
        }


        [Authorize(Roles = "Manager")]
        [HttpGet, Route("RestrictedMethod")]
        public string RestrictedMethod()
        {
            return "You have the necessary role to access this method.";
        }
    }
}
