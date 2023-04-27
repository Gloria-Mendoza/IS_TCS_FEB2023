using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosConvertidor
{
    [ServiceContract]
    public interface IServicioMoneda
    {
        [OperationContract]
        float ObtenerPesoADolar(float cantidad);

        [OperationContract]
        float ObtenerDolarAPeso(float cantidad);

    }
}