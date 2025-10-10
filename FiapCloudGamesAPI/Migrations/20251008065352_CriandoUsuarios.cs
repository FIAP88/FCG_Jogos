using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FCG_API_Jogos.Migrations
{
    /// <inheritdoc />
    public partial class CriandoUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Apelido", "DataNascimento", "Email", "Nome", "Sobrenome" },
                values: new object[] { "alice02", new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice02@email.com", "Alice", "Bezerra" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Apelido", "AtualizadoPor", "CriadoPor", "DataAtualizacao", "DataCriacao", "DataNascimento", "Email", "HashSenha", "Nome", "PerfilId", "Sobrenome" },
                values: new object[,]
                {
                    { 3L, "alice01", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice01@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Alice", 2L, "Silva" },
                    { 4L, "bruno02", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "bruno02@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Bruno", 2L, "Souza" },
                    { 5L, "carla03", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "carla03@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Carla", 2L, "Oliveira" },
                    { 6L, "daniel04", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel04@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Daniel", 2L, "Costa" },
                    { 7L, "eva05", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "eva05@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Eva", 2L, "Martins" },
                    { 8L, "felipe06", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "felipe06@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Felipe", 2L, "Almeida" },
                    { 9L, "gabriela07", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "gabriela07@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Gabriela", 2L, "Pereira" },
                    { 10L, "henrique08", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "henrique08@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Henrique", 2L, "Ribeiro" },
                    { 11L, "isabela09", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "isabela09@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Isabela", 2L, "Fernandes" },
                    { 12L, "joao10", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "joao10@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "João", 2L, "Lima" },
                    { 13L, "karen11", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "karen11@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Karen", 2L, "Barbosa" },
                    { 14L, "leonardo12", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "leonardo12@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Leonardo", 2L, "Moura" },
                    { 15L, "mariana13", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "mariana13@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Mariana", 2L, "Teixeira" },
                    { 16L, "nicolas14", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "nicolas14@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Nicolas", 2L, "Cardoso" },
                    { 17L, "olivia15", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "olivia15@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Olivia", 2L, "Azevedo" },
                    { 18L, "pedro16", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "pedro16@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Pedro", 2L, "Santos" },
                    { 19L, "quintina17", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "quintina17@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Quintina", 2L, "Faria" },
                    { 20L, "rafael18", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "rafael18@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Rafael", 2L, "Mendes" },
                    { 21L, "sofia19", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "sofia19@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Sofia", 2L, "Cunha" },
                    { 22L, "thiago20", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "thiago20@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Thiago", 2L, "Lopes" },
                    { 23L, "ursula21", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ursula21@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Úrsula", 2L, "Gomes" },
                    { 24L, "vinicius22", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "vinicius22@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Vinícius", 2L, "Dias" },
                    { 25L, "wesley23", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "wesley23@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Wesley", 2L, "Rocha" },
                    { 26L, "ximena24", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ximena24@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Ximena", 2L, "Nogueira" },
                    { 27L, "yasmin25", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "yasmin25@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Yasmin", 2L, "Freitas" },
                    { 28L, "zeca26", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeca26@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Zeca", 2L, "Machado" },
                    { 29L, "amanda27", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "amanda27@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Amanda", 2L, "Pinto" },
                    { 30L, "breno28", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "breno28@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Breno", 2L, "Batista" },
                    { 31L, "camila29", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "camila29@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Camila", 2L, "Correia" },
                    { 32L, "diego30", "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "diego30@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", "Diego", 2L, "Rezende" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Apelido", "DataNascimento", "Email", "Nome", "Sobrenome" },
                values: new object[] { "gabriel", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "gabriel@email.com", "Gabriel", "Silva" });
        }
    }
}
