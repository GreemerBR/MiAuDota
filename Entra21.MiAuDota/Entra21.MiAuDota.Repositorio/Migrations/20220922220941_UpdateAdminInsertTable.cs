using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class UpdateAdminInsertTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "senha",
                table: "administrador",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8)",
                oldMaxLength: 8);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "senha",
                table: "administrador",
                type: "VARCHAR(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(45)",
                oldMaxLength: 45);
        }
    }
}
