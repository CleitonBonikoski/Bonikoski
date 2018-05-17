using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Interfaces {
    class Program {
        static void Main(string[] args) {

            Carro carro = new Carro();
            Onibus o = new Onibus();

            o.Acelerar();
            o.Acelerar();
            o.Acelerar();
            o.Desacelerar();
            o.Acelerar();
            o.Desacelerar();

            o.Info();

            CriarRelacionamentos();
            
            Console.ReadKey();
        }

        static void CriarRelacionamentos() {

            Marca m = new Marca();
            m.Nome = "Chevrolet";

            Carro c = new Carro();
            c.Modelo = "Corsa";

            c._Marca = m;

            c.Rodas = new List<Roda>();
            Roda r1 = new Roda();
            c.Rodas.Add(r1);

            Console.WriteLine("Quantidade de Rodas: " + c.Rodas.Count);
            
            Onibus o = new Onibus();
            o.Modelo = "3100";

            o._Marca = m;
        }
    }
}
