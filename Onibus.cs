using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Interfaces{
    class Onibus:IMeioTransporte {
        

        public int Velocidade { get; set; }
        public int Aceleracao { get; set; }
        public int Defesa { get; set; }
        public int Attack { get; set; }
        public int MarcaID { get; set; }
        public virtual Marca _Marca{ get; set; }

        public string Modelo {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        public Onibus() {
            Velocidade = 0;
            Aceleracao = 0;
            Attack = 0;
            Defesa = 0;
        }

        public void Acelerar() {
            Velocidade +=20;
            Aceleracao +=2;
            Attack +=2;
            Defesa -=1;
        }

        public void Desacelerar() {
            Velocidade -=10;
            Aceleracao -=1;
            Attack -=1;
            Defesa +=3;
        }

        public void Info() {
            Console.WriteLine("Velocidade: " + Velocidade);
            Console.WriteLine("Aceleração: " + Aceleracao);
            Console.WriteLine("Attack: " + Attack);
            Console.WriteLine("Defesa: " + Defesa);
        }
    }
}
