using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiapCloudGamesAPI.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Log",
                table: "Log");

            migrationBuilder.RenameTable(
                name: "Log",
                newName: "Logs");

            migrationBuilder.AddColumn<long>(
                name: "PagamentoId",
                table: "JogoUsuario",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "NumeroVendas",
                table: "Jogo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Jogo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mensagem",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(500)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Logs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Logs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CriadoPor",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.AlterColumn<string>(
                name: "AtualizadoPor",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Logs",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "BIGINT")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logs",
                table: "Logs",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "NumeroVendas", "Tags" },
                values: new object[] { 0, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Logs",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "PagamentoId",
                table: "JogoUsuario");

            migrationBuilder.DropColumn(
                name: "NumeroVendas",
                table: "Jogo");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Jogo");

            migrationBuilder.RenameTable(
                name: "Logs",
                newName: "Log");

            migrationBuilder.AlterColumn<string>(
                name: "Mensagem",
                table: "Log",
                type: "VARCHAR(500)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Log",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Log",
                type: "DATETIME2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CriadoPor",
                table: "Log",
                type: "VARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AtualizadoPor",
                table: "Log",
                type: "VARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Log",
                type: "BIGINT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Log",
                table: "Log",
                column: "Id");
        }
    }
}
