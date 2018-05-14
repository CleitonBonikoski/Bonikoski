using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.Model {

    /// <summary>
    /// Essa classe representa um FrameWork e o Banco de Dados no projeto 
    /// </summary>

    class Context : DbContext
        {
        //Nomear o Banco de Dados
        public Context() : base("DbCarros") { }
        
        //Mapear as classes que vão virar tabela no Banco de Dados
        public DbSet<Carro> Carros { get; set }
            
        }
    }
