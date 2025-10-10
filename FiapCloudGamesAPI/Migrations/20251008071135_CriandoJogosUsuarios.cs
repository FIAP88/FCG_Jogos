using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FCG_API_Jogos.Migrations
{
    /// <inheritdoc />
    public partial class CriandoJogosUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "JogoUsuario",
                columns: new[] { "JogoId", "UsuarioId", "PagamentoId" },
                values: new object[,]
                {
                    { 6L, 1L, new Guid("b221c55b-ca6c-4286-8cc9-dd74e321881a") },
                    { 9L, 1L, new Guid("433238d8-17fe-43b3-acba-52eb7b724326") },
                    { 13L, 1L, new Guid("acc030cb-0e2f-4094-931d-edfb7d20cf76") },
                    { 31L, 1L, new Guid("5c756f56-a43b-430a-9238-c894109d2368") },
                    { 33L, 1L, new Guid("01c04456-b7a1-49ab-bb11-3092ca03b46c") },
                    { 42L, 1L, new Guid("3932fa0f-45c7-43a2-a297-c052bb1599ec") },
                    { 43L, 1L, new Guid("6000d788-3aa4-4088-9c0e-2b1226da1609") },
                    { 45L, 1L, new Guid("bb2fc7ef-398f-4476-a28c-490ac998f307") },
                    { 57L, 1L, new Guid("4eef6aec-f26d-43ab-b6d8-441709b5f56d") },
                    { 58L, 1L, new Guid("a35a79fa-d8c6-4751-9cb0-88268b604e33") },
                    { 60L, 1L, new Guid("ce9ac2b1-5993-4f33-936a-142db0683d83") },
                    { 61L, 1L, new Guid("51e9faab-e425-4b72-b616-624d27f4943f") },
                    { 76L, 1L, new Guid("c813c7f2-b44e-448a-bf30-31c204e49205") },
                    { 77L, 1L, new Guid("a5dbcc38-6e62-424c-a177-116c9fa01c64") },
                    { 84L, 1L, new Guid("e04a6708-0d2c-4e72-b6a0-25e662a1de23") },
                    { 88L, 1L, new Guid("1db1b64c-70e9-4a0f-9d0a-9e0a95d906fd") },
                    { 91L, 1L, new Guid("9da77c9d-ba1b-4eb0-82ef-dbdf4cafbfa2") },
                    { 92L, 1L, new Guid("6077bd42-c146-49dc-bcf7-896b63e5b549") },
                    { 94L, 1L, new Guid("77cc7430-d9ce-4683-823e-b171cc2c2e84") },
                    { 100L, 1L, new Guid("82ed6107-0f96-42dc-a48c-53ffa31d657e") },
                    { 1L, 2L, new Guid("e9ec2158-2ae9-4ae1-83d0-202cf51d24ad") },
                    { 4L, 2L, new Guid("9bb3224b-a901-4c32-a1e4-148e5e9b8a92") },
                    { 14L, 2L, new Guid("bdd98bc5-dd50-41ce-8e61-7107702dad3e") },
                    { 21L, 2L, new Guid("673877bb-2271-441a-8a15-928838a75995") },
                    { 31L, 2L, new Guid("47d8b7cf-7e08-4928-a9d5-d6a1fb46540e") },
                    { 33L, 2L, new Guid("7f6037c6-ef87-4a9e-a7b6-6bcfce96f19b") },
                    { 34L, 2L, new Guid("e63fd048-785b-48d6-a527-a73e5e68f3bb") },
                    { 45L, 2L, new Guid("8e9ada74-c70f-453b-a827-6c7a04008547") },
                    { 51L, 2L, new Guid("17bf1443-6203-4d5a-9f4c-157932bb5425") },
                    { 52L, 2L, new Guid("4d8e7518-6fda-41c5-a157-681f55cd0869") },
                    { 60L, 2L, new Guid("2780af1e-09fc-427a-af79-91fb824f4e94") },
                    { 64L, 2L, new Guid("b9b83010-2cf0-4996-a97d-6245eebd64da") },
                    { 65L, 2L, new Guid("83549027-449a-4064-8b5d-74e56b776006") },
                    { 68L, 2L, new Guid("67902f90-3afa-4607-924a-594ab47e8da5") },
                    { 72L, 2L, new Guid("c612a80b-9993-46fa-9e10-e36d332219cb") },
                    { 76L, 2L, new Guid("491c3fda-5df9-43d8-9203-e79c389a9e94") },
                    { 78L, 2L, new Guid("4e247b54-695d-426e-b2ce-5dbfafb098ff") },
                    { 83L, 2L, new Guid("05e0038a-2887-4774-9e17-f17cc626ca3a") },
                    { 89L, 2L, new Guid("bf03913c-6a1c-4233-968f-f2c2fea29f75") },
                    { 99L, 2L, new Guid("c9671f1e-f51a-46a4-9002-cd359841106c") },
                    { 1L, 3L, new Guid("c7cd100f-15f0-4d6f-bee3-b5077e3b4081") },
                    { 6L, 3L, new Guid("1e7d73f8-04b6-4ebf-94b0-408c1e94148d") },
                    { 9L, 3L, new Guid("8eb2508d-17d2-4c43-884d-5ebcea7b17e1") },
                    { 10L, 3L, new Guid("732a1ff2-3785-4905-8b13-1cb0d84e30fa") },
                    { 11L, 3L, new Guid("e2e29385-a87b-430a-86c6-d196e61cab3a") },
                    { 25L, 3L, new Guid("8db44f91-5491-4e63-b074-25dd658fbe12") },
                    { 31L, 3L, new Guid("390d6c49-6cb4-4517-b552-f0be4be14a89") },
                    { 32L, 3L, new Guid("797ae5ca-a426-4d3d-90d6-7ee95c00d6ce") },
                    { 33L, 3L, new Guid("791a9988-446c-4050-ab8b-9bf494fc7be5") },
                    { 34L, 3L, new Guid("1b4340e3-6ce9-40de-87a1-a135d81682ed") },
                    { 38L, 3L, new Guid("771f5cf1-0cb1-4887-b817-f27095112c3f") },
                    { 50L, 3L, new Guid("81ecc7a9-dae9-4022-974b-2e83999be134") },
                    { 51L, 3L, new Guid("6e63740d-0869-4bbd-8bf3-3fd7e5dd323e") },
                    { 56L, 3L, new Guid("e4006469-83f2-4d20-814f-aa284270e3a8") },
                    { 67L, 3L, new Guid("cd192769-48a5-4999-bb98-8c98db1cc55a") },
                    { 71L, 3L, new Guid("ffe884aa-1fc8-46eb-81ee-87e2e5d865fe") },
                    { 79L, 3L, new Guid("c7352fb8-c75b-45a2-b05c-40ae70043e20") },
                    { 93L, 3L, new Guid("1ef51f72-92ca-4a70-9b78-76207b78e200") },
                    { 96L, 3L, new Guid("e25268a9-f421-4ee9-956d-a53996797628") },
                    { 99L, 3L, new Guid("9fd203e0-7b58-4fb4-a80a-c963f4226dd9") },
                    { 1L, 4L, new Guid("812be1db-4789-42b7-ac21-2ed8bc01545f") },
                    { 8L, 4L, new Guid("50da9f48-f314-4a12-ad37-66383be97cb3") },
                    { 10L, 4L, new Guid("cbc70345-5cdf-4690-b4de-d456a2d2d2c1") },
                    { 16L, 4L, new Guid("598d10a0-9c5a-4a6e-8b03-0dac2434c084") },
                    { 26L, 4L, new Guid("e044e6f4-2c72-402a-9db5-8f59e009dfaf") },
                    { 30L, 4L, new Guid("cf819706-76e7-433e-bf22-a6c052b30551") },
                    { 37L, 4L, new Guid("b83d72f7-e349-43aa-bc95-0e9af1e3caf9") },
                    { 43L, 4L, new Guid("cf16aeb0-2167-43f1-9f55-a896835d4651") },
                    { 47L, 4L, new Guid("905b987e-c372-4dd8-ac21-e5b59612a503") },
                    { 53L, 4L, new Guid("9885d523-6c23-4970-81f6-449d83356171") },
                    { 57L, 4L, new Guid("dc78b55c-591f-411a-bc3e-1a89ac96c62a") },
                    { 64L, 4L, new Guid("4871eb3a-c0b3-46a0-8348-7e54013b4bcf") },
                    { 73L, 4L, new Guid("4fee3604-59d0-4bb0-bea2-e043208d5d34") },
                    { 78L, 4L, new Guid("976a569d-c7e7-4439-bb9b-f922202f1490") },
                    { 86L, 4L, new Guid("872efd35-5a2d-44a2-a85e-a2bb2ccc7466") },
                    { 87L, 4L, new Guid("f565a7c4-695b-4a5a-80ff-7ca8cf359f3e") },
                    { 89L, 4L, new Guid("e87f4cd4-6478-49ba-ac58-e7c12c084983") },
                    { 91L, 4L, new Guid("2c389908-dbc8-4822-91fa-8bff75d692df") },
                    { 95L, 4L, new Guid("6e50455f-87ff-45d6-8d19-d718e0fa07ab") },
                    { 100L, 4L, new Guid("e0437ac8-36b2-46ee-905a-d74630ab86ce") },
                    { 5L, 5L, new Guid("689d948a-fb31-4946-be9d-f49e63557e64") },
                    { 8L, 5L, new Guid("50de7336-bc21-404c-b0ce-ddfdcb40fcc9") },
                    { 13L, 5L, new Guid("049961df-9352-4ffa-9a1c-58b4ed29812c") },
                    { 15L, 5L, new Guid("50bcc2ab-b990-4946-81c9-477494691924") },
                    { 19L, 5L, new Guid("5acb8fc2-a0c8-4c56-acf3-cbd0041d67b0") },
                    { 26L, 5L, new Guid("d99026a2-f5f0-4337-951a-2908d4cfdf48") },
                    { 35L, 5L, new Guid("26eb149e-209f-4d46-8f46-fff55294cb45") },
                    { 36L, 5L, new Guid("1520ebef-deb5-46f5-b899-2eeaed259581") },
                    { 37L, 5L, new Guid("279d2389-3d15-4df1-bee3-6574800ee8c1") },
                    { 46L, 5L, new Guid("97296c3e-4bff-4102-b1fa-46236b560651") },
                    { 47L, 5L, new Guid("32ff9300-8a93-4777-b341-d2a0d0dbe651") },
                    { 60L, 5L, new Guid("4a209cbb-9766-434e-bb16-cd5c2d60934c") },
                    { 65L, 5L, new Guid("d5e89362-4da0-40a2-9935-200505fd9936") },
                    { 67L, 5L, new Guid("ed42a18a-c9c5-42fb-8965-e3a544e142e6") },
                    { 68L, 5L, new Guid("6e437ac4-0219-4375-835c-79b99d99132b") },
                    { 75L, 5L, new Guid("956cfd87-e4a2-4f5a-a273-f5995bb80f30") },
                    { 80L, 5L, new Guid("2d4c3b9d-81ae-4960-be0a-918d717292fd") },
                    { 84L, 5L, new Guid("2cc3f3d3-d707-4214-8ea0-4b3a8c6c5b53") },
                    { 91L, 5L, new Guid("3ce8722b-3ef5-4e5a-bf58-238b9ff65e02") },
                    { 94L, 5L, new Guid("b2a4e7c3-4a03-4220-8f5a-88a69de8891a") },
                    { 1L, 6L, new Guid("e71e93ec-0c3b-4f9a-a013-e434d8f50a31") },
                    { 15L, 6L, new Guid("9cc31878-6b8a-48e2-8b13-1f6026f3e0c9") },
                    { 17L, 6L, new Guid("42a2df4e-d41f-4e73-80fc-67c2f78e726b") },
                    { 18L, 6L, new Guid("f04768c8-7fe9-493c-8473-37dfcbbf2f02") },
                    { 19L, 6L, new Guid("c79c5d4e-1b43-4563-8281-5432b6666160") },
                    { 21L, 6L, new Guid("26e5d0f9-0f78-466b-bfc6-54f89000964b") },
                    { 31L, 6L, new Guid("8d21b17b-d91e-40bf-9164-d60c1d748855") },
                    { 36L, 6L, new Guid("3d04f978-54f4-49fe-81c7-c33b5492d7fe") },
                    { 38L, 6L, new Guid("81623866-7800-4d47-8430-a6e93f913129") },
                    { 43L, 6L, new Guid("b9e055e7-7caf-4596-95ee-0185d4417607") },
                    { 48L, 6L, new Guid("4136f327-020b-4caf-b4da-f99543ecd9cb") },
                    { 53L, 6L, new Guid("9e37d6cf-5415-4157-a82f-a035e7b9a214") },
                    { 55L, 6L, new Guid("cfbee09f-d726-432e-95f6-e8aefdcc1f89") },
                    { 60L, 6L, new Guid("667aeb1a-f251-4cdb-8af9-598c7e880f17") },
                    { 68L, 6L, new Guid("1330b07f-16f1-4efd-9708-9e23ecbfe6a7") },
                    { 84L, 6L, new Guid("a4a6edbf-be94-4dfb-8712-80ea1db67425") },
                    { 90L, 6L, new Guid("55a2362c-2f1e-4228-b1af-3ed561fd19b2") },
                    { 93L, 6L, new Guid("6d98f02a-562a-4d75-9fef-d15f2ecf41ac") },
                    { 94L, 6L, new Guid("07e2282c-e05b-4a47-b274-009c9781067b") },
                    { 95L, 6L, new Guid("2ca97ca6-5d7e-4394-85e0-8061d633e86f") },
                    { 9L, 7L, new Guid("9a3d9c3a-efc4-48e4-9c22-103f8ab78eca") },
                    { 20L, 7L, new Guid("d2b42bea-5ed5-4980-b5d3-95a822d2ac0b") },
                    { 24L, 7L, new Guid("531678a0-a6db-4fb4-afde-a9f58c017ad1") },
                    { 27L, 7L, new Guid("3c776f4f-fd6f-4fa9-b906-48a3b3eabf70") },
                    { 28L, 7L, new Guid("d14f8fc0-2675-4e68-939b-67dbf7293171") },
                    { 30L, 7L, new Guid("1b16dc68-12d2-4a0e-a262-3ab853fedc42") },
                    { 32L, 7L, new Guid("fd4d08ae-44c4-4c38-a7ab-16cdb56a74cb") },
                    { 37L, 7L, new Guid("75d6a00d-ea17-44e8-adc8-99ad3f609d4a") },
                    { 38L, 7L, new Guid("d9bae3c8-d87f-4dd8-8d9c-33e681f20d7d") },
                    { 39L, 7L, new Guid("be65305c-d468-479f-98fe-8187fb5e8533") },
                    { 45L, 7L, new Guid("cd415778-2c50-41ef-b728-8326119b275c") },
                    { 51L, 7L, new Guid("19b2d6eb-7ac4-43e0-8300-eb1303afc3ab") },
                    { 58L, 7L, new Guid("ebdd4cd9-5d4f-42d0-bec6-23114793022b") },
                    { 61L, 7L, new Guid("ea859557-4f4c-4654-8cbd-97075ef6d679") },
                    { 78L, 7L, new Guid("3ffb5d42-b7ef-4af2-affc-9620b3719f93") },
                    { 84L, 7L, new Guid("e8e1417c-6691-4ee3-ba99-6ed270fc109b") },
                    { 87L, 7L, new Guid("6a2596b4-5ef6-4b88-b037-f2157e9ae2d7") },
                    { 88L, 7L, new Guid("81380684-5aa2-4bb4-8abc-ea1584aeea44") },
                    { 95L, 7L, new Guid("fb284aa5-f126-45d0-b6c5-b2f3f03be113") },
                    { 96L, 7L, new Guid("e8fa25fe-790e-4727-b08e-6712b95d6a63") },
                    { 5L, 8L, new Guid("61a1b535-4d14-4863-8585-4c4a982f5433") },
                    { 8L, 8L, new Guid("964bed7a-fb79-460b-9f78-9ef853fc1013") },
                    { 10L, 8L, new Guid("8d39285c-01ac-4f00-a303-94ab78a8093f") },
                    { 17L, 8L, new Guid("ca5e572a-4b05-46dc-ba29-2bcddc82d077") },
                    { 21L, 8L, new Guid("9f431cf2-e433-4b17-ad15-1c43204b58cd") },
                    { 22L, 8L, new Guid("d966a28d-5e4b-4753-a56a-1bb60888c289") },
                    { 23L, 8L, new Guid("bb669be6-a41b-4360-ae3b-9bf5e4442ea6") },
                    { 24L, 8L, new Guid("b32c8d33-55cd-41d8-8840-0dc717bbeb78") },
                    { 25L, 8L, new Guid("3b786412-4890-4e04-91d1-61fb81ec5971") },
                    { 38L, 8L, new Guid("65cc4090-b34c-48de-9dec-092f0bb8a383") },
                    { 43L, 8L, new Guid("5b205800-e40e-46a6-9bcb-b95ae6df5ad2") },
                    { 47L, 8L, new Guid("a04e0054-847f-40c7-8ce8-55480dc9b227") },
                    { 57L, 8L, new Guid("1580af72-0a2c-4ec5-a80a-0e70a8971728") },
                    { 59L, 8L, new Guid("ba5a870c-5cd8-4cdd-b28c-603ab77cd4d5") },
                    { 61L, 8L, new Guid("2bc54f87-aded-4829-b847-6be2eb09562b") },
                    { 68L, 8L, new Guid("f8309a66-8376-43be-8f71-b06f7000f534") },
                    { 76L, 8L, new Guid("f0b9379d-365b-49ed-afdf-c0ea1a2dc6e8") },
                    { 83L, 8L, new Guid("cddfbc07-d3e5-4df0-a558-34e2923d065b") },
                    { 86L, 8L, new Guid("8ca26e03-8cb4-489b-a142-63601ed5cd75") },
                    { 90L, 8L, new Guid("31c77a68-0a04-4901-9d3b-ef85ce9ffb46") },
                    { 6L, 9L, new Guid("d653e483-7957-498d-b74b-8805965b7066") },
                    { 19L, 9L, new Guid("19def8ae-d8a0-46f3-9eef-51d4b88be137") },
                    { 32L, 9L, new Guid("f4565780-e74b-492a-9834-ba9ba3c5ad49") },
                    { 38L, 9L, new Guid("b3f3897a-7308-4221-a1fb-2246a62701b9") },
                    { 46L, 9L, new Guid("4fc6c42f-26fc-4233-a439-270b31c0cdce") },
                    { 47L, 9L, new Guid("a0b4ae24-6cae-4266-b05b-9b6581664d5d") },
                    { 52L, 9L, new Guid("2d49a510-0f12-49cf-8645-af7dc4e32fda") },
                    { 57L, 9L, new Guid("fa021888-d56e-4dca-8f7d-e02421135d6b") },
                    { 59L, 9L, new Guid("83c12f8b-f73f-4955-8cca-e5524f50cd9e") },
                    { 61L, 9L, new Guid("1b0c2354-f071-42f9-b00c-8c063f80c666") },
                    { 63L, 9L, new Guid("9cdb3758-e06a-409b-b53e-bf170e5a2a97") },
                    { 65L, 9L, new Guid("19424462-383f-406b-ae88-ff8572eaf45d") },
                    { 70L, 9L, new Guid("a89078c9-5b1f-4ca0-bfef-2aab8b45ec7a") },
                    { 73L, 9L, new Guid("49183788-0d02-4b65-84b1-8abecc4f7587") },
                    { 80L, 9L, new Guid("d403fbbe-27f8-43d3-8fb5-32810c4d8a6d") },
                    { 81L, 9L, new Guid("77514ceb-4ab0-45ba-b0a4-7cf9bd1e9494") },
                    { 82L, 9L, new Guid("4c18c30c-c7ab-4ae2-a4a7-8213dd947c73") },
                    { 92L, 9L, new Guid("fde4c320-cd97-4a19-b518-2713d95bab46") },
                    { 93L, 9L, new Guid("956fc4d0-c96a-4873-ab21-7cdf6061b5c6") },
                    { 99L, 9L, new Guid("eec1052f-9f8e-4bfb-a019-2604a03a77a6") },
                    { 3L, 10L, new Guid("cf6b62f2-7212-469c-809e-a7154145d681") },
                    { 6L, 10L, new Guid("4a7e37b3-e7e6-4497-8913-63c5131a456a") },
                    { 7L, 10L, new Guid("50bd304a-56d4-4aa7-a0bf-d89c8d15c4ca") },
                    { 16L, 10L, new Guid("795df766-330e-45c4-b7dd-b674c08ee3e6") },
                    { 17L, 10L, new Guid("b2b33d00-2645-4644-bf0e-d6cad9380d9d") },
                    { 18L, 10L, new Guid("7d041a3f-9509-4840-aa4f-a1711a1b0de6") },
                    { 31L, 10L, new Guid("aae7a014-9cb8-4837-a33d-73cbb42f1a60") },
                    { 32L, 10L, new Guid("b7c01acb-278e-4560-b64d-a9cde9343e34") },
                    { 34L, 10L, new Guid("60a718e7-7248-494b-bae0-ef39bfa79349") },
                    { 36L, 10L, new Guid("e19d4d95-435c-4e76-942c-eddbd42604d5") },
                    { 37L, 10L, new Guid("c5ee37fd-a372-42cc-903f-fe00920cbbee") },
                    { 47L, 10L, new Guid("65a6edb9-ff85-43f5-90da-de0a0c84b3a8") },
                    { 50L, 10L, new Guid("d184856c-a390-4680-84e3-a3c4eb4f037d") },
                    { 67L, 10L, new Guid("de2a34d4-89ca-4c20-9d9e-14c6acdcd23f") },
                    { 72L, 10L, new Guid("29840732-f5b6-4304-9bd9-a5b66afdceef") },
                    { 77L, 10L, new Guid("e118ab73-69be-401f-996a-18320c4082b5") },
                    { 78L, 10L, new Guid("5bb88e51-776e-48ad-ab3f-0962b681cb18") },
                    { 79L, 10L, new Guid("0b76407d-bbc2-42ef-ae85-c10fa4ac5634") },
                    { 92L, 10L, new Guid("9a4c7070-7b24-440a-bc2a-dc4a7b10c75f") },
                    { 98L, 10L, new Guid("c3d0395b-a426-4a65-baf0-836199388fde") },
                    { 13L, 11L, new Guid("e0bbb3b1-c4d1-437d-b11d-b26cf7ce8df3") },
                    { 15L, 11L, new Guid("8aa6aeae-d02a-4743-9296-3d222c58f71c") },
                    { 21L, 11L, new Guid("2627a559-a6e2-4827-8e2c-53c8ecd66b32") },
                    { 23L, 11L, new Guid("378e6f9d-be8d-4beb-8dcf-6325d4e620e4") },
                    { 25L, 11L, new Guid("aa7bfe82-bf86-40d0-9c02-e5c12aad2208") },
                    { 33L, 11L, new Guid("cfda3c29-def6-4d0d-9c45-0138972d42ad") },
                    { 35L, 11L, new Guid("4520f04e-c553-4ce4-b9ad-891d69f5ca72") },
                    { 43L, 11L, new Guid("d87c9f7c-47b3-457d-93ee-a9f14af89dcc") },
                    { 52L, 11L, new Guid("9bd8d7a0-68fc-4944-a539-67c3c9f1d90d") },
                    { 53L, 11L, new Guid("97bad7e0-1e4c-471f-b50c-70e71dca96b8") },
                    { 57L, 11L, new Guid("251b53d2-7e4b-4990-a011-38bd2633b58c") },
                    { 58L, 11L, new Guid("c843e006-517c-4d6a-8680-e70e1343873c") },
                    { 60L, 11L, new Guid("21872447-0b58-4aae-8ee8-188961a142cd") },
                    { 62L, 11L, new Guid("8475a870-58b5-445b-9c96-4be9d27ca8d1") },
                    { 66L, 11L, new Guid("92196c78-10f8-44d1-b5aa-289a4c8eb112") },
                    { 77L, 11L, new Guid("84c8d4da-b5c8-460c-82aa-ee56c7e51512") },
                    { 82L, 11L, new Guid("02a1a1b9-9e4c-42b6-be06-c34013e325b5") },
                    { 84L, 11L, new Guid("ff2e75c3-9c80-41ef-ac84-2a9e03634ccd") },
                    { 88L, 11L, new Guid("c3c75110-87d4-4c3a-b485-5e2f2480e15c") },
                    { 99L, 11L, new Guid("fb9f73ef-7ed6-41f3-afeb-55ca7dbcc8a5") },
                    { 6L, 12L, new Guid("b90acec4-945f-48ad-bf37-0ed335ea1558") },
                    { 17L, 12L, new Guid("84a2258d-475b-45a8-9d7f-2bc8cc801534") },
                    { 18L, 12L, new Guid("38182db2-872f-4f44-984b-718e111f0afb") },
                    { 21L, 12L, new Guid("53e7bcee-b640-4578-a42a-92a45a312a8f") },
                    { 27L, 12L, new Guid("51cfadfe-4691-41d0-ae7c-64038b349ce5") },
                    { 28L, 12L, new Guid("0f99cd33-2520-439a-8f6a-a9a4ce3213d1") },
                    { 30L, 12L, new Guid("ab01fe42-5536-414f-b9cb-448ad7098c4e") },
                    { 34L, 12L, new Guid("76a7316f-46cd-44a5-a7fb-09638deac579") },
                    { 43L, 12L, new Guid("6d5b7d66-27b4-4228-b29b-7bf48d243bc6") },
                    { 49L, 12L, new Guid("edcb9eb8-d2f7-428c-83a5-4d7c3a77777b") },
                    { 57L, 12L, new Guid("843e3ee9-49c1-449e-871b-4d961602bc0f") },
                    { 62L, 12L, new Guid("b4928678-21d2-4fb7-9951-dad96154675c") },
                    { 69L, 12L, new Guid("6658e1a2-e61a-46d5-941b-97cba18f8fc6") },
                    { 74L, 12L, new Guid("16c1dea5-fdf9-49a7-8cf9-8732fa432d08") },
                    { 81L, 12L, new Guid("2eae228a-0f0b-4c35-9152-9154e970f3bb") },
                    { 85L, 12L, new Guid("40895dea-97b4-4ff7-9eeb-b6a94f16feed") },
                    { 87L, 12L, new Guid("b6ef134e-0a34-45ba-93e8-cdb6e0918f41") },
                    { 88L, 12L, new Guid("ca111d8d-75f0-4ddf-8d2b-12da9019f1fd") },
                    { 94L, 12L, new Guid("976a7855-2a4c-44ca-87d5-a2dadf57324e") },
                    { 98L, 12L, new Guid("26ce87ca-ede2-4c34-bceb-69e27243936e") },
                    { 8L, 13L, new Guid("d374c2b5-ff86-435a-9f0f-9f93fea97412") },
                    { 11L, 13L, new Guid("62c23d11-494e-4de7-a817-4cbc1af7f520") },
                    { 14L, 13L, new Guid("68aa32d6-8733-42d5-9555-126b8e2cf48b") },
                    { 25L, 13L, new Guid("514e6a23-a2f2-465b-8410-74f88cbf54ea") },
                    { 29L, 13L, new Guid("f2615764-c6ff-45c0-9cdb-b22144706303") },
                    { 37L, 13L, new Guid("231e752e-dfdc-4a78-a49a-6d423b9e9bfd") },
                    { 41L, 13L, new Guid("47a1e87f-e325-4328-bf2b-003d22eca1c8") },
                    { 43L, 13L, new Guid("6fdc88ac-6b9a-4073-a8e9-6a451d5b8bd4") },
                    { 50L, 13L, new Guid("3893f9be-f2d2-4dcb-91d1-56ee65a5501c") },
                    { 56L, 13L, new Guid("05e13267-473a-4d13-acfb-e7d1bc0237cc") },
                    { 64L, 13L, new Guid("5c5372dd-4506-49b8-afab-69a4f1fbb24e") },
                    { 65L, 13L, new Guid("f2ce04cd-0e04-44a9-a6dc-256aa1bac56d") },
                    { 67L, 13L, new Guid("26975351-c667-445b-a4bc-5c084cf9597b") },
                    { 69L, 13L, new Guid("f9ecc44d-d96f-4075-adaf-332cb7307799") },
                    { 70L, 13L, new Guid("46dd4550-5cfb-4d8d-a35c-89c697e0c33b") },
                    { 78L, 13L, new Guid("01bafbac-b268-4461-87de-bfa839e97896") },
                    { 86L, 13L, new Guid("20ff2357-178f-4cb9-a13b-f16ec58a5b0b") },
                    { 87L, 13L, new Guid("12b88be0-df4d-454f-bde8-336d95759f23") },
                    { 89L, 13L, new Guid("1030f1fb-fd08-4557-9e54-c81482f8497b") },
                    { 92L, 13L, new Guid("9d3dd486-9a87-4f5a-bffd-237ac431f4e5") },
                    { 1L, 14L, new Guid("ea752191-f23f-402c-a84c-210cc9b5b65c") },
                    { 5L, 14L, new Guid("77ca33d7-3c70-4c2c-99a8-16d06d18fd3c") },
                    { 11L, 14L, new Guid("e27b155e-be57-42ca-9924-c98de35c2acf") },
                    { 13L, 14L, new Guid("c0b11265-bdd5-4696-ad01-69e09e425967") },
                    { 22L, 14L, new Guid("f3d6d79e-d9d3-4a1d-b9ef-d6593972e6ff") },
                    { 29L, 14L, new Guid("ad2dbf62-2715-4a90-be66-6029ca082e63") },
                    { 34L, 14L, new Guid("bfe1e64f-4015-4c0e-8bfb-76dc32303517") },
                    { 35L, 14L, new Guid("b6e04519-e7d3-4278-913f-b10aa2855f8b") },
                    { 48L, 14L, new Guid("cc498e05-0278-44ef-9bde-9f5d2e239796") },
                    { 49L, 14L, new Guid("0fa02c35-585d-4e56-9fbe-113a574341e4") },
                    { 67L, 14L, new Guid("d4a2ffd0-12d7-4fb7-b10a-e807315573c9") },
                    { 68L, 14L, new Guid("09ee5658-c4ef-43ac-9359-d973043dd1fb") },
                    { 70L, 14L, new Guid("15b1b55f-a779-4618-b0ac-e55069f39e4e") },
                    { 71L, 14L, new Guid("b1db0f93-82be-41db-bbcf-a8116f5eafdc") },
                    { 77L, 14L, new Guid("056c61aa-1f09-488f-b77b-85fb78b6ec3f") },
                    { 83L, 14L, new Guid("db1ea218-be60-42be-87f0-620de991aa10") },
                    { 84L, 14L, new Guid("a3982981-f659-4972-9d22-63b03434c7db") },
                    { 92L, 14L, new Guid("4026b26b-a5d3-4b05-b213-363f3a5ccb5e") },
                    { 96L, 14L, new Guid("5a554cb9-b9d6-4ecc-99bd-d19d9f15e52e") },
                    { 97L, 14L, new Guid("e6ad68af-5508-4b22-94b1-e41ad75904cb") },
                    { 5L, 15L, new Guid("3c335e2e-0214-447a-9788-4874ba166db1") },
                    { 7L, 15L, new Guid("09a740a2-db95-4049-ad10-4e3427dc0a7f") },
                    { 10L, 15L, new Guid("9977455e-bf49-486f-b91f-111ac2044e2d") },
                    { 18L, 15L, new Guid("3ee24cdf-03c5-4e62-9ec4-dbba2dbfc1ef") },
                    { 31L, 15L, new Guid("1b01c83d-b9ef-41c5-8649-2a1b549ff035") },
                    { 33L, 15L, new Guid("6009f151-cfe9-4209-8db1-2a16695e1eab") },
                    { 39L, 15L, new Guid("13b19ac2-1713-4fdb-8f21-e91ed1315990") },
                    { 43L, 15L, new Guid("6fdc88c8-ed01-41e1-8e85-4077e47a10f3") },
                    { 45L, 15L, new Guid("7b518b4f-02e0-4242-bb2d-9081d48d1600") },
                    { 49L, 15L, new Guid("c5aae456-28dc-4627-b1bd-336125c83ff1") },
                    { 55L, 15L, new Guid("21b69174-162b-4d6c-b366-5e893d0cff3c") },
                    { 60L, 15L, new Guid("a88855cc-b1a2-44f0-b1ab-c8e2462aa28b") },
                    { 64L, 15L, new Guid("b7df9619-c425-41b3-8cae-6ae1104458ec") },
                    { 70L, 15L, new Guid("8492cfb7-d235-456b-86c8-99a68bb4bb13") },
                    { 72L, 15L, new Guid("bec66b57-7422-4c0c-a058-37394cf77810") },
                    { 77L, 15L, new Guid("3ad5cddd-b0c6-4e19-9620-b1f250f232f6") },
                    { 84L, 15L, new Guid("a873296c-92a1-4940-b871-8ed8f079ae71") },
                    { 85L, 15L, new Guid("bcdfc1c6-77e8-4cfa-b93b-ca6c5252210d") },
                    { 87L, 15L, new Guid("b7fbcc66-4246-477b-b502-932b4fc2b39a") },
                    { 94L, 15L, new Guid("1de3da9b-1d38-47aa-8aac-faf5190f006e") },
                    { 2L, 16L, new Guid("aae1ff08-7115-427e-90f1-94a40f23bf27") },
                    { 8L, 16L, new Guid("d607e97f-9922-4338-b08e-1d67143baf51") },
                    { 9L, 16L, new Guid("8d9f9656-27e4-4dfb-b8cb-78c6ab1f416f") },
                    { 11L, 16L, new Guid("63def532-822d-4603-8a6e-3ce5651915e8") },
                    { 15L, 16L, new Guid("7dd72f44-1d33-46ed-8b60-c157ed4dd533") },
                    { 19L, 16L, new Guid("c4a225fd-38c5-4dff-b578-6d8b134948f0") },
                    { 25L, 16L, new Guid("9d905086-261d-47d1-a59b-04a5668a1b67") },
                    { 26L, 16L, new Guid("2a0db2be-eb47-43e4-a9cb-b52e4e0b8fce") },
                    { 28L, 16L, new Guid("7efb4feb-43d6-4b62-9393-59855e537f49") },
                    { 30L, 16L, new Guid("760fd97e-61d6-4c67-87f1-3cf26bacd734") },
                    { 31L, 16L, new Guid("ef744e17-76d6-4b59-905e-7341bc8eb548") },
                    { 39L, 16L, new Guid("02cfb401-27ee-488d-89fc-6b7783525f30") },
                    { 48L, 16L, new Guid("ab6fd0a9-3371-4c05-9db2-ba85c3df80d9") },
                    { 61L, 16L, new Guid("0c1ad5b6-5243-4e37-b171-c49cdd427d97") },
                    { 75L, 16L, new Guid("f7cd5fd9-fbcd-4831-a6a1-a21aeafc9b56") },
                    { 82L, 16L, new Guid("0f6443e7-1a78-479a-8ef9-5cd5f90c5c0a") },
                    { 86L, 16L, new Guid("4e4f1d2d-b87c-48f1-bd80-a97a535d4931") },
                    { 90L, 16L, new Guid("2d0eace5-4f66-4e21-89df-b6aea876d792") },
                    { 91L, 16L, new Guid("b1cf0251-b10d-4ca2-9a20-d5aa360ca678") },
                    { 97L, 16L, new Guid("a27a6397-068a-4358-b68b-86ed8fc4e554") },
                    { 2L, 17L, new Guid("8d479ac1-2e97-4be6-b844-7cd80539fc76") },
                    { 4L, 17L, new Guid("1906f17d-1384-41d6-bfc2-6a5f1307255f") },
                    { 6L, 17L, new Guid("3f518047-4dc5-41c3-91bb-9d9885274fcd") },
                    { 23L, 17L, new Guid("180fbfd8-b95b-4696-8359-c3681d805b99") },
                    { 28L, 17L, new Guid("5e39ae8e-a0b2-4bff-82d6-47f9a31b2442") },
                    { 30L, 17L, new Guid("c269308a-7414-48bb-bc87-056f71523a9b") },
                    { 34L, 17L, new Guid("fa66d50c-a315-47e1-b98f-0cfe66dfc0a0") },
                    { 44L, 17L, new Guid("48fc8df7-0240-4061-9894-d5038596c5b9") },
                    { 48L, 17L, new Guid("041a6a01-9371-471b-aeae-d64334bd0ed6") },
                    { 50L, 17L, new Guid("6c9ee791-ba85-4625-8e7b-a21b6446b46d") },
                    { 53L, 17L, new Guid("3369f2b7-76b0-4381-9c4f-413a30b853b1") },
                    { 55L, 17L, new Guid("85305b6a-087a-41da-8011-2f20ffd01afa") },
                    { 58L, 17L, new Guid("b118f5e8-e12a-4411-9114-c968a6912753") },
                    { 61L, 17L, new Guid("a4890316-1ec1-44ba-8d12-d44e62c74900") },
                    { 67L, 17L, new Guid("f671c13b-6962-44c4-bbaf-24165f5ee86c") },
                    { 69L, 17L, new Guid("122759db-02eb-4b76-a81b-3eeedd00d28b") },
                    { 81L, 17L, new Guid("899c0f06-f44b-49b6-977b-a3e259cb26fb") },
                    { 84L, 17L, new Guid("70a983cb-1ab7-4e83-9274-8ad3863d24b2") },
                    { 91L, 17L, new Guid("aa76595f-b2bc-4e6b-93d4-9eaa8086f2f3") },
                    { 92L, 17L, new Guid("1ed93453-58d3-4348-8945-0c229518e91b") },
                    { 24L, 18L, new Guid("90b6fd4c-0c7e-490a-855e-4c5f5712d8f3") },
                    { 27L, 18L, new Guid("8fc781b8-2e15-42e5-8beb-2b9a7c9745cd") },
                    { 29L, 18L, new Guid("077c78ca-a766-426f-80f3-aa886c4d3103") },
                    { 31L, 18L, new Guid("eb139494-201f-4037-8d3a-327bf1e148a3") },
                    { 36L, 18L, new Guid("813d74b1-4f01-4307-887f-a7891c217dbc") },
                    { 42L, 18L, new Guid("237d08e8-8ef8-4d42-985a-4c0a1f5177fc") },
                    { 50L, 18L, new Guid("6a577ca9-59d6-4e40-9f81-c70c6a46cf84") },
                    { 51L, 18L, new Guid("d8cff2d5-4eef-459b-ae79-5c6f7a2cc6c6") },
                    { 55L, 18L, new Guid("2a4c30cd-fa6b-4a03-82fa-f4367d5f1f1f") },
                    { 57L, 18L, new Guid("83246e8f-b99f-4962-8119-0d709d671979") },
                    { 59L, 18L, new Guid("4d5d2252-e52d-440d-b3c2-d5b2cc57c5d6") },
                    { 62L, 18L, new Guid("939969b7-1d18-430b-9cd2-bd76464a30f1") },
                    { 67L, 18L, new Guid("f5b57435-2b6f-4316-8a18-47b3616608ef") },
                    { 69L, 18L, new Guid("0d2947eb-07c4-4fff-bd2f-798346ffbe8f") },
                    { 71L, 18L, new Guid("bb04df1f-d437-427b-9e1b-9a63006dd703") },
                    { 78L, 18L, new Guid("510850ca-cdba-42f5-ac31-9f34fd79c5c1") },
                    { 80L, 18L, new Guid("67964ab2-be90-41da-8e11-3be0999c61ea") },
                    { 82L, 18L, new Guid("6a01aaa8-46c9-4475-9868-84d45618b8f8") },
                    { 84L, 18L, new Guid("a06211ba-12d7-4835-b552-323442d2cf0c") },
                    { 90L, 18L, new Guid("d3a6a687-7dd8-44e8-8cd9-16f5790ed795") },
                    { 13L, 19L, new Guid("ac173171-ee6a-4baa-af2f-c6d8d952e0f4") },
                    { 14L, 19L, new Guid("235b3669-4cbd-43f3-bc70-a4607c1b42bd") },
                    { 19L, 19L, new Guid("a1b32912-887f-4680-ab4a-45614e937945") },
                    { 21L, 19L, new Guid("7cc840c8-8570-47f1-b7ad-6832556067a8") },
                    { 22L, 19L, new Guid("23ec9ec9-c628-4879-891a-86f4d4bc2a38") },
                    { 27L, 19L, new Guid("7a5cb691-b5ea-49fb-bacf-6b72b7f376e3") },
                    { 30L, 19L, new Guid("5c59023c-0946-4e30-9f34-94c51c313ced") },
                    { 32L, 19L, new Guid("fc374f5c-3d9d-4359-b550-319848089b10") },
                    { 46L, 19L, new Guid("7f6da09f-e6c6-4610-a2c6-f748b24db8fe") },
                    { 48L, 19L, new Guid("0e7c0111-db24-46a1-9733-5f2d51569b3e") },
                    { 55L, 19L, new Guid("adfaab43-7b2c-4556-81af-f73be1ef07a2") },
                    { 60L, 19L, new Guid("578490b0-d0dd-4f6c-9742-6225741b3bc5") },
                    { 61L, 19L, new Guid("4a631c57-360f-456c-9df1-3e246c0dc6cb") },
                    { 64L, 19L, new Guid("04f92a77-b8cf-4c83-a44b-82d4d3523607") },
                    { 66L, 19L, new Guid("741155ec-6f93-4ae9-90d8-bf0f256dda55") },
                    { 69L, 19L, new Guid("a122b084-0345-4a08-8881-64d99dba3029") },
                    { 76L, 19L, new Guid("55ea99a1-3ba3-49fb-9648-bf179d3a8d63") },
                    { 82L, 19L, new Guid("220a5b21-0386-42b2-966d-395567652279") },
                    { 90L, 19L, new Guid("045a7255-bc4b-43dc-bdf8-4dc711a89d77") },
                    { 100L, 19L, new Guid("9371322f-70b7-483e-a53a-1e709e9cf29f") },
                    { 6L, 20L, new Guid("4b2907b3-e2a9-4eaa-bc25-7caa2dcbf96e") },
                    { 11L, 20L, new Guid("6911a576-22fb-477b-8d88-480406c88c9d") },
                    { 12L, 20L, new Guid("0b2da450-a6b9-4332-a3e7-044e62299cf6") },
                    { 17L, 20L, new Guid("1f15bc00-4f10-4fdb-a8a9-6b3f0ebda6bc") },
                    { 19L, 20L, new Guid("0a561389-c545-4c9d-80a2-a63430b589d8") },
                    { 21L, 20L, new Guid("0236b391-0fc7-4616-b4e7-27c2eff5ec95") },
                    { 29L, 20L, new Guid("d1a490ed-8000-4806-9bf6-d19d69a5956f") },
                    { 38L, 20L, new Guid("f4e31a72-c6ed-4b35-8069-1c58fadf5543") },
                    { 40L, 20L, new Guid("8e1db102-fb19-4ccd-ae65-97a2caa22cf6") },
                    { 49L, 20L, new Guid("43977bd7-601f-49ed-bc1c-6697948d5d2b") },
                    { 60L, 20L, new Guid("4c8f7516-2723-4c61-a0d7-ef1a8a987945") },
                    { 64L, 20L, new Guid("4e5d1689-4cea-4f98-b799-a0ff345a0ca6") },
                    { 68L, 20L, new Guid("ff3bc491-cf5e-4888-943e-10788417bf05") },
                    { 72L, 20L, new Guid("dd89f132-a784-4205-8d24-47cdb4e045f6") },
                    { 79L, 20L, new Guid("d0e43b1c-101b-4df9-b08c-41c8c56cc56f") },
                    { 81L, 20L, new Guid("dcae8efd-0026-4508-a882-20fa3a1d92aa") },
                    { 82L, 20L, new Guid("9e65049c-5dbe-4006-b899-0b1e3b8d4e00") },
                    { 90L, 20L, new Guid("fd75132d-1417-4419-9c47-3ec423145c74") },
                    { 91L, 20L, new Guid("169ab78b-45ff-49de-99f0-fd794444703c") },
                    { 97L, 20L, new Guid("246558be-dc14-4178-9027-ce0b7f304b51") },
                    { 3L, 21L, new Guid("403190ad-8c9e-42cd-84d4-cab1e025d363") },
                    { 4L, 21L, new Guid("d9a63c52-018c-409b-9146-8cb365be5e25") },
                    { 7L, 21L, new Guid("f4daed88-be19-40a2-86e4-bdff9addbcdd") },
                    { 9L, 21L, new Guid("57a7a422-c259-437d-8b3a-97105f5aeff0") },
                    { 11L, 21L, new Guid("8a76dfb0-f7d8-4e1d-a337-15eccb0f0c4a") },
                    { 12L, 21L, new Guid("9f7bfdda-79a3-45fb-8cf6-c51971b00ca8") },
                    { 13L, 21L, new Guid("694c5c65-4890-4332-bc6a-56b2af33e6e3") },
                    { 16L, 21L, new Guid("228b1b83-ac6b-49ba-a03b-a94692620605") },
                    { 26L, 21L, new Guid("2b316975-44c4-4b15-9e7d-4110f17a2e55") },
                    { 29L, 21L, new Guid("57638633-a51b-408d-a2fe-5a2f847f7f0a") },
                    { 32L, 21L, new Guid("2ed2f714-b9d6-489c-8966-05ecf788d844") },
                    { 39L, 21L, new Guid("9abd8f9e-a912-480d-bf6e-c2836af4e46c") },
                    { 41L, 21L, new Guid("e2022ade-01b8-46e0-a7ee-6086541ee457") },
                    { 43L, 21L, new Guid("d25b8f30-88ed-44b9-99b8-afed65d3b95b") },
                    { 46L, 21L, new Guid("1ab5b5d0-eb0d-436e-8afb-4366aea9a173") },
                    { 53L, 21L, new Guid("50db1e98-aa26-468b-b67c-93e4482fffa2") },
                    { 72L, 21L, new Guid("9307b55b-6631-4c58-a66c-72b6a184a6ef") },
                    { 83L, 21L, new Guid("50ef4f02-0348-476d-8bd8-23c237dc8c72") },
                    { 91L, 21L, new Guid("680aeafa-b72e-4f4c-a79b-83d2e5007130") },
                    { 93L, 21L, new Guid("9a152fa0-7a26-46b3-bda9-77dbbf4c26e5") },
                    { 23L, 22L, new Guid("aa377483-df26-4957-812f-a8860514771b") },
                    { 30L, 22L, new Guid("200b24be-fbfa-4b18-9566-400b05b76c8f") },
                    { 32L, 22L, new Guid("2ab8d084-0eaf-4f27-8fee-e95d890cf55d") },
                    { 41L, 22L, new Guid("b1f1e970-9c9f-4d10-b6a5-f5ec45d7d29c") },
                    { 50L, 22L, new Guid("b4265e7c-c715-4647-b4fb-a09a658b7b6c") },
                    { 52L, 22L, new Guid("300a25f3-93c2-45e9-bd36-56946dc03007") },
                    { 54L, 22L, new Guid("451a1df7-5f51-4817-bf32-3c3f9fccd292") },
                    { 65L, 22L, new Guid("42b70ff0-dd96-4b1f-adaf-b388243f1a2b") },
                    { 72L, 22L, new Guid("90f2e02d-91c0-475c-a433-de32532cfc9d") },
                    { 74L, 22L, new Guid("5b42f194-828d-4308-bade-89417486716b") },
                    { 75L, 22L, new Guid("8cc98f35-5507-4e9a-97b6-71ae104eb3ee") },
                    { 76L, 22L, new Guid("e42a68f1-fd16-4ec9-a57b-9fb7416154a3") },
                    { 77L, 22L, new Guid("f3e82048-bb23-43c7-bc8b-b4322404d0a0") },
                    { 81L, 22L, new Guid("c76467ca-2195-434f-a492-d3aba346ed97") },
                    { 86L, 22L, new Guid("9a79f2eb-7f8a-46b9-acd2-34c606c497e5") },
                    { 87L, 22L, new Guid("952b7eb5-06ba-44a7-9fc5-c67fcd28b736") },
                    { 95L, 22L, new Guid("c6280b8d-0217-4b6e-b87f-08346befdd6e") },
                    { 97L, 22L, new Guid("0a592a23-052e-473a-8619-6b14e44201fd") },
                    { 99L, 22L, new Guid("83d93be1-2b74-4549-83ff-a9fc0e69756e") },
                    { 100L, 22L, new Guid("22337394-ca97-49cc-89eb-dabb07a5f1da") },
                    { 17L, 23L, new Guid("2c166d55-c45e-4ac2-99ce-2e4b15877b7c") },
                    { 23L, 23L, new Guid("f5e4ed73-e0dd-4dbd-8de7-5aca8998b01a") },
                    { 42L, 23L, new Guid("4cd97be8-b764-4ed4-a73d-397c027d9755") },
                    { 43L, 23L, new Guid("6bf66b4f-e07e-4411-b0a1-4524265a3b1d") },
                    { 44L, 23L, new Guid("0c739e08-f431-47a5-97a5-ae1c51b22519") },
                    { 48L, 23L, new Guid("fd34123a-c2dd-4e3e-9e7e-37265108dd41") },
                    { 49L, 23L, new Guid("79d90800-f956-4bb6-881c-c5bdfb35a753") },
                    { 54L, 23L, new Guid("2fb71ebe-f290-46b7-a38a-2f6d5158092d") },
                    { 56L, 23L, new Guid("0df0bdf6-cf85-4c63-bc4f-bc870e244322") },
                    { 58L, 23L, new Guid("52b781b8-9823-4e07-b5eb-0523dd450755") },
                    { 63L, 23L, new Guid("cc534ed5-1f02-4988-8653-46c2da811950") },
                    { 66L, 23L, new Guid("e3a38bc7-086f-4051-a0be-466e653e7d9c") },
                    { 75L, 23L, new Guid("0d012a08-89b3-4159-b4c5-86e33cfa5434") },
                    { 79L, 23L, new Guid("2327f85f-a197-41b7-8bf9-f1ef3daac015") },
                    { 82L, 23L, new Guid("9fdd4a35-0ffc-4317-94a9-ca22a143cd14") },
                    { 83L, 23L, new Guid("4f6b08dd-f2ee-408a-bc8f-9e6bd6c1c8a8") },
                    { 86L, 23L, new Guid("b2d18a4e-33a6-4486-aea1-c1fa799a95d3") },
                    { 87L, 23L, new Guid("125788ed-ed30-4298-9b95-eb13e32e770d") },
                    { 88L, 23L, new Guid("75aea759-0f42-490e-b102-c1f146870c67") },
                    { 98L, 23L, new Guid("35e071db-f7d3-4d80-a918-69d946734195") },
                    { 7L, 24L, new Guid("fa176f5f-1863-4f88-9222-2cee7ce88a30") },
                    { 9L, 24L, new Guid("451b2386-ee2c-4fc5-9d54-2936ad58791a") },
                    { 10L, 24L, new Guid("3ce63648-90a1-4c36-8b3c-953d908dd67d") },
                    { 11L, 24L, new Guid("2d81b186-e8a6-456e-9b50-623d403e6072") },
                    { 23L, 24L, new Guid("0cd6ade6-b474-49cd-8cd4-7e7152b38385") },
                    { 27L, 24L, new Guid("bcbcf03e-2846-479d-85b8-0512fa5fec8e") },
                    { 41L, 24L, new Guid("451b680e-3137-4f03-98f2-90911b5774d6") },
                    { 43L, 24L, new Guid("53971a8d-550c-4a07-aacd-a2154a473d62") },
                    { 45L, 24L, new Guid("f2620c5a-6a72-4a8f-be66-2c0347f00ba1") },
                    { 46L, 24L, new Guid("c0133a17-1a1d-47d0-87cb-3937728c3a09") },
                    { 49L, 24L, new Guid("f24babe6-3ee8-40b1-96e8-761f03f4604a") },
                    { 59L, 24L, new Guid("e96a4124-7c7d-43b8-94df-d994c3b155c9") },
                    { 60L, 24L, new Guid("482ee435-5c2b-404d-b58a-f293a7b0d106") },
                    { 66L, 24L, new Guid("2d34430b-dad8-4864-a52f-726d7a97791f") },
                    { 67L, 24L, new Guid("610817a3-0780-48a9-bc43-f0a704d19abb") },
                    { 75L, 24L, new Guid("dc9dd1e5-2104-48a5-b114-4644c8220a0e") },
                    { 88L, 24L, new Guid("4ffdecc9-9f81-4c0b-9445-b9265c388241") },
                    { 94L, 24L, new Guid("4a433986-218a-400a-9aba-f850de02935e") },
                    { 96L, 24L, new Guid("1f6d3033-bcdc-4f15-8ea7-daf7a2aaacdc") },
                    { 97L, 24L, new Guid("52bcc8b7-b993-4987-8a6e-8e96af994cb9") },
                    { 4L, 25L, new Guid("4ba4d4c3-41d9-4bb0-9133-ffaea07ba4c8") },
                    { 9L, 25L, new Guid("cfbd9ad7-498b-47fc-9f29-e15db3850c6b") },
                    { 17L, 25L, new Guid("415e4d82-3e5f-4018-a8ff-c07d09cc5efb") },
                    { 19L, 25L, new Guid("7c13dbb9-dc74-4ae9-afca-019d258270d3") },
                    { 25L, 25L, new Guid("d4ce5126-e311-437d-80f2-817de0ea1a85") },
                    { 29L, 25L, new Guid("6d291f98-2e77-4ce1-a97f-5d4a69c1daa1") },
                    { 32L, 25L, new Guid("6be98eee-d804-406c-84a3-95155520524b") },
                    { 38L, 25L, new Guid("dfa5018b-ef0a-4d7f-b86d-79bcb3d61d7b") },
                    { 41L, 25L, new Guid("19146aa2-0569-471f-8dbb-0c0258b8968c") },
                    { 46L, 25L, new Guid("84a3ae6d-e8c5-47b8-8b60-3ce2828a38da") },
                    { 51L, 25L, new Guid("31888d7d-ef6c-4257-b4b6-8125a59c75cc") },
                    { 52L, 25L, new Guid("db05038d-3c7f-4f25-a22b-6071945fc2a6") },
                    { 54L, 25L, new Guid("e97817ca-6e7a-413b-a699-c3bed78d74cc") },
                    { 56L, 25L, new Guid("bf81dc73-81e6-4067-9d0a-00c6782c7a94") },
                    { 63L, 25L, new Guid("e8340297-44b3-4a4a-8580-b0d27a138989") },
                    { 83L, 25L, new Guid("d650fb09-ba10-4af8-ad66-b80aab691a95") },
                    { 85L, 25L, new Guid("9b0eeb67-15df-4137-949a-281d75b2712f") },
                    { 88L, 25L, new Guid("21b94aa4-b573-4e7a-b2fe-1e76d769950c") },
                    { 98L, 25L, new Guid("f6a771ec-a5b2-4b36-bd68-cb50583c02cb") },
                    { 99L, 25L, new Guid("97d5642b-f587-4f80-a9ff-7c9ec1a6e31c") },
                    { 5L, 26L, new Guid("361e26e0-e673-40f4-ba89-b7c811a38e64") },
                    { 6L, 26L, new Guid("c2659f88-e780-40f1-8b74-81e0114c5478") },
                    { 7L, 26L, new Guid("a292a19c-8461-420e-995f-d7b5d2372224") },
                    { 9L, 26L, new Guid("11477d08-c02b-4b6f-9af2-d505f5d510a4") },
                    { 12L, 26L, new Guid("b252c222-9ded-4540-ac18-017a451be9b8") },
                    { 27L, 26L, new Guid("1f09894e-3ad7-4948-939b-077e38c435b0") },
                    { 28L, 26L, new Guid("4ababc1b-06c0-4dd8-b56f-e9361c66cb4e") },
                    { 29L, 26L, new Guid("529e2e62-dadf-45fd-b821-a6cb4e5b9216") },
                    { 30L, 26L, new Guid("668bb010-290c-4aa3-acc9-34585b3176ab") },
                    { 40L, 26L, new Guid("b3b6a641-02e2-4a16-aa32-e830e4877721") },
                    { 41L, 26L, new Guid("b98d532e-5ac5-4624-8aa7-117831133e83") },
                    { 42L, 26L, new Guid("42d303ed-78b5-4296-9bb0-09781d01c0a2") },
                    { 46L, 26L, new Guid("4cba1657-320a-45c6-be54-c04050b3cfa4") },
                    { 50L, 26L, new Guid("4f8e337b-a949-4ff5-b984-d8416af07922") },
                    { 57L, 26L, new Guid("882ec25e-ff19-48cb-b3c5-3942d2035a46") },
                    { 76L, 26L, new Guid("fbc33095-733f-44e8-96ea-f43c43d318ab") },
                    { 91L, 26L, new Guid("bd258d64-7ea7-4fc9-90de-080ed16432eb") },
                    { 93L, 26L, new Guid("14d36826-46cb-4e8d-9942-8cb46030a4a6") },
                    { 94L, 26L, new Guid("4b5e07c9-351d-49ea-97e9-75ef20a72531") },
                    { 99L, 26L, new Guid("73523e87-5b11-4297-9aec-4d1d31b8c472") },
                    { 1L, 27L, new Guid("f6c0a37b-7130-4740-965f-4213dd97c84f") },
                    { 2L, 27L, new Guid("3978072e-9303-4176-8359-25c1e84e9e98") },
                    { 6L, 27L, new Guid("ef97030f-bd84-467a-b314-d3616fcd5192") },
                    { 10L, 27L, new Guid("5e7ede3e-a143-485a-9288-69b8212d5535") },
                    { 12L, 27L, new Guid("5c32058c-4cad-46b6-bb83-687eb1dad933") },
                    { 18L, 27L, new Guid("681e97db-b0d0-4c56-a77a-2a339ecadfe9") },
                    { 20L, 27L, new Guid("49558f36-91ca-458e-8b5b-0dd21898eee4") },
                    { 21L, 27L, new Guid("6fbd8886-e9cd-4a54-bb75-08a5205d9b7a") },
                    { 25L, 27L, new Guid("4476fd4f-79a8-48f5-a46d-629a5297cccb") },
                    { 27L, 27L, new Guid("78733230-5a55-4219-8d75-8566ed24ebc0") },
                    { 29L, 27L, new Guid("a5bf875c-2bb1-4eea-8bf0-e00b9c381778") },
                    { 34L, 27L, new Guid("58ec554a-71ba-466d-b53b-abad53b1769d") },
                    { 40L, 27L, new Guid("f1a75495-b4ce-4bbf-847a-ab53134e923d") },
                    { 41L, 27L, new Guid("99fa23bc-d056-47bb-8322-f34dca36871a") },
                    { 44L, 27L, new Guid("a6732434-64f4-428a-888f-8df99ca3885e") },
                    { 56L, 27L, new Guid("9bd090d4-ab91-4103-89bc-1e1c86900a80") },
                    { 77L, 27L, new Guid("c818dbfc-b750-41ac-9a8e-e52b0a977c93") },
                    { 83L, 27L, new Guid("fe0343d1-aa38-4bb8-8167-fd1339dc69a7") },
                    { 84L, 27L, new Guid("7d86e0ae-a854-4479-a4d1-3d546c54736d") },
                    { 98L, 27L, new Guid("eae7a9a9-b9ce-4873-96ea-d14739c6e664") },
                    { 6L, 28L, new Guid("dfe6d37e-eaca-4f9e-8fc1-a9cba98a38af") },
                    { 21L, 28L, new Guid("ed14d730-172c-433a-a89e-420d1d3f4e51") },
                    { 25L, 28L, new Guid("09ace378-3a8e-4630-836f-29b7e4588928") },
                    { 28L, 28L, new Guid("8e4e21cc-1300-42c9-bef1-6d62d1b395fa") },
                    { 30L, 28L, new Guid("dace721c-dd7b-4257-bcec-df1fedd55d08") },
                    { 35L, 28L, new Guid("754c9947-5d4c-47af-a271-86a2817549ab") },
                    { 38L, 28L, new Guid("68d0d996-fc96-4e5f-b55c-54aea5e72e90") },
                    { 47L, 28L, new Guid("5577383e-f806-4236-b1c2-90f6b786d1d3") },
                    { 48L, 28L, new Guid("26a7ef40-142f-4fe4-a612-8e2acb580ab0") },
                    { 50L, 28L, new Guid("a3863dfe-0446-4563-a3d1-db7fbbf975ba") },
                    { 55L, 28L, new Guid("95096e27-2e5b-4477-8777-b1c84758c4fc") },
                    { 60L, 28L, new Guid("363330b3-f799-47e9-98d4-26600e846791") },
                    { 65L, 28L, new Guid("a4b443d6-2631-4357-adcf-6a18419c9ec5") },
                    { 66L, 28L, new Guid("52b43658-37c9-4d4c-86b6-6fbf2459c4a2") },
                    { 75L, 28L, new Guid("2e23f7d0-c8d9-4c2f-aa76-9207aaa37d80") },
                    { 86L, 28L, new Guid("2b8f3543-d1ef-4232-b664-0aacf90f8a81") },
                    { 91L, 28L, new Guid("6485d62d-c0fe-4a2d-ba19-90bd9dec89bc") },
                    { 93L, 28L, new Guid("2759ab9f-0162-4933-bcb4-ca2d15534998") },
                    { 96L, 28L, new Guid("2fefb47e-ad49-46ce-9706-b49fdf095334") },
                    { 99L, 28L, new Guid("64230c02-171a-4aee-b171-fb2b01288246") },
                    { 4L, 29L, new Guid("fbd69b2f-873b-43c2-8d49-ede649f00c7e") },
                    { 6L, 29L, new Guid("b1fee63a-1e3b-4b08-8fdf-2ec6d8be7214") },
                    { 7L, 29L, new Guid("765e0241-14b2-4860-a850-743aede5e525") },
                    { 12L, 29L, new Guid("e02a5dda-f928-43ae-8b94-ca98ef4d3800") },
                    { 26L, 29L, new Guid("72a72481-7292-4d76-a197-977549364d1a") },
                    { 36L, 29L, new Guid("fe876fc0-6386-4141-918b-26a06b88553d") },
                    { 37L, 29L, new Guid("fe715999-2f3b-4a00-9677-107dee2ccf5f") },
                    { 45L, 29L, new Guid("55ba094b-ce97-484f-89fe-f7871a9a3802") },
                    { 46L, 29L, new Guid("57267920-afa1-4634-9763-9d11d6c39ae2") },
                    { 50L, 29L, new Guid("823930ec-b5f3-473f-a22d-92373fbc0751") },
                    { 54L, 29L, new Guid("55ff7230-2047-4088-90f5-d2b75c894d4e") },
                    { 70L, 29L, new Guid("922039e1-d3a7-41b3-8829-ecdf2cd6b07e") },
                    { 73L, 29L, new Guid("03de5bf5-d4d1-4b05-8d1a-19b9bb5c7e8a") },
                    { 75L, 29L, new Guid("46fe5392-3283-458b-bcbb-656b9ab1b078") },
                    { 77L, 29L, new Guid("eba162c5-b61c-4436-9d4c-4db54dcc46a6") },
                    { 84L, 29L, new Guid("c4d6eec3-22da-4986-9592-7879d7218e50") },
                    { 85L, 29L, new Guid("519998e6-e551-468a-85b9-b41a7be306ee") },
                    { 92L, 29L, new Guid("e037e916-cea4-4de4-bed1-5baeca409054") },
                    { 99L, 29L, new Guid("3ced3310-c416-4eb0-be18-21f0d36493d2") },
                    { 100L, 29L, new Guid("c8390647-106f-4fca-a030-1c3afd472fd6") },
                    { 1L, 30L, new Guid("e7964e76-0126-443b-a1a1-9e1e69395051") },
                    { 5L, 30L, new Guid("eeeb57d3-7a9e-45a1-b8dc-8cb063b37ef6") },
                    { 8L, 30L, new Guid("db81fabb-8f96-4bb7-87f4-d638f75991c7") },
                    { 9L, 30L, new Guid("5696bb78-c5e1-4969-a32b-c125ed8e1d0a") },
                    { 12L, 30L, new Guid("f15fa8eb-862b-4488-82aa-bf5d6738a0a5") },
                    { 22L, 30L, new Guid("fb3e5cdf-cc84-425a-8a7a-25c81a7494b9") },
                    { 27L, 30L, new Guid("6ca6c813-38b5-4cae-bc77-17e3d1af3ed3") },
                    { 29L, 30L, new Guid("12ad9e72-f744-4a23-b910-f102e8f9f103") },
                    { 30L, 30L, new Guid("fd994243-c8d6-4278-897d-e9eb1508e8b4") },
                    { 31L, 30L, new Guid("c1205c13-cbec-48fe-9f9d-88f15f489899") },
                    { 32L, 30L, new Guid("12f6c588-8fb4-4078-9ed8-16a6e03c87e1") },
                    { 36L, 30L, new Guid("db982f5d-5d25-482d-a068-c64105dffbcb") },
                    { 47L, 30L, new Guid("860fdd0a-a867-49cb-8eab-fcb6dd7dccc7") },
                    { 60L, 30L, new Guid("85ddf4a6-2ff3-401f-9a9e-ae53ac1ce4b3") },
                    { 64L, 30L, new Guid("b46a8d11-743a-4dd2-8cf8-584e8ba51d91") },
                    { 73L, 30L, new Guid("f44f6bd4-d137-4ca0-996c-488533644070") },
                    { 77L, 30L, new Guid("de455aa3-1215-49ac-a2bb-9b555eb574ba") },
                    { 83L, 30L, new Guid("1d6913c3-b643-403d-b91a-5a7d81c6752a") },
                    { 86L, 30L, new Guid("eab188d2-c0f5-4b90-a67b-9711b203419b") },
                    { 88L, 30L, new Guid("16bf8242-bc3a-40f3-a4e5-b41603fefaf9") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 6L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 9L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 13L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 31L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 33L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 42L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 43L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 45L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 57L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 58L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 60L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 61L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 76L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 77L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 84L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 88L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 91L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 92L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 94L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 100L, 1L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 1L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 4L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 14L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 21L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 31L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 33L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 34L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 45L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 51L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 52L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 60L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 64L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 65L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 68L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 72L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 76L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 78L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 83L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 89L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 99L, 2L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 1L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 6L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 9L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 10L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 11L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 25L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 31L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 32L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 33L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 34L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 38L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 50L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 51L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 56L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 67L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 71L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 79L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 93L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 96L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 99L, 3L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 1L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 8L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 10L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 16L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 26L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 30L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 37L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 43L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 47L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 53L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 57L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 64L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 73L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 78L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 86L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 87L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 89L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 91L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 95L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 100L, 4L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 5L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 8L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 13L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 15L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 19L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 26L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 35L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 36L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 37L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 46L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 47L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 60L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 65L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 67L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 68L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 75L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 80L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 84L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 91L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 94L, 5L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 1L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 15L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 17L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 18L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 19L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 21L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 31L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 36L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 38L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 43L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 48L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 53L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 55L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 60L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 68L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 84L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 90L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 93L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 94L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 95L, 6L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 9L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 20L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 24L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 27L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 28L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 30L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 32L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 37L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 38L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 39L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 45L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 51L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 58L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 61L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 78L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 84L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 87L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 88L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 95L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 96L, 7L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 5L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 8L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 10L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 17L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 21L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 22L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 23L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 24L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 25L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 38L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 43L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 47L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 57L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 59L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 61L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 68L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 76L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 83L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 86L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 90L, 8L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 6L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 19L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 32L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 38L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 46L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 47L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 52L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 57L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 59L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 61L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 63L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 65L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 70L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 73L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 80L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 81L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 82L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 92L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 93L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 99L, 9L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 3L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 6L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 7L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 16L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 17L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 18L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 31L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 32L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 34L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 36L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 37L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 47L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 50L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 67L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 72L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 77L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 78L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 79L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 92L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 98L, 10L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 13L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 15L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 21L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 23L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 25L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 33L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 35L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 43L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 52L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 53L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 57L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 58L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 60L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 62L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 66L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 77L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 82L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 84L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 88L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 99L, 11L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 6L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 17L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 18L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 21L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 27L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 28L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 30L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 34L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 43L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 49L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 57L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 62L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 69L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 74L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 81L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 85L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 87L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 88L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 94L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 98L, 12L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 8L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 11L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 14L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 25L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 29L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 37L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 41L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 43L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 50L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 56L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 64L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 65L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 67L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 69L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 70L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 78L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 86L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 87L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 89L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 92L, 13L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 1L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 5L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 11L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 13L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 22L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 29L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 34L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 35L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 48L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 49L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 67L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 68L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 70L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 71L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 77L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 83L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 84L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 92L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 96L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 97L, 14L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 5L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 7L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 10L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 18L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 31L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 33L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 39L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 43L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 45L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 49L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 55L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 60L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 64L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 70L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 72L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 77L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 84L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 85L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 87L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 94L, 15L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 2L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 8L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 9L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 11L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 15L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 19L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 25L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 26L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 28L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 30L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 31L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 39L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 48L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 61L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 75L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 82L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 86L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 90L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 91L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 97L, 16L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 2L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 4L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 6L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 23L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 28L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 30L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 34L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 44L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 48L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 50L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 53L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 55L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 58L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 61L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 67L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 69L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 81L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 84L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 91L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 92L, 17L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 24L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 27L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 29L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 31L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 36L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 42L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 50L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 51L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 55L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 57L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 59L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 62L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 67L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 69L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 71L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 78L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 80L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 82L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 84L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 90L, 18L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 13L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 14L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 19L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 21L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 22L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 27L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 30L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 32L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 46L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 48L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 55L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 60L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 61L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 64L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 66L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 69L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 76L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 82L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 90L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 100L, 19L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 6L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 11L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 12L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 17L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 19L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 21L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 29L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 38L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 40L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 49L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 60L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 64L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 68L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 72L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 79L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 81L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 82L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 90L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 91L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 97L, 20L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 3L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 4L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 7L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 9L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 11L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 12L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 13L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 16L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 26L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 29L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 32L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 39L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 41L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 43L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 46L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 53L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 72L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 83L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 91L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 93L, 21L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 23L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 30L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 32L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 41L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 50L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 52L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 54L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 65L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 72L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 74L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 75L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 76L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 77L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 81L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 86L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 87L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 95L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 97L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 99L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 100L, 22L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 17L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 23L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 42L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 43L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 44L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 48L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 49L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 54L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 56L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 58L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 63L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 66L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 75L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 79L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 82L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 83L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 86L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 87L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 88L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 98L, 23L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 7L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 9L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 10L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 11L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 23L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 27L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 41L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 43L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 45L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 46L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 49L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 59L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 60L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 66L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 67L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 75L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 88L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 94L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 96L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 97L, 24L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 4L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 9L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 17L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 19L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 25L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 29L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 32L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 38L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 41L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 46L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 51L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 52L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 54L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 56L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 63L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 83L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 85L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 88L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 98L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 99L, 25L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 5L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 6L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 7L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 9L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 12L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 27L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 28L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 29L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 30L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 40L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 41L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 42L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 46L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 50L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 57L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 76L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 91L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 93L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 94L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 99L, 26L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 1L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 2L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 6L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 10L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 12L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 18L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 20L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 21L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 25L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 27L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 29L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 34L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 40L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 41L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 44L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 56L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 77L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 83L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 84L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 98L, 27L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 6L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 21L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 25L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 28L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 30L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 35L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 38L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 47L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 48L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 50L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 55L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 60L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 65L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 66L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 75L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 86L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 91L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 93L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 96L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 99L, 28L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 4L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 6L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 7L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 12L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 26L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 36L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 37L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 45L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 46L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 50L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 54L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 70L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 73L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 75L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 77L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 84L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 85L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 92L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 99L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 100L, 29L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 1L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 5L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 8L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 9L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 12L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 22L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 27L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 29L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 30L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 31L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 32L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 36L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 47L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 60L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 64L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 73L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 77L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 83L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 86L, 30L });

            migrationBuilder.DeleteData(
                table: "JogoUsuario",
                keyColumns: new[] { "JogoId", "UsuarioId" },
                keyValues: new object[] { 88L, 30L });
        }
    }
}
