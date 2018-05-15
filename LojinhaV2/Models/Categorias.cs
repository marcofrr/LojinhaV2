using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojinhaV2.Models
{
    public class Categorias
    {
        public Categorias()
        {
            ListaDeProdutos = new HashSet<Produtos>();
        }
        [Key]
        public int CategoriaId { get; set; }

        public string CategoriaDesc { get; set; }

        public string CategoriaImg { get; set; }

        public virtual ICollection<Produtos> ListaDeProdutos { get; set; }
    }
}