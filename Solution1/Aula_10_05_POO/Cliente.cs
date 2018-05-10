using System;

namespace Aula_10_05_POO {
    class Cliente:Pessoa{
        public Cliente() {

            }

        public DateTime DataNasc{ get; set; }

        public Cliente(String nome):base(nome) {

            //manda para a base que extende o parâmetro; 

            }

        public Cliente(String nome, string cpf):base(nome,cpf) {

                
            }
       


        }// fim class
    }// fim namespace
