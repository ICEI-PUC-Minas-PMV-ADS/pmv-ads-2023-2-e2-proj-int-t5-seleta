using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seleta.Migrations
{
    public partial class AjustandoTabelaProdutosListaDeCompras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProdutosListaDeCompras",
                table: "ProdutosListaDeCompras");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProdutosListaDeCompras",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProdutosListaDeCompras",
                table: "ProdutosListaDeCompras",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosListaDeCompras_ProdutoId",
                table: "ProdutosListaDeCompras",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProdutosListaDeCompras",
                table: "ProdutosListaDeCompras");

            migrationBuilder.DropIndex(
                name: "IX_ProdutosListaDeCompras_ProdutoId",
                table: "ProdutosListaDeCompras");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProdutosListaDeCompras");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProdutosListaDeCompras",
                table: "ProdutosListaDeCompras",
                columns: new[] { "ProdutoId", "ListaDeComprasEmail" });
        }
    }
}
