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
        public int nSerie { get; set; }

        public string ProdutoNome { get; set; }

        public decimal ProdutoPreco { get; set; }

        public int? ProdutoGarantia { get; set; }

        public string ProdutoDesc { get; set; }

        public string ProdutoImg { get; set; }

        public int Quantidade { get; set; }

        public int Iva { get; set;  }
        /// <summary>
        /// Um item pode estar associado a uma lista de Encomendas
        /// </summary>
        public virtual ICollection<Detalhes> ListaDeDetalhes { get; set; }
        public virtual ICollection<Categorias> ListaDeCategorias { get; set; }
    }
}