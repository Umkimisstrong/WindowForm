using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceApp01.Models.Service
{
    public interface ISKAPI_GRTService
    {
        [OperationContract]
        GRT_Model greeting(GRT_Model request);

    }
}
