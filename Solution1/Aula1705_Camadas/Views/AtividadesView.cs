using Aula1705_Camadas.Controllers;
using Aula1705_Camadas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1705_Camadas.Views
{
    class AtividadesView
    {
        public void ExibirMenu()
        {
            int opcao = 9;

            do
            {


                Console.Clear();
                Console.WriteLine("======================");
                Console.WriteLine("Escolha uma Opção:");
                Console.WriteLine("1 - Criar Atividade: ");
                Console.WriteLine("2 - Listar Atividades: ");
                Console.WriteLine("3 - Buscar Atividade: ");
                Console.WriteLine("4 - Editar Atividade: ");
                Console.WriteLine("5 - Excluir Atividade: ");
                Console.WriteLine("9 - Sair : ");
                Console.WriteLine("======================");

                opcao = int.Parse(Console.ReadLine());

           

            switch (opcao)
            {
                case 1:
                    CriarAtividade();
                    break;

                    case 2:
                        ListarAtividades();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;


                    default:
                    break;
            }


            } while (opcao != 9);
        }



        private void ListarAtividades()
        {
            AtividadesController atividadeController = new AtividadesController();


            Console.WriteLine(" Inicio da Lista");
            foreach (Atividade atividade in atividadeController.Listar())
            {
                Console.WriteLine("---");
                Console.WriteLine(" ID : " + atividade.AtividadeID);
                Console.WriteLine(" Nome : " + atividade.Nome);
                Console.WriteLine(" Ativo : " + atividade.Ativo);
                Console.WriteLine("---");
            }
            Console.WriteLine(" Fim  da  Lista");
            Console.ReadKey();

        }




        public void CriarAtividade()
        {
            Atividade atividade = new Atividade();
            Console.Write("Digite o nome da atividade: ");
            atividade.Nome =  Console.ReadLine();

            atividade.Ativo = true;

            AtividadesController atividadeCtrl = new AtividadesController();
            atividadeCtrl.Salvar(atividade);


        }








    }
}
