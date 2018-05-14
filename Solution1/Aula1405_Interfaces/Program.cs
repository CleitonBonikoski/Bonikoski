using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces {
    class Program {
        static void Main(string[] args) {

            Carro car = new Carro();

            Console.WriteLine(" Velocidade Inicial : " +  car.Velocidade);

            car.Acelerar();
            car.Acelerar();
            car.Desacelerar();

            Console.WriteLine(" Velocidade Total: " + car.Velocidade);

            Console.ReadKey();


            }// Fim main



        }// fim class
    }
