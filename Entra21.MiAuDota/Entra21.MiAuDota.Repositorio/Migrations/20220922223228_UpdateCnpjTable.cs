using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class UpdateCnpjTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cnpf",
                table: "protetores",
                newName: "cnpj");

            migrationBuilder.AlterColumn<string>(
                name: "senha",
                table: "administrador",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(45)",
                oldMaxLength: 45);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cnpj",
                table: "protetores",
                newName: "cnpf");

            migrationBuilder.AlterColumn<string>(
                name: "senha",
                table: "administrador",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50);
        }
    }
}
