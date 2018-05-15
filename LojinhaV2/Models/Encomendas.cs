using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojinhaV2.Models
{
    public class Encomendas
    {
        public Encomendas() {
            ListaDeDetalhes = new HashSet<Detalhes>();

        }
        [Key]
        public int EncomendaId { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataEncomenda { get; set; }

        public string TipoPagamento { get; set; }

        public string EnderecoEnvio { get; set; }

        public string CodigoPostal {get; set; }

        ////Foreign Keys
        ////nome da tabela
        //[ForeignKey("Encomendas_status")]
        //public int Encomenda_status { get; set; }
        //public virtual Encomendas_status Encomendas_status { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        //uma encomenda pode envolver vários Detalhes,items
        public virtual ICollection<Detalhes> ListaDeDetalhes { get; set; }

    }
}
