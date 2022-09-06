using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class AdicionarUsuarioTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "protetores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpf = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: true),
                    cnpf = table.Column<string>(type: "VARCHAR(18)", maxLength: 18, nullable: true),
                    endereco = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false),
                    celular = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    telefone = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: true),
                    email = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false),
                    senha = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false),
                    pix = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: true),
                    sobre = table.Column<string>(type: "TEXT", nullable: false),
                    instagram = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: true),
                    facebook = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: true),
                    ehprotetor = table.Column<bool>(type: "BIT", nullable: false),
                    status_conta = table.Column<byte>(type: "TINYINT", nullable: false),
                    nome = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_protetores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    endereco = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false),
                    celular = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    email = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false),
                    cpf = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    especialidade = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: true),
                    eh_voluntario = table.Column<bool>(type: "BIT", nullable: false),
                    eh_usuario = table.Column<bool>(type: "BIT", nullable: false),
                    data_nascimento = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    status_conta = table.Column<byte>(type: "TINYINT", nullable: false),
                    nome = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "animais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    raca = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false),
                    especie = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false),
                    sobre = table.Column<string>(type: "TEXT", nullable: false),
                    vacinas = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false),
                    alergias = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false),
                    outras_infos_medicas = table.Column<string>(type: "TEXT", nullable: true),
                    caminho_arquivo = table.Column<string>(type: "VARCHAR(300)", maxLength: 300, nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    peso = table.Column<decimal>(type: "DECIMAL(5,2)", precision: 5, scale: 2, nullable: false),
                    altura = table.Column<decimal>(type: "DECIMAL(3,2)", precision: 3, scale: 2, nullable: false),
                    cadastro = table.Column<bool>(type: "BIT", nullable: false),
                    data_adocao = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    genero = table.Column<byte>(type: "TINYINT", nullable: false),
                    status = table.Column<byte>(type: "TINYINT", nullable: false),
                    protetor_id = table.Column<int>(type: "INT", nullable: false),
                    usuario_id = table.Column<int>(type: "INT", nullable: false),
                    nome = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_animais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_animais_protetores_protetor_id",
                        column: x => x.protetor_id,
                        principalTable: "protetores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_animais_usuarios_usuario_id",
                        column: x => x.usuario_id,
                        principalTable: "usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "protetores",
                columns: new[] { "Id", "celular", "cnpf", "cpf", "ehprotetor", "email", "endereco", "facebook", "instagram", "nome", "pix", "senha", "sobre", "status_conta", "telefone" },
                values: new object[,]
                {
                    { 1, "47 99999-1246", null, "123.123.123-00", false, "greg@gmail.com", "Rua tãnãnã", null, null, "Greg", null, "123123123", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", (byte)0, null },
                    { 2, "47 98895-1246", null, "186.123.892-00", false, "douh@gmail.com", "Rua São Paulo", null, null, "DOug", null, "156156156", "Printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", (byte)0, null }
                });

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "Id", "celular", "cpf", "data_nascimento", "eh_usuario", "eh_voluntario", "email", "endereco", "especialidade", "nome", "status_conta" },
                values: new object[,]
                {
                    { 1, "47 99888-1246", "145.889.265-00", new DateTime(1992, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "ana@gmail.com", "Rua tal", "Salto em distância", "Ana", (byte)0 },
                    { 2, "47 98865-1246", "189.456.789-00", new DateTime(1993, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "amanda@gmail.com", "Rua alt", "Corrida", "Amanda", (byte)0 }
                });

            migrationBuilder.InsertData(
                table: "animais",
                columns: new[] { "Id", "alergias", "altura", "cadastro", "data_adocao", "especie", "caminho_arquivo", "genero", "Idade", "nome", "outras_infos_medicas", "peso", "protetor_id", "raca", "sobre", "status", "usuario_id", "vacinas" },
                values: new object[] { 1, "nenhuma", 0.7m, true, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cão", "8BE47EBF-0F7A-455F-B4DB-58001DD9D577.jpg", (byte)1, 1, "bob", null, 2.3m, 1, "Pastor", "bonito", (byte)2, 1, "Gripe" });

            migrationBuilder.CreateIndex(
                name: "IX_animais_protetor_id",
                table: "animais",
                column: "protetor_id");

            migrationBuilder.CreateIndex(
                name: "IX_animais_usuario_id",
                table: "animais",
                column: "usuario_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "animais");

            migrationBuilder.DropTable(
                name: "protetores");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
