using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seleta.Migrations
{
    public partial class AjustandoVariaveisProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Estabelecimentos_CnpjEstabelecimento",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosListaDeCompras_ListaDeCompras_ListaDeComprasEmail",
                table: "ProdutosListaDeCompras");

            migrationBuilder.AlterColumn<string>(
                name: "ListaDeComprasEmail",
                table: "ProdutosListaDeCompras",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "QuantidadePeso",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Preco",
                table: "Produtos",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Estabelecimentos_CnpjEstabelecimento",
                table: "Produtos",
                column: "CnpjEstabelecimento",
                principalTable: "Estabelecimentos",
                principalColumn: "Cnpj");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosListaDeCompras_ListaDeCompras_ListaDeComprasEmail",
                table: "ProdutosListaDeCompras",
                column: "ListaDeComprasEmail",
                principalTable: "ListaDeCompras",
                principalColumn: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Estabelecimentos_CnpjEstabelecimento",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosListaDeCompras_ListaDeCompras_ListaDeComprasEmail",
                table: "ProdutosListaDeCompras");

            migrationBuilder.AlterColumn<string>(
                name: "ListaDeComprasEmail",
                table: "ProdutosListaDeCompras",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QuantidadePeso",
                table: "Produtos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Preco",
                table: "Produtos",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Estabelecimentos_CnpjEstabelecimento",
                table: "Produtos",
                column: "CnpjEstabelecimento",
                principalTable: "Estabelecimentos",
                principalColumn: "Cnpj",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosListaDeCompras_ListaDeCompras_ListaDeComprasEmail",
                table: "ProdutosListaDeCompras",
                column: "ListaDeComprasEmail",
                principalTable: "ListaDeCompras",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
