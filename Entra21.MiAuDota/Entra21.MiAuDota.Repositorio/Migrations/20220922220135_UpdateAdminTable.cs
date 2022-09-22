using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class UpdateAdminTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "administrador",
                keyColumn: "Id",
                keyValue: 1,
                column: "senha",
                value: "0192023A7BBD73250516F069DF18B500");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "administrador",
                keyColumn: "Id",
                keyValue: 1,
                column: "senha",
                value: "admin123");
        }
    }
}
