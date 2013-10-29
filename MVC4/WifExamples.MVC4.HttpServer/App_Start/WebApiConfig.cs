using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using Thinktecture.IdentityModel.Tokens.Http;

namespace WifExamples.MVC4.HttpServer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // authentication configuration for identity controller
            var authentication = CreateAuthenticationConfiguration();
            config.MessageHandlers.Add(new AuthenticationHandler(authentication));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}"
            );
        }

        private static AuthenticationConfiguration CreateAuthenticationConfiguration()
        {
            var options = new AuthenticationOptions()
            {
                RequestType = HttpRequestType.AuthorizationHeader,
                Scheme = "SAML"
            };

            var registry = new ConfigurationBasedIssuerNameRegistry();
            registry.AddTrustedIssuer("18145fb6b5d96b3cc34ec7599f12172bb93c68ef", "DummySTS");

            var adfsConfig = new SecurityTokenHandlerConfiguration();
            adfsConfig.AudienceRestriction.AllowedAudienceUris.Add(new Uri("urn:claimsdemo:http45mvc"));
            adfsConfig.IssuerNameRegistry = registry;
            adfsConfig.CertificateValidator = X509CertificateValidator.None;

            X509Store store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);
            X509Certificate2Collection certificates = store.Certificates;
            X509Certificate2Collection matchingCertificates = certificates.Find(
                X509FindType.FindByThumbprint,
                "a2028f8e7f7b082cd35e81fd0ca0b70b04651abf", false);
            X509Certificate2 certificate = certificates[0];

            List<SecurityToken> serviceTokens = new List<SecurityToken>();
            serviceTokens.Add(new X509SecurityToken(certificate));
            SecurityTokenResolver serviceResolver =
                SecurityTokenResolver.CreateDefaultSecurityTokenResolver(
                    serviceTokens.AsReadOnly(), false);
            adfsConfig.ServiceTokenResolver = serviceResolver;

            var config = new AuthenticationConfiguration
            {
                RequireSsl = false
            };
            
            config.AddSaml11(adfsConfig, options);
            
            return config;
        }
    }
}
