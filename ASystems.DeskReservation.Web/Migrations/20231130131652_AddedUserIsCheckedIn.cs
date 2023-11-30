using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASystems.DeskReservation.Web.Migrations
{
    public partial class AddedUserIsCheckedIn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "CheckedIn",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Desks",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("11f940ad-086c-4498-a8f8-f9db7ea90f1b"), "Desk4" },
                    { new Guid("13b6cd32-f22f-481e-8c3c-1dbeb62fc8fd"), "Desk1" },
                    { new Guid("1cb56f4b-a7e3-4936-bebb-192140d8f5ee"), "Desk6" },
                    { new Guid("2f87db24-73ca-44d3-83cd-ce18b6881150"), "Desk5" },
                    { new Guid("9d922658-5287-4954-a5b4-bb2a015e8716"), "Desk3" },
                    { new Guid("b326520a-6a97-4460-a770-b082637b7dbd"), "Desk2" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6844d9d3-a402-5942-755d-38e6d163e820"),
                column: "ConcurrencyStamp",
                value: "6d28a81a-ee9a-47b5-b42e-4deb4cb7a3ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ce8cc445-2d2e-bd7f-ea1a-fc51c7c6ad26"),
                column: "ConcurrencyStamp",
                value: "4e668d7d-54c8-41f0-8e3b-12dd2d2ccbb4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10e41cc5-24c1-0ea1-0db5-e4b97fc2af39"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df6b1ee3-a69a-46bf-88bc-01b3320a19b5", "AQAAAAEAACcQAAAAEJPmQ82mO/R0DMeup5ukLHniDx+DCmM1tT49NC1y2dkDbnqqbtP87gsOG1OpnCiIuw==", "588fd0b9-8e30-463f-88d5-dc637bdde0cc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2edfef70-b0c9-0786-9795-c442636b55fb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b7bf830-d43e-4238-a822-34b13bedce6f", "AQAAAAEAACcQAAAAEBGoJFLV9NeFz0IGDw4CVazxF3u6KzIQ7S2M6rcaOVoIMGN+NQUrUiO4ohD+iJj5jw==", "f0397608-3a81-40fc-b074-c1de86847468" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43bd1265-cad9-e0a6-2c99-0b0a82652dca"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8028a9b1-cb1a-496d-863c-1563b24ac76c", "AQAAAAEAACcQAAAAEFnH2EbWRJ4NF9YySZw4JrdrliZZ8SLYMApAGIoQ0q94uk+rAEf0BQeawW4b//ZnFA==", "aceaf6b2-bff3-4967-8b2f-d9f08aabc38a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f1cf39b-62f0-6a93-96d3-c8bd1f8f2ff3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b713b59f-40d9-48d2-be35-25a9b2305ccf", "AQAAAAEAACcQAAAAEJFeVIgq1IEP4Gh1EX0+DaoMSdgLkaqpvcVlDM7hBMuG6Vpyvz8uGvmiY1bFkLYRLQ==", "e52e830b-4940-42ec-9044-7ff99b31ede6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8923b3aa-bc22-5ac2-6f60-6eb525ffdc56"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12b97b37-878e-4bf7-b1e5-d64e2a82fe8e", "AQAAAAEAACcQAAAAED1DP26iy02zPn+hMqCtdL6cZTs0Wj+DFuXvCD6Qrbr6bvzOpRYlGEk0WsWgPDJAhg==", "226453bd-d7d8-4be1-975e-d4c36c6b2015" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0974dc7-ae1e-7e25-44aa-9d5bade97baf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9dec0cb-4639-43c3-914c-d0cada1dd939", "AQAAAAEAACcQAAAAEJlE5zzfqXPFYhQmGjovZ2JTIK/FSEbP0wpcvkyI5WwZulawp7yYqxf+hPkTu6tGaw==", "b09f4780-b986-43d2-8773-08407848939b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7d40ac2-e96f-5977-aa27-a0c99bff6710"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "796b3e35-a84f-416d-ae3d-757f5a486a3a", "AQAAAAEAACcQAAAAEAqTuEtXNfzdRanrS/ajFRikooeSy0FJiwJFiRM3G86e47PgXvA24x+pupoxJgIPdw==", "1ced31b6-f5b3-4f4f-ae6b-0900962323a1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("11f940ad-086c-4498-a8f8-f9db7ea90f1b"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("13b6cd32-f22f-481e-8c3c-1dbeb62fc8fd"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("1cb56f4b-a7e3-4936-bebb-192140d8f5ee"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("2f87db24-73ca-44d3-83cd-ce18b6881150"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("9d922658-5287-4954-a5b4-bb2a015e8716"));

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: new Guid("b326520a-6a97-4460-a770-b082637b7dbd"));

            migrationBuilder.DropColumn(
                name: "CheckedIn",
                table: "Users");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e623d59-d80a-449d-af00-07e34f2cba79", "AQAAAAEAACcQAAAAEIDTG9ABKJYUThPSrBFOFZn33be14zkjBbfPKBKCd7TmlcJmkOr5bdnfR1vAXlK9Vg==", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2edfef70-b0c9-0786-9795-c442636b55fb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "621db1ac-31b1-49f8-8fb6-2522e51900b5", "AQAAAAEAACcQAAAAEP9S5rc+dOceh5KRHVj+gJni9+PHdWSOZUZV7t5IWtcFMa2O4cCeE4nLAvjGSgGOgg==", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43bd1265-cad9-e0a6-2c99-0b0a82652dca"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1461e353-583f-4083-85d2-710450913d25", "AQAAAAEAACcQAAAAECsPJ3pN8ce1am/fWHucY2tbbwLfTf0p6/FN/pXvZKIUWGSIWb0hOLlBDDxUQ7bDAQ==", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f1cf39b-62f0-6a93-96d3-c8bd1f8f2ff3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0131c0ad-4763-436c-adb1-0048701cfcb1", "AQAAAAEAACcQAAAAELLMeIvz2gXWjTn2OSRWkZ9PYHFTfVWp7sxix/0cuOwMCXGMmAmzvLYpTVScYk0AFA==", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8923b3aa-bc22-5ac2-6f60-6eb525ffdc56"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9294afe3-d304-4cf2-83a8-9028afc401e9", "AQAAAAEAACcQAAAAEC7xMbqUGrJPUU6ZAhK90+earJbeqWX9a9T/EJnZ+nmVQRX7WNkRTWKcrmJlL7NmVQ==", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0974dc7-ae1e-7e25-44aa-9d5bade97baf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "926361d7-ae26-4e64-8cd6-bb91d47d7cdc", "AQAAAAEAACcQAAAAEJaaAh9p53WXnYuWVmrMF2gZ7Z5FaYENoFFG8FC+c7ETbQY417v6zAlJT/ZDMbF9dA==", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7d40ac2-e96f-5977-aa27-a0c99bff6710"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4ebbd7f-8def-4c48-af81-adda8d534fc6", "AQAAAAEAACcQAAAAEDpIMLdw/wJarC9MameHTQ+od4fwiwaJresC9QLyJCYSl188cMNN0Jaz+CXCMzCDbQ==", "" });
        }
    }
}
