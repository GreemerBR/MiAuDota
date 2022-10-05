using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class AlterTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "porte",
                table: "animais",
                type: "TINYINT",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "porte",
                table: "animais");
        }
    }
}
