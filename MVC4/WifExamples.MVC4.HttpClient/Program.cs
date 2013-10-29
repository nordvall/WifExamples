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
using Thinktecture.IdentityModel.Http;
using WifExamples.Common;

namespace WifExamples.MVC4.HttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokenClient = new TokenClient("tokenService");
            XmlElement tokenXml = tokenClient.GetToken("urn:claimsdemo:http45mvc");
            string encodedToken = HeaderEncoding.EncodeBase64(tokenXml.OuterXml);

            string serviceEndpoint = ConfigurationManager.AppSettings["ServiceEndpoint"];

            var client = new System.Net.Http.HttpClient { BaseAddress = new Uri(serviceEndpoint) };
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("SAML", tokenXml.OuterXml);
            client.SetToken("SAML", encodedToken);
            

            HttpResponseMessage response = client.GetAsync("api/DemoService/WhoAmI").Result;
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
