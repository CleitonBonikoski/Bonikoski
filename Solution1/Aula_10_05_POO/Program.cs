using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10_05_POO {
    class Program {
        static void Main(string[] args) {
            Cliente cli = new Cliente();
            cli.Nome = "Gogofredo"; // set
            String nomeCliente = cli.Nome; //get
            cli.Cpf = "12345678909";
            string cpfCliente = cli.Cpf;


            Console.WriteLine(" Nome: " + nomeCliente);
            Console.WriteLine(" CPF: " + cpfCliente);

            // Utilização dos construtores;

            Pessoa cli2 = new Cliente("Jucicleia");// nome
            Console.WriteLine("Cli2 Nome: " + cli2.Nome);

            Pessoa cli3 = new Cliente("Jucileia", "12345678900");//nome + cpf
            Console.WriteLine("Cli3 Nome: " + cli3.Nome);

            // Classes Abstratas não podem ser instanciadas;
            //Pessoa p = new Pessoa();

            cli.DataNasc = new DateTime(1998,12,09);


            Console.WriteLine(" Data: " + cli.DataNasc);
            Console.WriteLine(" Data Nascimento: " + cli.Idade);

            Console.ReadKey();
                
                    
           }
        }
    }
