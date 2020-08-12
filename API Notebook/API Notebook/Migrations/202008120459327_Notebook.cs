namespace API_Notebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Notebook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Cpf = c.String(),
                        Nome = c.String(),
                        Cep = c.String(),
                        Endereco = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        LocacaoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Locacaos", t => t.LocacaoId, cascadeDelete: true)
                .Index(t => t.LocacaoId);
            
            CreateTable(
                "dbo.Locacaos",
                c => new
                    {
                        LocacaoId = c.Int(nullable: false, identity: true),
                        DataInicio = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                        Dias = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        CotacaoId = c.Int(nullable: false),
                        DevolucaoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LocacaoId)
                .ForeignKey("dbo.Devolucaos", t => t.DevolucaoId, cascadeDelete: true)
                .ForeignKey("dbo.Produtos", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId)
                .Index(t => t.DevolucaoId);
            
            CreateTable(
                "dbo.Cotacaos",
                c => new
                    {
                        CotacaoId = c.Int(nullable: false, identity: true),
                        Taxa = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorDiaria = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LocacaoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CotacaoId)
                .ForeignKey("dbo.Locacaos", t => t.LocacaoId, cascadeDelete: true)
                .Index(t => t.LocacaoId);
            
            CreateTable(
                "dbo.Devolucaos",
                c => new
                    {
                        DevolucaoId = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Multa = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LocacaoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DevolucaoId);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Serie = c.String(),
                        Sistema = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Processador = c.String(),
                        Memoria = c.String(),
                        Tela = c.String(),
                        Condicao = c.String(),
                        Observacao = c.String(),
                        Status = c.String(),
                        LocacaoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
        }
        
       
    }
}
