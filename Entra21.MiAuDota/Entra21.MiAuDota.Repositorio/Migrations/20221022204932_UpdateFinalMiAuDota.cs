using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class UpdateFinalMiAuDota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "protetores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "protetores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "sobre",
                table: "protetores");

            migrationBuilder.DropColumn(
                name: "alergias",
                table: "animais");

            migrationBuilder.DropColumn(
                name: "outras_infos_medicas",
                table: "animais");

            migrationBuilder.DropColumn(
                name: "vacinas",
                table: "animais");

            migrationBuilder.RenameColumn(
                name: "cadastro",
                table: "animais",
                newName: "castrado");

            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "protetores",
                type: "VARCHAR(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "raca",
                table: "animais",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(45)",
                oldMaxLength: 45);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "animais",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(45)",
                oldMaxLength: 45);

            migrationBuilder.AlterColumn<byte>(
                name: "especie",
                table: "animais",
                type: "TINYINT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(45)",
                oldMaxLength: 45);

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_cpf",
                table: "usuarios",
                column: "cpf",
                unique: true,
                filter: "[cpf] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_email",
                table: "usuarios",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_protetores_cnpj",
                table: "protetores",
                column: "cnpj",
                unique: true,
                filter: "[cnpj] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_protetores_cpf",
                table: "protetores",
                column: "cpf",
                unique: true,
                filter: "[cpf] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_protetores_email",
                table: "protetores",
                column: "email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_usuarios_cpf",
                table: "usuarios");

            migrationBuilder.DropIndex(
                name: "IX_usuarios_email",
                table: "usuarios");

            migrationBuilder.DropIndex(
                name: "IX_protetores_cnpj",
                table: "protetores");

            migrationBuilder.DropIndex(
                name: "IX_protetores_cpf",
                table: "protetores");

            migrationBuilder.DropIndex(
                name: "IX_protetores_email",
                table: "protetores");

            migrationBuilder.RenameColumn(
                name: "castrado",
                table: "animais",
                newName: "cadastro");

            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "protetores",
                type: "VARCHAR(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<string>(
                name: "sobre",
                table: "protetores",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "raca",
                table: "animais",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "animais",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "especie",
                table: "animais",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "TINYINT");

            migrationBuilder.AddColumn<string>(
                name: "alergias",
                table: "animais",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "outras_infos_medicas",
                table: "animais",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "vacinas",
                table: "animais",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "protetores",
                columns: new[] { "Id", "celular", "cnpj", "confirmar_senha", "cpf", "email", "endereco", "facebook", "instagram", "conta_esta_ativa", "nome", "pix", "senha", "sobre", "telefone" },
                values: new object[] { 1, "47988222345", null, "protetor123", "123456789", "greg@grag.com", "Rua Argentina 140", null, "@greg145", true, "Greg", null, "protetor123", null, null });

            migrationBuilder.InsertData(
                table: "protetores",
                columns: new[] { "Id", "celular", "cnpj", "confirmar_senha", "cpf", "email", "endereco", "facebook", "instagram", "conta_esta_ativa", "nome", "pix", "senha", "sobre", "telefone" },
                values: new object[] { 2, "47999222345", null, "protetor123", "123456788", "amanda@amanda.com", "Rua Grécia", null, "@amanda186", true, "Amanda", null, "protetor123", null, null });

            migrationBuilder.InsertData(
                table: "animais",
                columns: new[] { "Id", "alergias", "altura", "cadastro", "data_adocao", "especie", "caminho_arquivo", "genero", "idade", "nome", "outras_infos_medicas", "peso", "porte", "protetor_id", "raca", "sobre", "status", "usuario_id", "vacinas" },
                values: new object[,]
                {
                    { 1, "Nehuma", 0.6m, false, null, "Cachorro", "8BE47EBF-0F7A-455F-B4DB-58001DD9D577.jpg", (byte)1, (byte)1, "Tobias", null, 3.35m, (byte)0, 1, "Colie", "Cão bravo", (byte)0, null, "Nenhuma" },
                    { 2, "Nehuma", 0.5m, true, null, "Cachorro", "8BE47EBF-0F7A-455F-B4DB-58001DD9D577.jpg", (byte)1, (byte)3, "Andre", null, 6.35m, (byte)0, 2, "Pitbull", "Cão dócil", (byte)0, null, "Nenhuma" },
                    { 3, "Nehuma", 0.9m, true, null, "Cachorro", "8BE47EBF-0F7A-455F-B4DB-58001DD9D577.jpg", (byte)1, (byte)6, "Pretinho", null, 7.35m, (byte)0, 1, "rottweiler ", "Cão legal", (byte)0, null, "todas" },
                    { 4, "Nehuma", 0.2m, true, null, "Cachorro", "8BE47EBF-0F7A-455F-B4DB-58001DD9D577.jpg", (byte)0, (byte)13, "Branquinha", null, 1.35m, (byte)0, 2, "Dogue ", "Cão", (byte)0, null, "todas" }
                });
        }
    }
}
