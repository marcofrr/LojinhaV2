using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LojinhaV2.Models
{
    public class Produtos
    {
        public Produtos()
        {
            ListaDeDetalhes = new HashSet<Detalhes>();
            ListaDeCategorias = new HashSet<Categorias>();

        }
        [Key]
        public int Produto_id { get; set; }

        public string Produto_nome { get; set; }

        public float Produto_preco { get; set; }

        public int Produto_garantia { get; set; }

        public string Produto_desc { get; set; }

        public string Produto_img { get; set; }

        public int Quantidade { get; set; }

        [ForeignKey("Categorias")]
        public int Categoria_id { get; set; }
        public virtual Categorias Categorias { get; set; }

        /// <summary>
        /// Um item pode estar associado a uma lista de Encomendas
        /// </summary>
        public virtual ICollection<Detalhes> ListaDeDetalhes { get; set; }
        public virtual ICollection<Categorias> ListaDeCategorias { get; set; }
    }
}