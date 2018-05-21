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

        private AtividadesController atividadeController = new AtividadesController();



        enum OpcoesMenu
        {
            CriarAtividade = 1,
            ListarAtividades = 2,
            BuscarAtividade = 3,
            EditarAtividade = 4,
            ExcluirAtividade = 5,
            BuscarPorNome = 6,
            ListarAtivo = 7,
            Sair = 9,

        }

        public void ExibirMenu()
        {
            OpcoesMenu opcao = OpcoesMenu.Sair;

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
                Console.WriteLine("6 - Buscar por Nome: ");
                Console.WriteLine("7 - Listar Ativos/Inativos: ");
                Console.WriteLine("9 - Sair : ");
                Console.WriteLine("======================");
               
              

                opcao = (OpcoesMenu) int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case OpcoesMenu.CriarAtividade:
                        CriarAtividade();
                        break;
                    case OpcoesMenu.ListarAtividades:
                        ListarAtividades();
                        break;
                    case OpcoesMenu.BuscarAtividade:
                        BuscarAtividade();
                        break;
                    case OpcoesMenu.EditarAtividade:
                        EditarAtividade();
                        break;
                    case OpcoesMenu.ExcluirAtividade:
                        ExcluirAtividade();
                        break;
                    case OpcoesMenu.BuscarPorNome:
                        BuscarPorNome();
                        break;
                    case OpcoesMenu.ListarAtivo:
                        BuscarAtivo();
                        break;

                    case OpcoesMenu.Sair:
                        break;
                    default:
                        Console.WriteLine(" Opção Invalida! ");
                        Console.ReadKey();
                        break;
                }
                
            } while (opcao != OpcoesMenu.Sair);
        }

        private void BuscarPorNome()
        {
            Console.Write(" Informe o Nome para pesquisa: ");
            string nome = Console.ReadLine();
            List<Atividade> ListaTemp = atividadeController.BuscarPorNome(nome);
            Console.Clear();

            foreach (Atividade a in ListaTemp)
            {
                ExibirDadosDaAtividade(a);
            }

            Console.ReadKey();

        }
        private void BuscarAtivo()
        {
            Console.Clear();
            Console.WriteLine(" Escolha uma das opções ");
            Console.WriteLine(" Ativos (a) ou Inativos (i) : ");
            bool escolha = Console.ReadLine() == "a" ? true : false;
            List<Atividade> ListaTemp = atividadeController.BuscarAtivos(escolha);
            
            foreach (Atividade a in ListaTemp)
            {
                ExibirDadosDaAtividade(a);
            }

            Console.ReadKey();

        }

        public void ListarAtividade(Atividade atividade)
        {
            Console.WriteLine(" ID: " + atividade.AtividadeID);
            Console.WriteLine(" Nome: " + atividade.Nome);
            Console.WriteLine(" Ativo: " + atividade.Ativo);
            Console.ReadKey();

        }

        private void ExcluirAtividade()
        {

            ListarAtividades();
            Console.Write(" Escolha o ID para Excluir: ");
            int id = int.Parse(Console.ReadLine());
            atividadeController.Excluir(id);
        }

        private void EditarAtividade()
        {
            ListarAtividades();
            Console.Write(" Escolha o ID para Editar: ");
            int id = int.Parse(Console.ReadLine());
            Atividade atividadeAtualizada = ObterDadosAtividade();
            atividadeController.Editar(id, atividadeAtualizada);

        }

        private void BuscarAtividade()
        {
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

           
            atividadeController.Salvar(atividade);


        }

        private static Atividade ObterDadosAtividade()
        {
            Atividade atividade = new Atividade();
            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();

            Console.WriteLine("Ativo? (S/N) ");
            atividade.Ativo = Console.ReadLine() == "S" ? true : false;
            
            return atividade;
        }

    }// Fim da Classe
}// Fim namespace
