using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASystems.DeskReservation.Web.Migrations
{
    public partial class SeedDataPasswordFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("1211ab66-f499-49e5-9242-08a2d7739575"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("26583fde-99e2-427a-bbc7-581308a7bc60"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("7f6ee906-fd7b-4474-9d86-daba840dbfcf"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("909479f7-86a3-4ea2-b20d-5d8519e4b177"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("c5760b2c-0167-4e7f-be7d-aad4e697ba8b"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("db1b3f57-d2e7-4ea3-a436-5c58243f28e2"));

            migrationBuilder.InsertData(
                table: "Desks",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3d254f4c-f968-4cea-bc9d-e3bcd1db9d2b"), "Desk1" },
                    { new Guid("7283636b-f10d-4fa3-a395-5132a3f9c30c"), "Desk5" },
                    { new Guid("7b1f2275-8ebb-491a-a458-1f729c75f80e"), "Desk3" },
                    { new Guid("ae4147e6-49b0-40bd-8980-5658b46166a5"), "Desk2" },
                    { new Guid("b761c364-99f1-4ae8-8216-5387f408541a"), "Desk4" },
                    { new Guid("d3e2f979-f721-44c5-8eb5-097394b72284"), "Desk6" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6844d9d3-a402-5942-755d-38e6d163e820"),
                column: "ConcurrencyStamp",
                value: "00edb8c3-9c6d-4435-b1c9-3319c6bc6324");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ce8cc445-2d2e-bd7f-ea1a-fc51c7c6ad26"),
                column: "ConcurrencyStamp",
                value: "2b9d14ea-6545-4595-82aa-930cb10e6f32");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10e41cc5-24c1-0ea1-0db5-e4b97fc2af39"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1aae8597-4c4b-442d-ba7a-cff2e7ce0ff3", "Admin*123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2edfef70-b0c9-0786-9795-c442636b55fb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51d0d875-7152-425e-b776-acb3f1946826", "Admin*123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43bd1265-cad9-e0a6-2c99-0b0a82652dca"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1ed51e1-d70c-4bab-891a-5666fe366d28", "Admin*123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f1cf39b-62f0-6a93-96d3-c8bd1f8f2ff3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d2858bb-94be-437c-b7c5-cd520321310f", "Admin*123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8923b3aa-bc22-5ac2-6f60-6eb525ffdc56"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5e06f0d-bfb1-4998-9a1b-1511439dd3d4", "Admin*123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0974dc7-ae1e-7e25-44aa-9d5bade97baf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c3e9097-f6a1-4495-9689-1299d950cbca", "Admin*123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7d40ac2-e96f-5977-aa27-a0c99bff6710"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf0c9c87-590c-4957-90a1-81a730dc7168", "Admin*123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("3d254f4c-f968-4cea-bc9d-e3bcd1db9d2b"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("7283636b-f10d-4fa3-a395-5132a3f9c30c"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("7b1f2275-8ebb-491a-a458-1f729c75f80e"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("ae4147e6-49b0-40bd-8980-5658b46166a5"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("b761c364-99f1-4ae8-8216-5387f408541a"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("d3e2f979-f721-44c5-8eb5-097394b72284"));

            migrationBuilder.InsertData(
                table: "Desks",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1211ab66-f499-49e5-9242-08a2d7739575"), "Desk1" },
                    { new Guid("26583fde-99e2-427a-bbc7-581308a7bc60"), "Desk3" },
                    { new Guid("7f6ee906-fd7b-4474-9d86-daba840dbfcf"), "Desk2" },
                    { new Guid("909479f7-86a3-4ea2-b20d-5d8519e4b177"), "Desk6" },
                    { new Guid("c5760b2c-0167-4e7f-be7d-aad4e697ba8b"), "Desk4" },
                    { new Guid("db1b3f57-d2e7-4ea3-a436-5c58243f28e2"), "Desk5" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6844d9d3-a402-5942-755d-38e6d163e820"),
                column: "ConcurrencyStamp",
                value: "5eaab492-4a96-4f8e-9145-d5a1cc34fd8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ce8cc445-2d2e-bd7f-ea1a-fc51c7c6ad26"),
                column: "ConcurrencyStamp",
                value: "3b1e2a6f-6aad-4126-b0e2-eb2d298daec0");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10e41cc5-24c1-0ea1-0db5-e4b97fc2af39"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b6fed5d-9ad9-4538-9b86-5756a1b6c3f2", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2edfef70-b0c9-0786-9795-c442636b55fb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d4e424e-7c04-407c-9b8b-ef4efd1047bb", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43bd1265-cad9-e0a6-2c99-0b0a82652dca"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aaf259ad-84db-4c74-8d0a-67d6d1cb24a1", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f1cf39b-62f0-6a93-96d3-c8bd1f8f2ff3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "065dc0fb-f5d7-496b-89d6-982f2d9c82c1", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8923b3aa-bc22-5ac2-6f60-6eb525ffdc56"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55bf6646-f5b0-41a1-8294-b065744b73a7", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0974dc7-ae1e-7e25-44aa-9d5bade97baf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ef2f53d-9052-433b-b5a1-a10935da0402", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7d40ac2-e96f-5977-aa27-a0c99bff6710"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3af2188-a13a-4818-b479-c81b53a562c2", null });
        }
    }
}
