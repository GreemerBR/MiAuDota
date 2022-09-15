using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class AlterProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "endereco",
                table: "protetores",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(45)",
                oldMaxLength: 45);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "endereco",
                table: "protetores",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(45)",
                oldMaxLength: 45,
                oldNullable: true);
        }
    }
}
