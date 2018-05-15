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
        public Encomendas(){
            ListaDeDetalhes = new HashSet<Detalhes>();

        }
        [Key]
        public int Encomenda_id { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data_encomenda { get; set; }
        
        public string Tipo_pagamento { get; set; }
        
        public string Endereco_envio { get; set; }

        ////Foreign Keys
        ////nome da tabela
        //[ForeignKey("Encomendas_status")]
        //public int Encomenda_status { get; set; }
        //public virtual Encomendas_status Encomendas_status { get; set; }

        [ForeignKey("Cliente")]
        public int Cliente_id { get; set; }
        public virtual Cliente Cliente { get; set; }

        //uma encomenda pode envolver vários Detalhes,items
        public virtual ICollection<Detalhes> ListaDeDetalhes { get; set; }

    }
}
