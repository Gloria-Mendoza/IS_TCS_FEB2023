using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMoneda
{
    public class ServicioMoneda : IServicioMoneda
    {
        public float ObtenerPesoADolar(float cantidad)
        {
            float resultado;
            Moneda moneda = new Moneda();
            moneda.valor = cantidad;
            resultado = moneda.valor * moneda.dolar;
            return resultado;
        }

        public float ObtenerDolarAPeso(float cantidad)
        {
            float resultado;
            Moneda moneda = new Moneda();
            moneda.valor = cantidad;
            resultado = moneda.valor * moneda.peso;
            return resultado;
        }
    }
}

