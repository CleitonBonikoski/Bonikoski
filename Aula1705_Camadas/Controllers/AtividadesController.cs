using Aula1705_Camadas.Models;
using Aula1705_Camadas.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1705_Camadas.Controllers
{
    class AtividadesController
    {
        //Simular uma tabela
        private static List<Atividade> ListaAtividades { get; set; } = new List<Atividade>();
       


        //Salvar
        public void Salvar(Atividade atividade)
        {
            int Id = 0;
            foreach (Atividade ati in ListaAtividades)
            {
                Id = ati.AtividadeID;
            }

            atividade.AtividadeID = Id + 1;
            ListaAtividades.Add(atividade);
        }


        //Listar

        public List<Atividade> Listar()
        {
            return ListaAtividades;
        }



        //BuscarPorID
        public Atividade BuscarPorID(int id)
        {
            foreach (Atividade a in ListaAtividades)
            {
                if(a.AtividadeID == id)
                {
                    return a;
                }
                
            }

            return null;
        }



        public List<Atividade> BuscarPorNome(string nome) // 101 linq pode ser aplicado para referencia.
        {

            List<Atividade> ListaTemp = new List<Atividade>();
            foreach (Atividade a in ListaAtividades)
            {
                if (a.Nome.ToLower().Contains(nome.ToLower())) //ToLower deixa todos os caracteres minusculos(tudo) // Contains verifica se contem(...) 
                {
                    ListaTemp.Add(a);
                }

            }

            return ListaTemp;
        }



        public List<Atividade> BuscarAtivos(bool ativo) 
        {
            IEnumerable<Atividade> list = new List<Atividade>();
            list = from x in ListaAtividades
                   where x.Ativo == ativo
                   select x;
            return list.ToList();

            /*  
             *  
             *  Forma mais primitiva de realizar a consulta
             *  
             *  
             *  List < Atividade > ListaTemp = new List<Atividade>();
              foreach (Atividade a in ListaAtividades)
              {
                  if (a.Ativo)
                  {
                      ListaTemp.Add(a);
                  }
                  
                  // podemos utilizar o DataSet para melhorar performace
              }
              
             *
             */

        }




        //Editar
        public void Editar(int id, Atividade atividadeAtualizada)
        {
            Atividade atividadeAntiga = BuscarPorID(id);
            if(atividadeAntiga != null)
            {

                atividadeAntiga.Nome = atividadeAtualizada.Nome;
                atividadeAntiga.Ativo = atividadeAtualizada.Ativo;
               
            }

        }



        //Excluir
        public void Excluir(int id)
        {
            Atividade atividade = BuscarPorID(id);
            if(atividade != null)
            {
                ListaAtividades.Remove(atividade);
            }
        }








    }
}
