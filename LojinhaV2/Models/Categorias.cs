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
        public int Categoria_id { get; set; }

        public string Categoria_desc { get; set; }

        public string Categoria_img { get; set; }

        public virtual ICollection<Produtos> ListaDeProdutos { get; set; }
    }
}