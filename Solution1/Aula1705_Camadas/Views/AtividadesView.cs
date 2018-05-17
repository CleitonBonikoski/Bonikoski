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
                        BuscarAtividade();
                        break;
                    case 4:
                        EditarAtividade();
                        break;
                    case 5:
                        ExcluirAtividade();
                        break;


                    default:
                    break;
            }


            } while (opcao != 9);
        }

        private void ExcluirAtividade()
        {

            ListarAtividades();
            Console.Write(" Escolha o ID para Excluir: ");
            int id = int.Parse(Console.ReadLine());
            AtividadesController atividadeController = new AtividadesController();
            atividadeController.Excluir(id);
        }

        private void EditarAtividade()
        {
            ListarAtividades();
            Console.Write(" Escolha o ID para Editar: ");
            int id = int.Parse(Console.ReadLine());
            Atividade atividadeAtualizada = ObterDadosAtividade();
            AtividadesController atividadeController = new AtividadesController();
            atividadeController.Editar(id, atividadeAtualizada);

        }

        private void BuscarAtividade()
        {
            AtividadesController atividadeController = new AtividadesController();
            Console.WriteLine("Digite o ID da Atividade : ");
            int id = int.Parse(Console.ReadLine());
            Atividade atividade = atividadeController.BuscarPorID(id);
            Console.Clear();
            if(atividade != null)
            {
                ExibirDadosDaAtividade(atividade);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Atividade Não Encontrada! ");
                Console.ReadKey();
            }

        }

        private void ListarAtividades()
        {
            AtividadesController atividadeController = new AtividadesController();

            Console.Clear();
            Console.WriteLine(" Inicio da Lista");
            foreach (Atividade atividade in atividadeController.Listar())
            {
                ExibirDadosDaAtividade(atividade);
            }
            Console.WriteLine(" Fim  da  Lista");
            Console.ReadKey();

        }

        private static void ExibirDadosDaAtividade(Atividade atividade)
        {
            Console.WriteLine("---");
            Console.WriteLine(" ID : " + atividade.AtividadeID);
            Console.WriteLine(" Nome : " + atividade.Nome);
            Console.WriteLine(" Ativo : " + atividade.Ativo);
            Console.WriteLine("---");
        }

        public void CriarAtividade()
        {
            Atividade atividade = ObterDadosAtividade();

            AtividadesController atividadeCtrl = new AtividadesController();
            atividadeCtrl.Salvar(atividade);


        }

        private static Atividade ObterDadosAtividade()
        {
            Atividade atividade = new Atividade();
            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();

            atividade.Ativo = true;
            return atividade;
        }

    }// Fim da Classe
}// Fim namespace
