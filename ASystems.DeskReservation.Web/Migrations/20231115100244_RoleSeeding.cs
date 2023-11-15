using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASystems.DeskReservation.Web.Migrations
{
    public partial class RoleSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("a4fb4ff4-b6a2-4416-8d12-7ccb30ce4afe"), "15874bca-51b5-4c36-8a13-5f700ff1d313", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("b3f46b50-1bb3-4b3c-905b-4c7fc0ca1f92"), "6992df16-9725-48a3-8daf-638271236fd0", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4fb4ff4-b6a2-4416-8d12-7ccb30ce4afe"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b3f46b50-1bb3-4b3c-905b-4c7fc0ca1f92"));
        }
    }
}
