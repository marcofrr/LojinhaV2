namespace LojinhaV2.Migrations
{
    using LojinhaV2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LojinhaV2.Models.AppDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppDB context)
        {
            //*********************************************************************
            // adiciona Clientes
            var Clientes = new List<Cliente> {
                new Cliente {Cliente_id=1,Primeiro_nome="Maria",Ultimo_nome="Almeida",Email="mariaa@gmail.com",Telemovel=911111111,Endereco="Rua 1º de Dezembro N.º 2 - 3 Esq.",Localidade="Tomar",Distrito="Santarém",Pais="Portugal" },
                new Cliente {Cliente_id=2,Primeiro_nome="Manuela",Ultimo_nome="Almeida",Email="almeidaM@gmail.com",Telemovel=922222222,Endereco="Travessa do Parque N.º 88",Localidade="Abrantes",Distrito="Santarém",Pais="Portugal" },
                new Cliente {Cliente_id=3,Primeiro_nome="André",Ultimo_nome="Rocha",Email="andrer@gmail.com",Telemovel=933333333,Endereco="Rua do Pelourinho N.º 1 - 2 Dir.",Localidade="Lisboa",Distrito="Lisboa",Pais="Portugal" },
                new Cliente {Cliente_id=4,Primeiro_nome="Ana",Ultimo_nome="Fernandes",Email="fernandes@gmail.com",Telemovel=944444444,Endereco="Rua dos Combatentes N.º 17",Localidade="Faro",Distrito="Faro",Pais="Portugal" },
                new Cliente {Cliente_id=5,Primeiro_nome="Gustavo",Ultimo_nome="Melo",Email="melo@gmail.com",Telemovel=955555555,Endereco="Rua dos Descobridores N.º 7",Localidade="Lisboa",Distrito="Lisboa",Pais="Portugal" },
                new Cliente {Cliente_id=6,Primeiro_nome="Simão",Ultimo_nome="Melo",Email="simao@gmail.com",Telemovel=966666666,Endereco="Travessa do Parque N.º 8",Localidade="Porto",Distrito="Porto",Pais="Portugal" }


                //new Agentes {ID=1, Nome="Tânia Vieira", Esquadra="Ourém", Fotografia="TaniaVieira.jpg" },

         };
            Clientes.ForEach(aa => context.Cliente.AddOrUpdate(a => a.Cliente_id, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona VIATURAS
        }
    }
}
