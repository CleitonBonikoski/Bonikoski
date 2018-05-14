using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces {
    class Onibus : IMeioTransporte {
        public int Velocidade { get; set; }

        //chave para objeto Marca
        public int MarcaID { get; set; }

        //Propriedade de navegação
        public virtual Marca_Marca { get; set; }

        public void Acelerar() {
            Velocidade += 8;
            }

        public void Desacelerar() {
            Velocidade -= 4;
            }

        public string ImprimirInfo() {
            return "Onibus, Velocidade: " + Velocidade;
            }
        }
    }
