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
        [Key]
        public int Encomenda_id { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data_encomenda { get; set; }
        
        public string Tipo_pagamento { get; set; }
        
        public string Endereco_envio { get; set; }

        //Foreign Keys
        [ForeignKey("Encomenda_status")]
        public int Encomenda_status { get; set; }
        public virtual Encomendas_status Encomendas_status { get; set; }

        [ForeignKey("Cliente_id")]
        public int Cliente_id { get; set; }
        public virtual Cliente Cliente { get; set; }

        // complementar a informação sobre o relacionamento
        // uma encomenda ao longo do seu trajeto irá ter vários status
        public virtual ICollection<Encomendas_status> ListaDeStatus { get; set; }

    }
}
