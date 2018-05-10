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

        public string Cpf { set; get; } // propriedade sem declarar o atributo.


        //construtor
        public Cliente() { // construtor vazio
            }

        public Cliente(string nome) {
            Nome = nome;
            }
        public Cliente(String nome, String cpf) {
            Nome = nome;
            Cpf = cpf;
          
            }

        }// fim class
    }// fim namespace
