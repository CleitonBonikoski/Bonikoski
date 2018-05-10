using System;

namespace Aula_10_05_POO {
    class Cliente:Pessoa{
        public Cliente() {

            }

        public DateTime DataNasc{ get; set; }

        public string DataQueNasc() {
            return DataNasc.ToShortDateString();// retorna somente a data.
            }

        public Cliente(String nome):base(nome) {

            //manda para a base que extende o parâmetro; 

            }

        public Cliente(String nome, string cpf):base(nome,cpf) {

                
            }
        public int Idade { get { return  DateTime.Today.Year - DataNasc.Year  ; }}



        }// fim class
    }// fim namespace
