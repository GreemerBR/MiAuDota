using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class AdicionarProtetoresTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ehprotetor",
                table: "protetores",
                newName: "eh_protetor");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "animais",
                newName: "idade");

            migrationBuilder.AddColumn<string>(
                name: "confirmar_senha",
                table: "usuarios",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "senha",
                table: "usuarios",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "confirmar_senha",
                table: "protetores",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "idade",
                table: "animais",
                type: "TINYINT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "protetores",
                keyColumn: "Id",
                keyValue: 1,
                column: "confirmar_senha",
                value: "123123123");

            migrationBuilder.UpdateData(
                table: "protetores",
                keyColumn: "Id",
                keyValue: 2,
                column: "confirmar_senha",
                value: "156156156");

            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "confirmar_senha", "senha" },
                values: new object[] { "123123123", "123123123" });

            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "confirmar_senha", "senha" },
                values: new object[] { "123123123", "123123123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "confirmar_senha",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "senha",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "confirmar_senha",
                table: "protetores");

            migrationBuilder.RenameColumn(
                name: "eh_protetor",
                table: "protetores",
                newName: "ehprotetor");

            migrationBuilder.RenameColumn(
                name: "idade",
                table: "animais",
                newName: "Idade");

            migrationBuilder.AlterColumn<int>(
                name: "Idade",
                table: "animais",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "TINYINT");
        }
    }
}
