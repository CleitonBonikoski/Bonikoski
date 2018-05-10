using System;

namespace Aula_10_05_POO {
    class Pessoa {
       
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

        public string Cpf { set; get; } // propriedade sem declarar o atributo.
                                        
        //construtor
        public Pessoa() { // construtor vazio
            }

        public Pessoa(string nome) {
            Nome = nome;
            }
        public Pessoa(String nome, String cpf) {
            Nome = nome;
            Cpf = cpf;

            }



        }
    }
