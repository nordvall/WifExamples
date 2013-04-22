using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WifExamples.Common;

namespace WifExamples.Net35.HttpsServer
{
    public class DemoService : IDemoService
    {
        public string Hello()
        {
            return "world";
        }
    }
}
