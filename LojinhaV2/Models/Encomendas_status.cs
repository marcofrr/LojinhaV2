using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojinhaV2.Models
{
    public class Encomendas_status
    {

        [Key]
        public int Status_id { get; set; }

        public string status_desc { get; set; }

    }
}
