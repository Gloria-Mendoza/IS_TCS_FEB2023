using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServicioMoneda
{
    [DataContract]
    internal class Moneda
    {
        [DataMember]
        public float valor { get; set; }
        [DataMember]
        public float peso { get { return 17.99F; } }
        [DataMember]
        public float dolar { get { return 1 / peso; } }
    }
}