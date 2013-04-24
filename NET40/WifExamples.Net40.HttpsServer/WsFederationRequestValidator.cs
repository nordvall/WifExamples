using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Util;
using Microsoft.IdentityModel.Protocols.WSFederation;

namespace WifExamples.Net40.HttpsServer
{
    public class WsFederationRequstValidator : RequestValidator
    {
        protected override bool IsValidRequestString(HttpContext context,
                                string value,
                                RequestValidationSource requestValidationSource,
                                string collectionKey,
                                out int validationFailureIndex)
        {
            validationFailureIndex = 0;
            if (requestValidationSource == RequestValidationSource.Form &&
              collectionKey.Equals(WSFederationConstants.Parameters.Result, StringComparison.Ordinal))
            {
                if (WSFederationMessage.CreateFromFormPost(context.Request) as SignInResponseMessage != null)
                {
                    return true;
                }
            }

            return base.IsValidRequestString(context,
                              value,
                              requestValidationSource,
                              collectionKey,
                              out validationFailureIndex);
        }
    }
}