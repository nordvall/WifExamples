﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.IdentityModel.Claims;

namespace WifExamples.Net40.HttpsServer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IClaimsPrincipal principal = Thread.CurrentPrincipal as IClaimsPrincipal;
            IClaimsIdentity claimsIdentity = principal.Identities.FirstOrDefault();

            if (claimsIdentity != null)
            {
                ClaimsGridView.DataSource = claimsIdentity.Claims;
                ClaimsGridView.DataBind();
            } 
        }
    }
}