using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seleta.Migrations
{
    public partial class CriarTabelaProdutosListaDeComprasERelacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListaDeCompras",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaDeCompras", x => x.Email);
                });

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

            migrationBuilder.CreateTable(
                name: "ProdutosListaDeCompras",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    ListaDeComprasEmail = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosListaDeCompras", x => new { x.ProdutoId, x.ListaDeComprasEmail });
                    table.ForeignKey(
                        name: "FK_ProdutosListaDeCompras_ListaDeCompras_ListaDeComprasEmail",
                        column: x => x.ListaDeComprasEmail,
                        principalTable: "ListaDeCompras",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutosListaDeCompras_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListaDeComprasProduto_ProdutosId",
                table: "ListaDeComprasProduto",
                column: "ProdutosId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosListaDeCompras_ListaDeComprasEmail",
                table: "ProdutosListaDeCompras",
                column: "ListaDeComprasEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListaDeComprasProduto");

            migrationBuilder.DropTable(
                name: "ProdutosListaDeCompras");

            migrationBuilder.DropTable(
                name: "ListaDeCompras");
        }
    }
}
