using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class AlteradoTabelaAnimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "animais",
                keyColumn: "Id",
                keyValue: 1,
                column: "idade",
                value: (byte)1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "animais",
                keyColumn: "Id",
                keyValue: 1,
                column: "idade",
                value: 1);
        }
    }
}
