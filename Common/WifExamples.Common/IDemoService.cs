using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WifExamples.Common
{
    [ServiceContract]
    public interface IDemoService
    {
        [OperationContract]
        string WhoAmI();

        [OperationContract]
        string RestrictedMethod();
    }
}
