 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LojinhaV2.Models
{
    public class Reviews
    {


        [Key]
        public int ReviewId { get; set; }

        public string Desc { get; set; }

        public int? Rating { get; set; }


        [ForeignKey("Produtos")]
        public int ProdutoId { get; set; }
        public virtual Produtos Produtos { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}