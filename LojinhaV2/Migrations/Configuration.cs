namespace LojinhaV2.Migrations
{
    using LojinhaV2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LojinhaV2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //*********************************************************************
            // adiciona Clientes
            var Clientes = new List<Cliente> {
                new Cliente {ClienteId=1,PrimeiroNome="Maria",UltimoNome="Almeida",Email="mariaa@gmail.com",Telemovel=911111111,Endereco="Rua 1º de Dezembro N.º 2 - 3 Esq.",Localidade="Tomar",Distrito="Santarém",Pais="Portugal" },
                new Cliente {ClienteId=2,PrimeiroNome="Manuela",UltimoNome="Almeida",Email="almeidaM@gmail.com",Telemovel=922222222,Endereco="Travessa do Parque N.º 88",Localidade="Abrantes",Distrito="Santarém",Pais="Portugal" },
                new Cliente {ClienteId=3,PrimeiroNome="André",UltimoNome="Rocha",Email="andrer@gmail.com",Telemovel=933333333,Endereco="Rua do Pelourinho N.º 1 - 2 Dir.",Localidade="Lisboa",Distrito="Lisboa",Pais="Portugal" },
                new Cliente {ClienteId=4,PrimeiroNome="Ana",UltimoNome="Fernandes",Email="fernandes@gmail.com",Telemovel=944444444,Endereco="Rua dos Combatentes N.º 17",Localidade="Faro",Distrito="Faro",Pais="Portugal" },
                new Cliente {ClienteId=5,PrimeiroNome="Gustavo",UltimoNome="Melo",Email="melo@gmail.com",Telemovel=955555555,Endereco="Rua dos Descobridores N.º 7",Localidade="Lisboa",Distrito="Lisboa",Pais="Portugal" },
                new Cliente {ClienteId=6,PrimeiroNome="Simão",UltimoNome="Melo",Email="simao@gmail.com",Telemovel=966666666,Endereco="Travessa do Parque N.º 8",Localidade="Porto",Distrito="Porto",Pais="Portugal" }



         };
            Clientes.ForEach(aa => context.Cliente.AddOrUpdate(a => a.ClienteId, aa));
            context.SaveChanges();
 
            //*********************************************************************
            // adiciona Encomendas
            var Encomendas = new List<Encomendas> {
                new Encomendas{EncomendaId=1,Quantidade=2,DataEncomenda=new DateTime(2017,3,1),TipoPagamento="Multibanco",EnderecoEnvio="Rua 1º de Dezembro N.º 2 - 3 Esq.",ClienteId=2},
                new Encomendas{EncomendaId=2,Quantidade=3,DataEncomenda=new DateTime(2018,1,12),TipoPagamento="PayPal",EnderecoEnvio="Rua do Pelourinho N.º 1 - 2 Dir.",ClienteId=3},
                new Encomendas{EncomendaId=3,Quantidade=1,DataEncomenda=new DateTime(2016,9,10),TipoPagamento="PayPal",EnderecoEnvio="Rua dos Combatentes N.º 17",ClienteId=4},
                new Encomendas{EncomendaId=4,Quantidade=3,DataEncomenda=new DateTime(2016,3,15),TipoPagamento="CTT",EnderecoEnvio="Rua dos Descobridores N.º 7",ClienteId=5},
                new Encomendas{EncomendaId=5,Quantidade=2,DataEncomenda=new DateTime(2014,2,18),TipoPagamento="Cartão de Crédito",EnderecoEnvio="Travessa do Parque N.º 8",ClienteId=6},
                new Encomendas{EncomendaId=6,Quantidade=2,DataEncomenda=new DateTime(2013,7,18),TipoPagamento="Multibanco",EnderecoEnvio="Travessa do Parque N.º 8",ClienteId=6}

         };
            Encomendas.ForEach(bb => context.Encomendas.AddOrUpdate(b => b.EncomendaId, bb));
            context.SaveChanges();


            //*********************************************************************
            // adiciona Categorias
            var Categorias = new List<Categorias> {
                new Categorias {CategoriaId=1, CategoriaImg="/cat/img1", CategoriaDesc="Memórias"},
                new Categorias {CategoriaId=2, CategoriaImg="/cat/img2", CategoriaDesc="Armazenamento"},
                new Categorias {CategoriaId=3, CategoriaImg="/cat/img3", CategoriaDesc="Redes"},
                new Categorias {CategoriaId=4, CategoriaImg="/cat/img4", CategoriaDesc="Periféricos"},
                new Categorias {CategoriaId=5, CategoriaImg="/cat/img5", CategoriaDesc="Monitores"},
                new Categorias {CategoriaId=6, CategoriaImg="/cat/img6", CategoriaDesc="Software"}
            };
            Categorias.ForEach(dd => context.Categorias.AddOrUpdate(d => d.CategoriaId, dd));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Produtos
            var Produtos = new List<Produtos>
            {
                new Produtos {ProdutoId=1, Produto_nome="RAM DDR4", Produto_preco=44, Produto_garantia=1, Produto_desc="Memória DDR SO-DIMM da Apacer de 256MB que funciona a 333MHz com CAS 2.5.", Produto_img="/pro/pro1", Quantidade=12, CategoriaId=1},
                new Produtos {ProdutoId=2, Produto_nome="SDD 420GB", Produto_preco=321, Produto_garantia=2, Produto_desc="Elevadas velocidades de leitura/gravação sequenciais e tecnologia TurboWrite", Produto_img="/pro/pro2", Quantidade=15 , CategoriaId=2},
                new Produtos {ProdutoId=3, Produto_nome="Router Wireless", Produto_preco=653, Produto_garantia=3, Produto_desc="Um Router Sem Fios de Banda Dupla 802.11ac/n, que oferece velocidades extremamente rápidas de até 1200Mbps.", Produto_img="/pro/pro3", Quantidade=11 , CategoriaId=3},
                new Produtos {ProdutoId=4, Produto_nome="Teclado Mecânico", Produto_preco=1233, Produto_garantia=5, Produto_desc="um teclado gaming retro-iluminado de nível de torneio construído para satisfazer por completo as exigências dos jogadores profissionais", Produto_img="/pro/pro4", Quantidade= 54, CategoriaId=4},
                new Produtos {ProdutoId=5, Produto_nome="Monitor HP 144HZ", Produto_preco=321, Produto_garantia=2, Produto_desc="Lidere a tabela de classificações e domine combates repletos de ação.", Produto_img="/pro/pro5", Quantidade=32 , CategoriaId=5},
                new Produtos {ProdutoId=6, Produto_nome="NORTON Mobile", Produto_preco=6554, Produto_garantia=1, Produto_desc="Um desempenho superior à concorrência em diversos testes de comparação independentes.", Produto_img="/pro/pro6", Quantidade= 11, CategoriaId=6}
            };
            Produtos.ForEach(ee => context.Produtos.AddOrUpdate(e => e.CategoriaId, ee));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Reviews
            var Reviews = new List<Reviews>
            {
                new Reviews {Review_id=1, Desc="Excelente produto!, ecomendo",Rating=3,ProdutoId=1, ClienteId=1},
                new Reviews {Review_id=2, Desc="Recomendo!",Rating=4,ProdutoId=2, ClienteId=2},
                new Reviews {Review_id=3, Desc="Funciona!",Rating=2,ProdutoId=3, ClienteId=3},
                new Reviews {Review_id=4, Desc="ADORO!",Rating=1,ProdutoId=4, ClienteId=4},
                new Reviews {Review_id=5, Desc="Bons Materiais",Rating=5,ProdutoId=5, ClienteId=5},
                new Reviews {Review_id=6, Desc="Ótimo sistema de reviews",Rating=5,ProdutoId=6, ClienteId=6}

            };
            Reviews.ForEach(ff => context.Reviews.AddOrUpdate(f => f.Review_id, ff));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Detalhes das Encomendas
            var Detalhes = new List<Detalhes> {
                new Detalhes {Detalhes_id=1, EncomendaId=7, Quantidade=2, ProdutoId=2},
                new Detalhes {Detalhes_id=2, EncomendaId=7, Quantidade=3, ProdutoId=1},
                new Detalhes {Detalhes_id=3, EncomendaId=8, Quantidade=1, ProdutoId=3},
                new Detalhes {Detalhes_id=4, EncomendaId=9, Quantidade=4, ProdutoId=4},
                new Detalhes {Detalhes_id=5, EncomendaId=10, Quantidade=5, ProdutoId=5},
                new Detalhes {Detalhes_id=6, EncomendaId=11, Quantidade=11, ProdutoId=6}
            };
            Detalhes.ForEach(gg => context.Detalhes.AddOrUpdate(g => g.Detalhes_id, gg));
            context.SaveChanges();
        }


    }
}
