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
            cli.cpf = "12345678909";
            string cpfCliente = cli.cpf;

            Console.WriteLine(" CPF: " + cpfCliente);
            Console.ReadKey();
                
                    
           }
        }
    }
