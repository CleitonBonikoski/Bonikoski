using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces {
    class Program {
        static void Main(string[] args) {

            Carro car = new Carro();

            Console.WriteLine(" Velocidade Start Carro : " +  car.Velocidade);

            car.Acelerar();
            car.Acelerar();
            car.Desacelerar();

            Console.WriteLine(" Velocidade Total Carro : " + car.Velocidade);

            Onibus bus = new Onibus();
            Console.WriteLine(" Velocidade Start Onibus : " + bus.Velocidade);
            bus.Acelerar();
            bus.Acelerar();
            Console.WriteLine(" Velocidade Aceleração Onibus : " + bus.Velocidade);
            bus.Desacelerar();
            Console.WriteLine(" Velocidade Final Onibus : " + bus.Velocidade);

            Console.ReadKey();


            }// Fim main



        }// fim class
    }
