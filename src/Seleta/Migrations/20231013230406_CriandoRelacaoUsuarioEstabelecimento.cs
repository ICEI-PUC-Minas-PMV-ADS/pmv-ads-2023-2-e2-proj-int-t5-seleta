using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seleta.Migrations
{
    public partial class CriandoRelacaoUsuarioEstabelecimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioCPF",
                table: "Estabelecimentos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Estabelecimentos_UsuarioCPF",
                table: "Estabelecimentos",
                column: "UsuarioCPF");

            migrationBuilder.AddForeignKey(
                name: "FK_Estabelecimentos_Usuarios_UsuarioCPF",
                table: "Estabelecimentos",
                column: "UsuarioCPF",
                principalTable: "Usuarios",
                principalColumn: "CPF",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estabelecimentos_Usuarios_UsuarioCPF",
                table: "Estabelecimentos");

            migrationBuilder.DropIndex(
                name: "IX_Estabelecimentos_UsuarioCPF",
                table: "Estabelecimentos");

            migrationBuilder.DropColumn(
                name: "UsuarioCPF",
                table: "Estabelecimentos");
        }
    }
}
