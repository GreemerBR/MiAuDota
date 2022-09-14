using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.MiAuDota.Repositorio.Migrations
{
    public partial class AlteracaoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "status_conta",
                table: "usuarios",
                type: "TINYINT",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "TINYINT");

            migrationBuilder.AlterColumn<string>(
                name: "endereco",
                table: "usuarios",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(45)",
                oldMaxLength: 45);

            migrationBuilder.AlterColumn<bool>(
                name: "eh_voluntario",
                table: "usuarios",
                type: "BIT",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "BIT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "data_nascimento",
                table: "usuarios",
                type: "DATETIME2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "usuarios",
                type: "VARCHAR(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "usuarios",
                type: "VARCHAR(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<byte>(
                name: "status_conta",
                table: "protetores",
                type: "TINYINT",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "TINYINT");

            migrationBuilder.AlterColumn<string>(
                name: "sobre",
                table: "protetores",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "protetores",
                type: "VARCHAR(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldMaxLength: 15);

            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "especialidade",
                value: null);

            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "especialidade",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "status_conta",
                table: "usuarios",
                type: "TINYINT",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte),
                oldType: "TINYINT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "endereco",
                table: "usuarios",
                type: "VARCHAR(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(45)",
                oldMaxLength: 45,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "eh_voluntario",
                table: "usuarios",
                type: "BIT",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "BIT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "data_nascimento",
                table: "usuarios",
                type: "DATETIME2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "usuarios",
                type: "VARCHAR(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "usuarios",
                type: "VARCHAR(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "status_conta",
                table: "protetores",
                type: "TINYINT",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte),
                oldType: "TINYINT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "sobre",
                table: "protetores",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "especialidade",
                value: "Salto em distância");

            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "especialidade",
                value: "Corrida");
        }
    }
}
