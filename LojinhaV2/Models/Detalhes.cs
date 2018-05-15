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
        public int Detalhes_id { get; set; }

        [ForeignKey("Encomendas")]
        public int Encomenda_id { get; set; }
        public virtual Encomendas Encomendas { get; set; }

        public int Quantidade { get; set; }


        [ForeignKey("Produtos")]
        public int Produto_id { get; set; }
        public virtual Produtos Produtos { get; set; }



    }
}