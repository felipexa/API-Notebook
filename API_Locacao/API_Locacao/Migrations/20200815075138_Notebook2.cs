using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Locacao.Migrations
{
    public partial class Notebook2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_Cotacao_CotacaoId",
                table: "Locacao");

            migrationBuilder.DropTable(
                name: "Cotacao");

            migrationBuilder.DropIndex(
                name: "IX_Locacao_CotacaoId",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "CotacaoId",
                table: "Locacao");

            migrationBuilder.AddColumn<decimal>(
                name: "ValorDiaria",
                table: "Locacao",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorTotal",
                table: "Locacao",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorDiaria",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "Locacao");

            migrationBuilder.AddColumn<int>(
                name: "CotacaoId",
                table: "Locacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cotacao",
                columns: table => new
                {
                    CotacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Taxa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorDiaria = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotacao", x => x.CotacaoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_CotacaoId",
                table: "Locacao",
                column: "CotacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_Cotacao_CotacaoId",
                table: "Locacao",
                column: "CotacaoId",
                principalTable: "Cotacao",
                principalColumn: "CotacaoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
