using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojinhaV2.Models
{
    public class Detalhes
    {   
        [Key]
        public int DetalhesId { get; set; }

        [ForeignKey("Encomendas")]
        public int EncomendaId { get; set; }
        public virtual Encomendas Encomendas { get; set; }

        public int Quantidade { get; set; }


        [ForeignKey("Produtos")]
        public int ProdutoId { get; set; }
        public virtual Produtos Produtos { get; set; }



    }
}