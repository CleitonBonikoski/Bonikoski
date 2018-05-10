using System;

namespace Aula_10_05_POO {
    class Cliente {
        //Atributo
        private string nome;
        // public string cpf { set; get; }

        //Propriedade
        public string Nome {
            get {
                return nome;
                }

            set {
                nome = value;
                }

            }

        public string cpf { set; get; } // propriedade sem declarar o atributo.

        }
    }
