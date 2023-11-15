using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASystems.DeskReservation.Web.Migrations
{
    public partial class SeedDataUserNameFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0c35170b-87b5-4a6b-8f5f-6c853f6e1b46"), "Desk4" },
                    { new Guid("0cb8262b-ff8e-4d08-b3f5-4212b658f8e7"), "Desk2" },
                    { new Guid("3662bfc3-a4d3-4ca0-8dca-cc2a357fff17"), "Desk3" },
                    { new Guid("5cd33a8a-8257-4966-800d-808b6b8695b4"), "Desk5" },
                    { new Guid("a7102e9d-1795-4cff-8782-64c57f136a25"), "Desk6" },
                    { new Guid("e24bd543-0261-40fb-86f7-ef66c29429ac"), "Desk1" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6844d9d3-a402-5942-755d-38e6d163e820"),
                column: "ConcurrencyStamp",
                value: "c3fde7dc-2d62-46c4-9cc7-35cb23a31d51");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ce8cc445-2d2e-bd7f-ea1a-fc51c7c6ad26"),
                column: "ConcurrencyStamp",
                value: "6be5289f-7037-48fe-b124-760641f7f0fd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10e41cc5-24c1-0ea1-0db5-e4b97fc2af39"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "1e623d59-d80a-449d-af00-07e34f2cba79", "user2@gmail.com", "AQAAAAEAACcQAAAAEIDTG9ABKJYUThPSrBFOFZn33be14zkjBbfPKBKCd7TmlcJmkOr5bdnfR1vAXlK9Vg==", "user2@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2edfef70-b0c9-0786-9795-c442636b55fb"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "621db1ac-31b1-49f8-8fb6-2522e51900b5", "user6@gmail.com", "AQAAAAEAACcQAAAAEP9S5rc+dOceh5KRHVj+gJni9+PHdWSOZUZV7t5IWtcFMa2O4cCeE4nLAvjGSgGOgg==", "user6@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43bd1265-cad9-e0a6-2c99-0b0a82652dca"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "1461e353-583f-4083-85d2-710450913d25", "ARMIR.KETA@GMAIL.COM", "AQAAAAEAACcQAAAAECsPJ3pN8ce1am/fWHucY2tbbwLfTf0p6/FN/pXvZKIUWGSIWb0hOLlBDDxUQ7bDAQ==", "armir.keta@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f1cf39b-62f0-6a93-96d3-c8bd1f8f2ff3"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "0131c0ad-4763-436c-adb1-0048701cfcb1", "user4@gmail.com", "AQAAAAEAACcQAAAAELLMeIvz2gXWjTn2OSRWkZ9PYHFTfVWp7sxix/0cuOwMCXGMmAmzvLYpTVScYk0AFA==", "user4@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8923b3aa-bc22-5ac2-6f60-6eb525ffdc56"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "9294afe3-d304-4cf2-83a8-9028afc401e9", "user3@gmail.com", "AQAAAAEAACcQAAAAEC7xMbqUGrJPUU6ZAhK90+earJbeqWX9a9T/EJnZ+nmVQRX7WNkRTWKcrmJlL7NmVQ==", "user3@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0974dc7-ae1e-7e25-44aa-9d5bade97baf"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "926361d7-ae26-4e64-8cd6-bb91d47d7cdc", "user5@gmail.com", "AQAAAAEAACcQAAAAEJaaAh9p53WXnYuWVmrMF2gZ7Z5FaYENoFFG8FC+c7ETbQY417v6zAlJT/ZDMbF9dA==", "user5@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7d40ac2-e96f-5977-aa27-a0c99bff6710"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "a4ebbd7f-8def-4c48-af81-adda8d534fc6", "user1@gmail.com", "AQAAAAEAACcQAAAAEDpIMLdw/wJarC9MameHTQ+od4fwiwaJresC9QLyJCYSl188cMNN0Jaz+CXCMzCDbQ==", "user1@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("0c35170b-87b5-4a6b-8f5f-6c853f6e1b46"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("0cb8262b-ff8e-4d08-b3f5-4212b658f8e7"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("3662bfc3-a4d3-4ca0-8dca-cc2a357fff17"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("5cd33a8a-8257-4966-800d-808b6b8695b4"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("a7102e9d-1795-4cff-8782-64c57f136a25"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("e24bd543-0261-40fb-86f7-ef66c29429ac"));

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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "aa5f8f43-3bf6-4c8c-8dfd-29665089292e", "user2user2", "AQAAAAEAACcQAAAAECWaDLopn1IRduG6d52DFymearv1XGzQhqdRwXwmFYHGWe8SgyZvl5xwOo4/NIzVAg==", "user2user2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2edfef70-b0c9-0786-9795-c442636b55fb"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "cc1df919-8c56-434d-908c-62aef8541cb3", "user6user6", "AQAAAAEAACcQAAAAELS16pNZcMAGSZ+1bLEnajgXDgZ5FrXZ33gmoBOp875Os5ksYI3XcD0nXObD2blC0g==", "user6user6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43bd1265-cad9-e0a6-2c99-0b0a82652dca"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "96f45e8c-668e-4de4-851d-dc3a7dfd31a4", "ARMIRKETA", "AQAAAAEAACcQAAAAEFxEr0jXdAJC7OY8j212imKjhXhuZKzqmEVgjb6BuDNJKTKgAE3uhsZXaRhZdwlfDg==", "armirketa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f1cf39b-62f0-6a93-96d3-c8bd1f8f2ff3"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "e6df462e-3166-4dbf-9f6e-785f762f8775", "user4user4", "AQAAAAEAACcQAAAAEDrKfn7mZLQnUgP5F4eMUCnMTUhiq5du1ih8YxJcEwqZ8fI6GL3GGD0kpVC1aSacrw==", "user4user4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8923b3aa-bc22-5ac2-6f60-6eb525ffdc56"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "e7040064-6caf-4a3c-8d56-0088a3002005", "user3user3", "AQAAAAEAACcQAAAAEEKnZFVWCstuGmecgrEFxoORR99X6zGYQwPcoWyRo0cy15yvST2U4Gv8Zb3dBZevWw==", "user3user3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0974dc7-ae1e-7e25-44aa-9d5bade97baf"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "36dc5553-1a92-458c-a6ef-00e3a0e32e91", "user5user5", "AQAAAAEAACcQAAAAEDm4gIPHMWqkmwZuQ2LCdhUBzTbTkVuAvgxSy5Nkj3s1ncolkYyeWWFAcdRARpU+Bg==", "user5user5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7d40ac2-e96f-5977-aa27-a0c99bff6710"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "e0f00a56-9162-4918-a722-27b0ba995e95", "user1user1", "AQAAAAEAACcQAAAAEMoWRBg1WA7H4hb5I2QZcngweI7g4/LZUm90gJBj1oHrvmPxyU58A0Bnz26Uw6/mPQ==", "user1user1" });
        }
    }
}
