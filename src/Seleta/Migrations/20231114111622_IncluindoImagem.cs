using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seleta.Migrations
{
    public partial class IncluindoImagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Estabelecimentos_CnpjEstabelecimento",
                table: "Produtos");

            migrationBuilder.AlterColumn<string>(
                name: "CnpjEstabelecimento",
                table: "Produtos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagem",
                table: "Produtos",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoImagem",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Estabelecimentos_CnpjEstabelecimento",
                table: "Produtos",
                column: "CnpjEstabelecimento",
                principalTable: "Estabelecimentos",
                principalColumn: "Cnpj");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Estabelecimentos_CnpjEstabelecimento",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "TipoImagem",
                table: "Produtos");

            migrationBuilder.AlterColumn<string>(
                name: "CnpjEstabelecimento",
                table: "Produtos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Estabelecimentos_CnpjEstabelecimento",
                table: "Produtos",
                column: "CnpjEstabelecimento",
                principalTable: "Estabelecimentos",
                principalColumn: "Cnpj",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
