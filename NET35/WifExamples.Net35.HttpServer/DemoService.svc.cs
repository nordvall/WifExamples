using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WifExamples.Common;

namespace WifExamples.Net35.HttpServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DemoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DemoService.svc or DemoService.svc.cs at the Solution Explorer and start debugging.
    public class DemoService : IDemoService
    {
        public string Hello()
        {
            return "world";
        }
    }
}
