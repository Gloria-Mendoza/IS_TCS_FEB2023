using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosConvertidor
{
    [ServiceContract]
    internal interface IServicioClima
    {
        [OperationContract]
        float ObtenerGradoCelsiusAFarenheit(float grados);

        [OperationContract]
        float ObtenerGradoFarenheitACelsius(float grados);
    }
}
