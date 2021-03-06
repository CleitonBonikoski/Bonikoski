﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces {
    class Carro : IMeioTransporte {

        public int Velocidade { get; set; }

        //chave para objeto Marca
        public int MarcaID { get; set; }

        //Propriedade de navegação
        public virtual Marca_Marca { get; set; }

        public Carro() {
            Velocidade = 0;
            }


        public void Acelerar() {
            Velocidade += 10;
            }

        public void Desacelerar() {
            Velocidade -= 5;
            }

        public string ImprimirInfo() {
            return "Carro, Velocidade: " + Velocidade;
            }

        }
    }
