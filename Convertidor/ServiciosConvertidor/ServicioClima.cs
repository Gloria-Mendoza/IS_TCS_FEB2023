using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosConvertidor
{
    internal class ServicioClima : IServicioClima
    {
        public float ObtenerGradoCelsiusAFarenheit(float grados)
        {
            float resultado;
            Clima clima = new Clima();
            clima.grado = grados;
            resultado = (clima.grado * 9 / 5) + 32;
            return resultado;
        }

        public float ObtenerGradoFarenheitACelsius(float grados)
        {
            float resultado;
            Clima clima = new Clima();
            clima.grado = grados;
            resultado = (clima.grado - 32) * 5 / 9;
            return resultado;
        }
    }
}
