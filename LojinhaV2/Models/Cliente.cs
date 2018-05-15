using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojinhaV2.Models
{
    public class Cliente
    {
        public Cliente()
        {
            ListaDeEncomendas = new HashSet<Encomendas>();
            ListaDeReviews = new HashSet<Reviews>();
        }
        [Key]
        public int ClienteId { get; set; }

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public string Email { get; set; }

        public long Telemovel { get; set; }

        public string Endereco { get; set; }

        public string Localidade { get; set; }

        public string Distrito { get; set; }

        public string Pais { get; set; }

        public string CodigoPostal { get; set; }

        // complementar a informação sobre o relacionamento
        // um cliente terá uma lista de encomendas e uma lista de reviews
        public virtual ICollection<Encomendas> ListaDeEncomendas { get; set; }

        //um cliente terá uma lista de reviews
        public virtual ICollection<Reviews> ListaDeReviews { get; set; }


    }
}
