using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class Adicionando_novas_tabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegiaoCidade_Regiões_RegiaoId",
                table: "RegiaoCidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regiões",
                table: "Regiões");

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0cacdbc3-ead0-4a37-af1f-207b3e3d5e6e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1e9f13c0-90e0-4367-8623-ec03d19f494a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("248b2d56-99aa-4dc5-b127-68ccaeab8c8c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2deb2ca4-11c7-4992-ac0e-32ec53ae58a6"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("38aca219-2411-46bf-9937-0ac50c58c907"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4471bb5c-1d16-49bb-b6f7-15c81607fdd3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("47c13a7e-b73a-4933-bfa1-ddb880b9331b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4d3dc9cd-3436-48e3-833c-2ebe3876e652"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("508c7d39-f3e2-4283-8343-fc53cdc9db0f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("56eb1626-33fb-48f7-adfd-9f4c28776465"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5f3515a9-ac45-4993-ac17-9e16f1689deb"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("756567d5-dc6a-47f0-8cf2-8b7b84016eff"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("89010611-abfa-43c3-998f-159b13d845f8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a55d7fd7-e337-45a3-9edf-79d4f5bb0f71"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a8e4c6c9-7107-4dfa-9b06-adb783e77286"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a9464047-b910-44f3-bb7f-fa3606d6b92c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b36de4a8-2451-4f6f-9bab-65657a328e59"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b6f98371-5781-4a8f-bac1-33d335d2a390"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ba007780-2dcf-4500-b25e-c6cb15064bec"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("bb8594e8-fc0f-4bb3-8bf0-b983d9e698e2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d6790f1f-1ff2-480c-bf3c-17e2c6b6d664"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d69b408b-293c-466b-9c41-c3cc37c6a910"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e5f69251-7ce6-4286-a585-ded5cee8cf58"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e645bf13-44f6-4a68-a19b-9bfa8c53ff83"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e665babd-fe8f-4241-b20f-1fec9689c220"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("edaea6c9-3ca2-4c1b-a6bb-d7b67d0eaca6"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f08e9d9b-aede-4f48-9e07-37c1938b95c2"));

            migrationBuilder.RenameTable(
                name: "Regiões",
                newName: "Regiao");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regiao",
                table: "Regiao",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6f456202-74be-4fb8-8115-98b80022656a"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4e25cd57-05d9-4946-9f21-ea3d5f448110"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("b25a5482-15fe-4740-bd14-accc2a6fce31"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c6e8be4b-1187-4725-947a-0346cc450a0d"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f1110d9a-f39e-465d-8d18-d827b7bbebc9"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c7059ec9-3976-4439-b6e8-d373d4ea3901"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("8f5dae50-3c9e-4a34-a9da-12d61f9be73c"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c2cc241d-fbac-4e65-9e14-ce5090f91c6a"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6f1d8489-bcc9-4b05-ac74-c1853bad3eb5"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7c70a059-e2fc-4539-90f1-ef1ec051dbb6"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4dc903f2-e5e4-4145-abb0-194051bd9bfd"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("3a363cbb-7389-43b1-bf0f-adce534545ab"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6e7af0eb-d177-4bdf-be2e-738f7220871e"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("83627a7a-524b-4269-86d5-bfdb2fdd4de5"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0cc8b51e-768d-4bc2-81c3-040001945284"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5a33fd98-b18b-4929-87ee-44b0b5c92e03"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4890dae5-b500-41f9-9f35-065c1f90635e"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6f6ee52a-207f-4391-ba72-293499128bac"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("be8fa392-6df1-49b7-b7ef-59ed0b3e4601"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4805e7c2-b885-4b0e-90f8-6d51fa3b027e"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e6d27148-17f3-4185-b4a5-60f0022a04c6"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("1083b8d3-08fe-44e8-9850-725fff17ff64"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("fa4d7888-3796-45e4-a6e6-661c67e9bd81"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("563bbf1a-edf8-403f-9f6a-f739dfe493b6"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("18119dc4-bd9b-4503-9be6-5d9ebb642167"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5795be78-ad45-4028-bdf1-3a869ec01543"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("13d2a5c8-12a7-4f1d-ba9d-37157ac35225"), "Palmas", "TO" });

            migrationBuilder.AddForeignKey(
                name: "FK_RegiaoCidade_Regiao_RegiaoId",
                table: "RegiaoCidade",
                column: "RegiaoId",
                principalTable: "Regiao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegiaoCidade_Regiao_RegiaoId",
                table: "RegiaoCidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regiao",
                table: "Regiao");

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0cc8b51e-768d-4bc2-81c3-040001945284"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1083b8d3-08fe-44e8-9850-725fff17ff64"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("13d2a5c8-12a7-4f1d-ba9d-37157ac35225"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("18119dc4-bd9b-4503-9be6-5d9ebb642167"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("3a363cbb-7389-43b1-bf0f-adce534545ab"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4805e7c2-b885-4b0e-90f8-6d51fa3b027e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4890dae5-b500-41f9-9f35-065c1f90635e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4dc903f2-e5e4-4145-abb0-194051bd9bfd"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4e25cd57-05d9-4946-9f21-ea3d5f448110"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("563bbf1a-edf8-403f-9f6a-f739dfe493b6"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5795be78-ad45-4028-bdf1-3a869ec01543"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5a33fd98-b18b-4929-87ee-44b0b5c92e03"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6e7af0eb-d177-4bdf-be2e-738f7220871e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6f1d8489-bcc9-4b05-ac74-c1853bad3eb5"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6f456202-74be-4fb8-8115-98b80022656a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6f6ee52a-207f-4391-ba72-293499128bac"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7c70a059-e2fc-4539-90f1-ef1ec051dbb6"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("83627a7a-524b-4269-86d5-bfdb2fdd4de5"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8f5dae50-3c9e-4a34-a9da-12d61f9be73c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b25a5482-15fe-4740-bd14-accc2a6fce31"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("be8fa392-6df1-49b7-b7ef-59ed0b3e4601"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c2cc241d-fbac-4e65-9e14-ce5090f91c6a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c6e8be4b-1187-4725-947a-0346cc450a0d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c7059ec9-3976-4439-b6e8-d373d4ea3901"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e6d27148-17f3-4185-b4a5-60f0022a04c6"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f1110d9a-f39e-465d-8d18-d827b7bbebc9"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fa4d7888-3796-45e4-a6e6-661c67e9bd81"));

            migrationBuilder.RenameTable(
                name: "Regiao",
                newName: "Regiões");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regiões",
                table: "Regiões",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a55d7fd7-e337-45a3-9edf-79d4f5bb0f71"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("b6f98371-5781-4a8f-bac1-33d335d2a390"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ba007780-2dcf-4500-b25e-c6cb15064bec"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a9464047-b910-44f3-bb7f-fa3606d6b92c"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("248b2d56-99aa-4dc5-b127-68ccaeab8c8c"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4d3dc9cd-3436-48e3-833c-2ebe3876e652"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("508c7d39-f3e2-4283-8343-fc53cdc9db0f"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("47c13a7e-b73a-4933-bfa1-ddb880b9331b"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("56eb1626-33fb-48f7-adfd-9f4c28776465"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e665babd-fe8f-4241-b20f-1fec9689c220"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("756567d5-dc6a-47f0-8cf2-8b7b84016eff"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e645bf13-44f6-4a68-a19b-9bfa8c53ff83"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e5f69251-7ce6-4286-a585-ded5cee8cf58"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("89010611-abfa-43c3-998f-159b13d845f8"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("bb8594e8-fc0f-4bb3-8bf0-b983d9e698e2"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("b36de4a8-2451-4f6f-9bab-65657a328e59"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2deb2ca4-11c7-4992-ac0e-32ec53ae58a6"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5f3515a9-ac45-4993-ac17-9e16f1689deb"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f08e9d9b-aede-4f48-9e07-37c1938b95c2"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("1e9f13c0-90e0-4367-8623-ec03d19f494a"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d6790f1f-1ff2-480c-bf3c-17e2c6b6d664"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d69b408b-293c-466b-9c41-c3cc37c6a910"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4471bb5c-1d16-49bb-b6f7-15c81607fdd3"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("edaea6c9-3ca2-4c1b-a6bb-d7b67d0eaca6"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("38aca219-2411-46bf-9937-0ac50c58c907"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0cacdbc3-ead0-4a37-af1f-207b3e3d5e6e"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a8e4c6c9-7107-4dfa-9b06-adb783e77286"), "Palmas", "TO" });

            migrationBuilder.AddForeignKey(
                name: "FK_RegiaoCidade_Regiões_RegiaoId",
                table: "RegiaoCidade",
                column: "RegiaoId",
                principalTable: "Regiões",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
