using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASystems.DeskReservation.Web.Migrations
{
    public partial class SeedDataUserDataFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("10398b3a-4bf8-4c11-bf1d-dfbacd2f9029"), "Desk1" },
                    { new Guid("22b22603-8add-47c4-9628-230e3b5258f3"), "Desk2" },
                    { new Guid("2b8d1aa8-b1b6-406b-9db3-b80913b44c7d"), "Desk6" },
                    { new Guid("4e4c9cea-f5f8-41d5-8ed1-69be42990eb0"), "Desk3" },
                    { new Guid("7c45b8b6-66de-4a0a-ab72-848253f5b436"), "Desk4" },
                    { new Guid("dfc29186-e73a-4599-9d0e-8fc944a276fd"), "Desk5" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6844d9d3-a402-5942-755d-38e6d163e820"),
                column: "ConcurrencyStamp",
                value: "dadd79c6-69f4-4dc7-8a50-81260754e6bc");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ce8cc445-2d2e-bd7f-ea1a-fc51c7c6ad26"),
                column: "ConcurrencyStamp",
                value: "c7ce239c-b53a-450b-8b7a-255d08c7f419");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10e41cc5-24c1-0ea1-0db5-e4b97fc2af39"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "aa5f8f43-3bf6-4c8c-8dfd-29665089292e", true, "user2@gmail.com", "user2user2", "AQAAAAEAACcQAAAAECWaDLopn1IRduG6d52DFymearv1XGzQhqdRwXwmFYHGWe8SgyZvl5xwOo4/NIzVAg==", "", "user2user2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2edfef70-b0c9-0786-9795-c442636b55fb"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cc1df919-8c56-434d-908c-62aef8541cb3", true, "user6@gmail.com", "user6user6", "AQAAAAEAACcQAAAAELS16pNZcMAGSZ+1bLEnajgXDgZ5FrXZ33gmoBOp875Os5ksYI3XcD0nXObD2blC0g==", "", "user6user6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43bd1265-cad9-e0a6-2c99-0b0a82652dca"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "96f45e8c-668e-4de4-851d-dc3a7dfd31a4", true, "ARMIR.KETA@GMAIL.COM", "ARMIRKETA", "AQAAAAEAACcQAAAAEFxEr0jXdAJC7OY8j212imKjhXhuZKzqmEVgjb6BuDNJKTKgAE3uhsZXaRhZdwlfDg==", "", "armirketa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f1cf39b-62f0-6a93-96d3-c8bd1f8f2ff3"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e6df462e-3166-4dbf-9f6e-785f762f8775", true, "user4@gmail.com", "user4user4", "AQAAAAEAACcQAAAAEDrKfn7mZLQnUgP5F4eMUCnMTUhiq5du1ih8YxJcEwqZ8fI6GL3GGD0kpVC1aSacrw==", "", "user4user4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8923b3aa-bc22-5ac2-6f60-6eb525ffdc56"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e7040064-6caf-4a3c-8d56-0088a3002005", true, "user3@gmail.com", "user3user3", "AQAAAAEAACcQAAAAEEKnZFVWCstuGmecgrEFxoORR99X6zGYQwPcoWyRo0cy15yvST2U4Gv8Zb3dBZevWw==", "", "user3user3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0974dc7-ae1e-7e25-44aa-9d5bade97baf"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "36dc5553-1a92-458c-a6ef-00e3a0e32e91", true, "user5@gmail.com", "user5user5", "AQAAAAEAACcQAAAAEDm4gIPHMWqkmwZuQ2LCdhUBzTbTkVuAvgxSy5Nkj3s1ncolkYyeWWFAcdRARpU+Bg==", "", "user5user5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7d40ac2-e96f-5977-aa27-a0c99bff6710"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e0f00a56-9162-4918-a722-27b0ba995e95", true, "user1@gmail.com", "user1user1", "AQAAAAEAACcQAAAAEMoWRBg1WA7H4hb5I2QZcngweI7g4/LZUm90gJBj1oHrvmPxyU58A0Bnz26Uw6/mPQ==", "", "user1user1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("10398b3a-4bf8-4c11-bf1d-dfbacd2f9029"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("22b22603-8add-47c4-9628-230e3b5258f3"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("2b8d1aa8-b1b6-406b-9db3-b80913b44c7d"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("4e4c9cea-f5f8-41d5-8ed1-69be42990eb0"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("7c45b8b6-66de-4a0a-ab72-848253f5b436"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("dfc29186-e73a-4599-9d0e-8fc944a276fd"));

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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1aae8597-4c4b-442d-ba7a-cff2e7ce0ff3", false, null, null, "Admin*123", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2edfef70-b0c9-0786-9795-c442636b55fb"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "51d0d875-7152-425e-b776-acb3f1946826", false, null, null, "Admin*123", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43bd1265-cad9-e0a6-2c99-0b0a82652dca"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f1ed51e1-d70c-4bab-891a-5666fe366d28", false, null, null, "Admin*123", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f1cf39b-62f0-6a93-96d3-c8bd1f8f2ff3"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9d2858bb-94be-437c-b7c5-cd520321310f", false, null, null, "Admin*123", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8923b3aa-bc22-5ac2-6f60-6eb525ffdc56"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a5e06f0d-bfb1-4998-9a1b-1511439dd3d4", false, null, null, "Admin*123", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0974dc7-ae1e-7e25-44aa-9d5bade97baf"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0c3e9097-f6a1-4495-9689-1299d950cbca", false, null, null, "Admin*123", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7d40ac2-e96f-5977-aa27-a0c99bff6710"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bf0c9c87-590c-4957-90a1-81a730dc7168", false, null, null, "Admin*123", null, null });
        }
    }
}
