using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class UpdateTableProtetor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "protetores",
                columns: new[] { "Id", "celular", "cnpj", "confirmar_senha", "cpf", "email", "endereco", "facebook", "instagram", "conta_esta_ativa", "nome", "pix", "senha", "sobre", "telefone" },
                values: new object[] { 1, "47988222345", null, "protetor123", "123456789", "greg@grag.com", "Rua Argentina 140", null, "@greg145", true, "Greg", null, "protetor123", null, null });

            migrationBuilder.InsertData(
                table: "protetores",
                columns: new[] { "Id", "celular", "cnpj", "confirmar_senha", "cpf", "email", "endereco", "facebook", "instagram", "conta_esta_ativa", "nome", "pix", "senha", "sobre", "telefone" },
                values: new object[] { 2, "47999222345", null, "protetor123", "123456788", "amanda@amanda.com", "Rua Grécia", null, "@amanda186", true, "Amanda", null, "protetor123", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "protetores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "protetores",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
