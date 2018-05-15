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
        public AppDB() : base("AppDbConnectionString")
        { }


        // identificar as tabelas da base de dados
        public virtual DbSet<Encomendas> Encomendas { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }

        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }

        public virtual DbSet<Produtos> Produtos { get; set;  }

        public virtual DbSet<Detalhes> Detalhes { get; set; }






    }
}
