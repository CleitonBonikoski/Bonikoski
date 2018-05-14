using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosOsorioA.Model {

    //Anotação que define o nome da tabela no Banco de Dados
    [Table("Carros")]
    class Carro 
        {
        //Anotação define a chave primaria na tabela
        //[Key]
        //public int PessoaId { get; set; }

        
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public DateTime DataFabricacao { get; set; }


        //[Required]
        //[MaxLength(50)]


        }
    }
