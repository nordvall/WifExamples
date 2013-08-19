using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Thinktecture.IdentityModel.Tokens.Http;

namespace WifExamples.Net45.MVC.HttpServer
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        // claims transformation
        protected void Application_PostAuthenticateRequest()
        {
            if (ClaimsPrincipal.Current.Identity.IsAuthenticated)
            {
                var principal = new ClaimsAuthenticationManager().Authenticate(string.Empty, ClaimsPrincipal.Current);

                HttpContext.Current.User = principal;
                Thread.CurrentPrincipal = principal;
            }
        }

        
    }
}