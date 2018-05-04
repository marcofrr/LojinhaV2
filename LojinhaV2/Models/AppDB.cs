using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace LojinhaV2.Models
{
    public class AppDB : DbContext
    {
        public AppDB() : base("AppDBConnectionString")
        { }


        // identificar as tabelas da base de dados
        public virtual DbSet<Encomendas> Encomendas { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Encomendas_status> Encomendas_status { get; set; }





    }
}
