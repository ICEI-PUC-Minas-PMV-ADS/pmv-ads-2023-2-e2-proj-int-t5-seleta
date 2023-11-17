using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seleta.Migrations
{
    public partial class AjustandoRelacionamentoProdutoListaDeCompras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListaDeComprasProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListaDeComprasProduto",
                columns: table => new
                {
                    ListasDeComprasEmail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProdutosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaDeComprasProduto", x => new { x.ListasDeComprasEmail, x.ProdutosId });
                    table.ForeignKey(
                        name: "FK_ListaDeComprasProduto_ListaDeCompras_ListasDeComprasEmail",
                        column: x => x.ListasDeComprasEmail,
                        principalTable: "ListaDeCompras",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListaDeComprasProduto_Produtos_ProdutosId",
                        column: x => x.ProdutosId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListaDeComprasProduto_ProdutosId",
                table: "ListaDeComprasProduto",
                column: "ProdutosId");
        }
    }
}
