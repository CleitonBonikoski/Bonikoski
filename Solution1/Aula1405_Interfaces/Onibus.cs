using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces {
    class Onibus : IMeioTransporte {
        public int Velocidade { get; set; }

        public void Acelerar() {
            Velocidade += 8;
            }

        public void Desacelerar() {
            Velocidade -= 4;
            }
        }
    }
