using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WifExamples.Common;

namespace WifExamples.Net45.MVC.HttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ChannelFactory<IDemoService>("WS2007FederationHttpBinding_IDemoService");
            IDemoService channel = factory.CreateChannel();

            string whoAmIresult = channel.WhoAmI();
            Console.WriteLine(whoAmIresult);

            string restrictedMethodResult = channel.RestrictedMethod();
            Console.WriteLine(restrictedMethodResult);

            Console.ReadLine();
        }
    }
}
