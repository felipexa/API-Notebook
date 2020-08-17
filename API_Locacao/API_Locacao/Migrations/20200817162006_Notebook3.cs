using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Locacao.Migrations
{
    public partial class Notebook3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Multa",
                table: "Devolucao");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Devolucao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Devolucao_ProdutoId",
                table: "Devolucao",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devolucao_Produto_ProdutoId",
                table: "Devolucao",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devolucao_Produto_ProdutoId",
                table: "Devolucao");

            migrationBuilder.DropIndex(
                name: "IX_Devolucao_ProdutoId",
                table: "Devolucao");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Devolucao");

            migrationBuilder.AddColumn<decimal>(
                name: "Multa",
                table: "Devolucao",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
