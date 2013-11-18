using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Thinktecture.IdentityModel.Tokens;
using WifExamples.Common;

namespace WifExamples.MVC5.HttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokenClient = new TokenClient("tokenService");
            XmlElement tokenXml = tokenClient.GetToken("urn:claimsdemo:mvc5http");
            string encodedToken = HeaderEncoding.EncodeBase64(tokenXml.OuterXml);

            string serviceEndpoint = ConfigurationManager.AppSettings["ServiceEndpoint"];

            var client = new System.Net.Http.HttpClient { BaseAddress = new Uri(serviceEndpoint) };
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("SAML", encodedToken);


            HttpResponseMessage response = client.GetAsync("/WhoAmI").Result;
            response.EnsureSuccessStatusCode();

            string content = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine(content);

            //string whoAmIresult = channel.WhoAmI();
            //Console.WriteLine(whoAmIresult);

            //string restrictedMethodResult = channel.RestrictedMethod();
            //Console.WriteLine(restrictedMethodResult);

            Console.ReadLine();
        }
    }
}
