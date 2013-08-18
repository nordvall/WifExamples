using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WifExamples.Common;

namespace WifExamples.Net45.MVC.HttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokenClient = new TokenClient("tokenService");
            XmlElement tokenXml = tokenClient.GetToken("urn:claimsdemo:http45mvc");

            //string whoAmIresult = channel.WhoAmI();
            //Console.WriteLine(whoAmIresult);

            //string restrictedMethodResult = channel.RestrictedMethod();
            //Console.WriteLine(restrictedMethodResult);

            Console.ReadLine();
        }
    }
}
