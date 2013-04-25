using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WifExamples.Net45.HttpsServer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClaimsPrincipal claimsPrincipal = HttpContext.Current.User as ClaimsPrincipal;

            if (claimsPrincipal != null)
            {
                ClaimsGridView.DataSource = claimsPrincipal.Claims;
                ClaimsGridView.DataBind();
            } 
        }
    }
}