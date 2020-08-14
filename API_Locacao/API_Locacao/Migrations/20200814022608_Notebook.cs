using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Locacao.Migrations
{
    public partial class Notebook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Cotacao",
                columns: table => new
                {
                    CotacaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Taxa = table.Column<decimal>(nullable: false),
                    ValorDiaria = table.Column<decimal>(nullable: false),
                    ValorTotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotacao", x => x.CotacaoId);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Serie = table.Column<string>(nullable: true),
                    Sistema = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Processador = table.Column<string>(nullable: true),
                    Memoria = table.Column<string>(nullable: true),
                    Tela = table.Column<string>(nullable: true),
                    Condicao = table.Column<string>(nullable: true),
                    Observacao = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProdutoId);
                });

            migrationBuilder.CreateTable(
                name: "Locacao",
                columns: table => new
                {
                    LocacaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFinal = table.Column<DateTime>(nullable: false),
                    Dias = table.Column<int>(nullable: false),
                    CotacaoId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacao", x => x.LocacaoId);
                    table.ForeignKey(
                        name: "FK_Locacao_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locacao_Cotacao_CotacaoId",
                        column: x => x.CotacaoId,
                        principalTable: "Cotacao",
                        principalColumn: "CotacaoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locacao_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Devolucao",
                columns: table => new
                {
                    DevolucaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(nullable: false),
                    Multa = table.Column<decimal>(nullable: false),
                    LocacaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devolucao", x => x.DevolucaoId);
                    table.ForeignKey(
                        name: "FK_Devolucao_Locacao_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacao",
                        principalColumn: "LocacaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devolucao_LocacaoId",
                table: "Devolucao",
                column: "LocacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_ClienteId",
                table: "Locacao",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_CotacaoId",
                table: "Locacao",
                column: "CotacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_ProdutoId",
                table: "Locacao",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devolucao");

            migrationBuilder.DropTable(
                name: "Locacao");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Cotacao");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
