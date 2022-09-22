using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class AdicionandoTabelaAdministrador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "animais",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "protetores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "protetores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "status_conta",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "status_conta",
                table: "protetores");

            migrationBuilder.RenameColumn(
                name: "eh_usuario",
                table: "usuarios",
                newName: "conta_esta_ativa");

            migrationBuilder.RenameColumn(
                name: "eh_protetor",
                table: "protetores",
                newName: "conta_esta_ativa");

            migrationBuilder.AlterColumn<bool>(
                name: "eh_voluntario",
                table: "usuarios",
                type: "BIT",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "BIT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "administrador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    senha = table.Column<string>(type: "VARCHAR(8)", maxLength: 8, nullable: false),
                    nome = table.Column<string>(type: "VARCHAR(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administrador", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "administrador",
                columns: new[] { "Id", "email", "nome", "senha" },
                values: new object[] { 1, "admin@admin.com", "Administrador", "admin123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administrador");

            migrationBuilder.RenameColumn(
                name: "conta_esta_ativa",
                table: "usuarios",
                newName: "eh_usuario");

            migrationBuilder.RenameColumn(
                name: "conta_esta_ativa",
                table: "protetores",
                newName: "eh_protetor");

            migrationBuilder.AlterColumn<bool>(
                name: "eh_voluntario",
                table: "usuarios",
                type: "BIT",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "BIT");

            migrationBuilder.AddColumn<byte>(
                name: "status_conta",
                table: "usuarios",
                type: "TINYINT",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "status_conta",
                table: "protetores",
                type: "TINYINT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "protetores",
                columns: new[] { "Id", "celular", "cnpf", "confirmar_senha", "cpf", "eh_protetor", "email", "endereco", "facebook", "instagram", "nome", "pix", "senha", "sobre", "status_conta", "telefone" },
                values: new object[,]
                {
                    { 1, "47 99999-1246", null, "123123123", "123.123.123-00", false, "greg@gmail.com", "Rua tãnãnã", null, null, "Greg", null, "123123123", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", (byte)0, null },
                    { 2, "47 98895-1246", null, "156156156", "186.123.892-00", false, "douh@gmail.com", "Rua São Paulo", null, null, "DOug", null, "156156156", "Printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", (byte)0, null }
                });

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "Id", "celular", "confirmar_senha", "cpf", "data_nascimento", "eh_usuario", "eh_voluntario", "email", "endereco", "especialidade", "nome", "senha", "status_conta" },
                values: new object[,]
                {
                    { 1, "47 99888-1246", "123123123", "145.889.265-00", new DateTime(1992, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "ana@gmail.com", "Rua tal", null, "Ana", "123123123", (byte)0 },
                    { 2, "47 98865-1246", "123123123", "189.456.789-00", new DateTime(1993, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "amanda@gmail.com", "Rua alt", null, "Amanda", "123123123", (byte)0 }
                });

            migrationBuilder.InsertData(
                table: "animais",
                columns: new[] { "Id", "alergias", "altura", "cadastro", "data_adocao", "especie", "caminho_arquivo", "genero", "idade", "nome", "outras_infos_medicas", "peso", "protetor_id", "raca", "sobre", "status", "usuario_id", "vacinas" },
                values: new object[] { 1, "nenhuma", 0.7m, true, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cão", "8BE47EBF-0F7A-455F-B4DB-58001DD9D577.jpg", (byte)1, (byte)1, "bob", null, 2.3m, 1, "Pastor", "bonito", (byte)2, 1, "Gripe" });
        }
    }
}
