using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASystems.DeskReservation.Web.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fb4ff4-b6a2-4416-8d12-7ccb30ce4afe"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b3f46b50-1bb3-4b3c-905b-4c7fc0ca1f92"));

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("6844d9d3-a402-5942-755d-38e6d163e820"), "5eaab492-4a96-4f8e-9145-d5a1cc34fd8b", "User", "USER" },
                    { new Guid("ce8cc445-2d2e-bd7f-ea1a-fc51c7c6ad26"), "3b1e2a6f-6aad-4126-b0e2-eb2d298daec0", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("10e41cc5-24c1-0ea1-0db5-e4b97fc2af39"), 0, "4b6fed5d-9ad9-4538-9b86-5756a1b6c3f2", "user2@gmail.com", false, "User2", "User2", false, null, null, null, null, "0690000000", false, null, false, null },
                    { new Guid("2edfef70-b0c9-0786-9795-c442636b55fb"), 0, "3d4e424e-7c04-407c-9b8b-ef4efd1047bb", "user6@gmail.com", false, "User6", "User6", false, null, null, null, null, "0690000000", false, null, false, null },
                    { new Guid("43bd1265-cad9-e0a6-2c99-0b0a82652dca"), 0, "aaf259ad-84db-4c74-8d0a-67d6d1cb24a1", "armir.keta@gmail.com", false, "Armir", "Keta", false, null, null, null, null, "0695586306", false, null, false, null },
                    { new Guid("7f1cf39b-62f0-6a93-96d3-c8bd1f8f2ff3"), 0, "065dc0fb-f5d7-496b-89d6-982f2d9c82c1", "user4@gmail.com", false, "User4", "User4", false, null, null, null, null, "0690000000", false, null, false, null },
                    { new Guid("8923b3aa-bc22-5ac2-6f60-6eb525ffdc56"), 0, "55bf6646-f5b0-41a1-8294-b065744b73a7", "user3@gmail.com", false, "User3", "User3", false, null, null, null, null, "0690000000", false, null, false, null },
                    { new Guid("b0974dc7-ae1e-7e25-44aa-9d5bade97baf"), 0, "5ef2f53d-9052-433b-b5a1-a10935da0402", "user5@gmail.com", false, "User5", "User5", false, null, null, null, null, "0690000000", false, null, false, null },
                    { new Guid("d7d40ac2-e96f-5977-aa27-a0c99bff6710"), 0, "e3af2188-a13a-4818-b479-c81b53a562c2", "user1@gmail.com", false, "User1", "User1", false, null, null, null, null, "0690000000", false, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6844d9d3-a402-5942-755d-38e6d163e820"), new Guid("10e41cc5-24c1-0ea1-0db5-e4b97fc2af39") },
                    { new Guid("6844d9d3-a402-5942-755d-38e6d163e820"), new Guid("2edfef70-b0c9-0786-9795-c442636b55fb") },
                    { new Guid("ce8cc445-2d2e-bd7f-ea1a-fc51c7c6ad26"), new Guid("43bd1265-cad9-e0a6-2c99-0b0a82652dca") },
                    { new Guid("6844d9d3-a402-5942-755d-38e6d163e820"), new Guid("7f1cf39b-62f0-6a93-96d3-c8bd1f8f2ff3") },
                    { new Guid("6844d9d3-a402-5942-755d-38e6d163e820"), new Guid("8923b3aa-bc22-5ac2-6f60-6eb525ffdc56") },
                    { new Guid("6844d9d3-a402-5942-755d-38e6d163e820"), new Guid("b0974dc7-ae1e-7e25-44aa-9d5bade97baf") },
                    { new Guid("6844d9d3-a402-5942-755d-38e6d163e820"), new Guid("d7d40ac2-e96f-5977-aa27-a0c99bff6710") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6844d9d3-a402-5942-755d-38e6d163e820"), new Guid("10e41cc5-24c1-0ea1-0db5-e4b97fc2af39") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6844d9d3-a402-5942-755d-38e6d163e820"), new Guid("2edfef70-b0c9-0786-9795-c442636b55fb") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ce8cc445-2d2e-bd7f-ea1a-fc51c7c6ad26"), new Guid("43bd1265-cad9-e0a6-2c99-0b0a82652dca") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6844d9d3-a402-5942-755d-38e6d163e820"), new Guid("7f1cf39b-62f0-6a93-96d3-c8bd1f8f2ff3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6844d9d3-a402-5942-755d-38e6d163e820"), new Guid("8923b3aa-bc22-5ac2-6f60-6eb525ffdc56") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6844d9d3-a402-5942-755d-38e6d163e820"), new Guid("b0974dc7-ae1e-7e25-44aa-9d5bade97baf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6844d9d3-a402-5942-755d-38e6d163e820"), new Guid("d7d40ac2-e96f-5977-aa27-a0c99bff6710") });

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

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6844d9d3-a402-5942-755d-38e6d163e820"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ce8cc445-2d2e-bd7f-ea1a-fc51c7c6ad26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10e41cc5-24c1-0ea1-0db5-e4b97fc2af39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2edfef70-b0c9-0786-9795-c442636b55fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43bd1265-cad9-e0a6-2c99-0b0a82652dca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f1cf39b-62f0-6a93-96d3-c8bd1f8f2ff3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8923b3aa-bc22-5ac2-6f60-6eb525ffdc56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0974dc7-ae1e-7e25-44aa-9d5bade97baf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7d40ac2-e96f-5977-aa27-a0c99bff6710"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("a4fb4ff4-b6a2-4416-8d12-7ccb30ce4afe"), "15874bca-51b5-4c36-8a13-5f700ff1d313", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("b3f46b50-1bb3-4b3c-905b-4c7fc0ca1f92"), "6992df16-9725-48a3-8daf-638271236fd0", "Admin", "ADMIN" });
        }
    }
}
