using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Permissions;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;
using WifExamples.Common;

namespace WifExamples.Net45.HttpServer
{
    public class DemoService : IDemoService
    {
        public string WhoAmI()
        {
            ClaimsPrincipal claimsPrincipal = OperationContext.Current.ClaimsPrincipal;
            return "According to the token service, you are: " + claimsPrincipal.Identity.Name;
        }


        [PrincipalPermission(SecurityAction.Demand, Role = "Manager")]
        public string RestrictedMethod()
        {
            return "You have the necessary role to access this method.";
        }
    }
}
