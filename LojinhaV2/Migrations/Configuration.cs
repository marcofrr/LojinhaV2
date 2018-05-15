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



         };
            Clientes.ForEach(aa => context.Cliente.AddOrUpdate(a => a.Cliente_id, aa));
            context.SaveChanges();
 
            //*********************************************************************
            // adiciona Encomendas
            var Encomendas = new List<Encomendas> {
                new Encomendas{Encomenda_id=1,Quantidade=2,Data_encomenda=new DateTime(2017,3,1),Tipo_pagamento="Multibanco",Endereco_envio="Rua 1º de Dezembro N.º 2 - 3 Esq.",Cliente_id=2},
                new Encomendas{Encomenda_id=2,Quantidade=3,Data_encomenda=new DateTime(2018,1,12),Tipo_pagamento="PayPal",Endereco_envio="Rua do Pelourinho N.º 1 - 2 Dir.",Cliente_id=3},
                new Encomendas{Encomenda_id=3,Quantidade=1,Data_encomenda=new DateTime(2016,9,10),Tipo_pagamento="PayPal",Endereco_envio="Rua dos Combatentes N.º 17",Cliente_id=4},
                new Encomendas{Encomenda_id=4,Quantidade=3,Data_encomenda=new DateTime(2016,3,15),Tipo_pagamento="CTT",Endereco_envio="Rua dos Descobridores N.º 7",Cliente_id=5},
                new Encomendas{Encomenda_id=5,Quantidade=2,Data_encomenda=new DateTime(2014,2,18),Tipo_pagamento="Cartão de Crédito",Endereco_envio="Travessa do Parque N.º 8",Cliente_id=6},
                new Encomendas{Encomenda_id=6,Quantidade=2,Data_encomenda=new DateTime(2013,7,18),Tipo_pagamento="Multibanco",Endereco_envio="Travessa do Parque N.º 8",Cliente_id=6}

         };
            Encomendas.ForEach(bb => context.Encomendas.AddOrUpdate(b => b.Encomenda_id, bb));
            context.SaveChanges();


            //*********************************************************************
            // adiciona Categorias
            var Categorias = new List<Categorias> {
                new Categorias {Categoria_id=1, Categoria_img="/cat/img1", Categoria_desc="Memórias"},
                new Categorias {Categoria_id=2, Categoria_img="/cat/img2", Categoria_desc="Armazenamento"},
                new Categorias {Categoria_id=3, Categoria_img="/cat/img3", Categoria_desc="Redes"},
                new Categorias {Categoria_id=4, Categoria_img="/cat/img4", Categoria_desc="Periféricos"},
                new Categorias {Categoria_id=5, Categoria_img="/cat/img5", Categoria_desc="Monitores"},
                new Categorias {Categoria_id=6, Categoria_img="/cat/img6", Categoria_desc="Software"}
            };
            Categorias.ForEach(dd => context.Categorias.AddOrUpdate(d => d.Categoria_id, dd));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Produtos
            var Produtos = new List<Produtos>
            {
                new Produtos {Produto_id=1, Produto_nome="RAM DDR4", Produto_preco=44, Produto_garantia=1, Produto_desc="Memória DDR SO-DIMM da Apacer de 256MB que funciona a 333MHz com CAS 2.5.", Produto_img="/pro/pro1", Quantidade=12, Categoria_id=1},
                new Produtos {Produto_id=2, Produto_nome="SDD 420GB", Produto_preco=321, Produto_garantia=2, Produto_desc="Elevadas velocidades de leitura/gravação sequenciais e tecnologia TurboWrite", Produto_img="/pro/pro2", Quantidade=15 , Categoria_id=2},
                new Produtos {Produto_id=3, Produto_nome="Router Wireless", Produto_preco=653, Produto_garantia=3, Produto_desc="Um Router Sem Fios de Banda Dupla 802.11ac/n, que oferece velocidades extremamente rápidas de até 1200Mbps.", Produto_img="/pro/pro3", Quantidade=11 , Categoria_id=3},
                new Produtos {Produto_id=4, Produto_nome="Teclado Mecânico", Produto_preco=1233, Produto_garantia=5, Produto_desc="um teclado gaming retro-iluminado de nível de torneio construído para satisfazer por completo as exigências dos jogadores profissionais", Produto_img="/pro/pro4", Quantidade= 54, Categoria_id=4},
                new Produtos {Produto_id=5, Produto_nome="Monitor HP 144HZ", Produto_preco=321, Produto_garantia=2, Produto_desc="Lidere a tabela de classificações e domine combates repletos de ação.", Produto_img="/pro/pro5", Quantidade=32 , Categoria_id=5},
                new Produtos {Produto_id=6, Produto_nome="NORTON Mobile", Produto_preco=6554, Produto_garantia=1, Produto_desc="Um desempenho superior à concorrência em diversos testes de comparação independentes.", Produto_img="/pro/pro6", Quantidade= 11, Categoria_id=6}
            };
            Produtos.ForEach(ee => context.Produtos.AddOrUpdate(e => e.Categoria_id, ee));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Reviews
            var Reviews = new List<Reviews>
            {
                new Reviews {Review_id=1, Desc="Excelente produto!, ecomendo",Rating=3,Produto_id=1, Cliente_id=1},
                new Reviews {Review_id=2, Desc="Recomendo!",Rating=4,Produto_id=2, Cliente_id=2},
                new Reviews {Review_id=3, Desc="Funciona!",Rating=2,Produto_id=3, Cliente_id=3},
                new Reviews {Review_id=4, Desc="ADORO!",Rating=1,Produto_id=4, Cliente_id=4},
                new Reviews {Review_id=5, Desc="Bons Materiais",Rating=5,Produto_id=5, Cliente_id=5},
                new Reviews {Review_id=6, Desc="Ótimo sistema de reviews",Rating=5,Produto_id=6, Cliente_id=6}

            };
            Reviews.ForEach(ff => context.Reviews.AddOrUpdate(f => f.Review_id, ff));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Detalhes das Encomendas
            var Detalhes = new List<Detalhes> {
                new Detalhes {Detalhes_id=1, Encomenda_id=7, Quantidade=2, Produto_id=2},
                new Detalhes {Detalhes_id=2, Encomenda_id=7, Quantidade=3, Produto_id=1},
                new Detalhes {Detalhes_id=3, Encomenda_id=8, Quantidade=1, Produto_id=3},
                new Detalhes {Detalhes_id=4, Encomenda_id=9, Quantidade=4, Produto_id=4},
                new Detalhes {Detalhes_id=5, Encomenda_id=10, Quantidade=5, Produto_id=5},
                new Detalhes {Detalhes_id=6, Encomenda_id=11, Quantidade=11, Produto_id=6}
            };
            Detalhes.ForEach(gg => context.Detalhes.AddOrUpdate(g => g.Detalhes_id, gg));
            context.SaveChanges();
        }


    }
}
