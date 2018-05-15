using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Interfaces {
    class Carro : IMeioTransporte {

        public int Velocidade { get; set; }
        public int MarcaID { get; set; }
        public virtual Marca _Marca { get; set; }

        public List<Roda> Rodas { get; set; }

        public string Modelo {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        public Carro() {
            Velocidade = 0;
        }

        public void Acelerar() {
            Velocidade += 10;
        }
      

        public void Desacelerar() {
            Velocidade -= 5;
        }
    }
}
