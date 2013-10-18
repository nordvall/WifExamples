using System;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.IdentityModel.Tokens;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Thinktecture.IdentityModel.Constants;
using Thinktecture.IdentityModel.WSTrust;

namespace WifExamples.MVC5.HttpClient
{
    class TokenClient
    {
        private WSTrustChannelFactory _factory;

        public TokenClient(string configName)
        {
            if (string.IsNullOrEmpty(configName))
            {
                throw new ArgumentNullException("configName");
            }

            _factory = new WSTrustChannelFactory(configName)
            {
                TrustVersion = TrustVersion.WSTrust13
            };
            
        }

        public XmlElement GetToken(string realm)
        {
            if (string.IsNullOrEmpty(realm))
            {
                throw new ArgumentNullException("realm");
            }
              
            var request = new RequestSecurityToken
            {
                RequestType = RequestTypes.Issue,
                KeyType = KeyTypes.Symmetric,
                TokenType = TokenTypes.Saml11TokenProfile11,
                AppliesTo = new EndpointReference(realm)
            };

            IWSTrustChannelContract channel = _factory.CreateChannel();
            var token = channel.Issue(request) as GenericXmlSecurityToken;

            return token.TokenXml;
        }
    }
}
