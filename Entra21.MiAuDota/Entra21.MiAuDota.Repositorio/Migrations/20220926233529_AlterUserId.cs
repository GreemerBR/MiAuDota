using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class AlterUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_animais_usuarios_usuario_id",
                table: "animais");

            migrationBuilder.AlterColumn<int>(
                name: "usuario_id",
                table: "animais",
                type: "INT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AddForeignKey(
                name: "FK_animais_usuarios_usuario_id",
                table: "animais",
                column: "usuario_id",
                principalTable: "usuarios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_animais_usuarios_usuario_id",
                table: "animais");

            migrationBuilder.AlterColumn<int>(
                name: "usuario_id",
                table: "animais",
                type: "INT",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_animais_usuarios_usuario_id",
                table: "animais",
                column: "usuario_id",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
