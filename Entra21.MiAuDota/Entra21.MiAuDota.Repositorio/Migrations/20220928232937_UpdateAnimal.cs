using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class UpdateAnimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "animais",
                columns: new[] { "Id", "alergias", "altura", "cadastro", "data_adocao", "especie", "caminho_arquivo", "genero", "idade", "nome", "outras_infos_medicas", "peso", "protetor_id", "raca", "sobre", "status", "usuario_id", "vacinas" },
                values: new object[,]
                {
                    { 1, "Nehuma", 0.6m, false, null, "Cachorro", "8BE47EBF-0F7A-455F-B4DB-58001DD9D577.jpg", (byte)1, (byte)1, "Tobias", null, 3.35m, 1, "Colie", "Cão bravo", (byte)0, null, "Nenhuma" },
                    { 2, "Nehuma", 0.5m, true, null, "Cachorro", "8BE47EBF-0F7A-455F-B4DB-58001DD9D577.jpg", (byte)1, (byte)3, "Andre", null, 6.35m, 2, "Pitbull", "Cão dócil", (byte)0, null, "Nenhuma" },
                    { 3, "Nehuma", 0.9m, true, null, "Cachorro", "8BE47EBF-0F7A-455F-B4DB-58001DD9D577.jpg", (byte)1, (byte)6, "Pretinho", null, 7.35m, 1, "rottweiler ", "Cão legal", (byte)0, null, "todas" },
                    { 4, "Nehuma", 0.2m, true, null, "Cachorro", "8BE47EBF-0F7A-455F-B4DB-58001DD9D577.jpg", (byte)0, (byte)13, "Branquinha", null, 1.35m, 2, "Dogue ", "Cão", (byte)0, null, "todas" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "animais",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "animais",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "animais",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "animais",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
