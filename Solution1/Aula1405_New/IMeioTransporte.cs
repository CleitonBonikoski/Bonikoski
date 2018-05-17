using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Interfaces {
    interface IMeioTransporte {

        public string Modelo { get; set; }
        int Velocidade { get; set; }
        void Acelerar();
        void Desacelerar();
    }
}
