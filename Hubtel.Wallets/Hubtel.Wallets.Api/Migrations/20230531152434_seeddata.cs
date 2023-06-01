using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hubtel.Wallets.Api.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "PopID", "PopComment", "PopDesc", "PopEntryPerson", "PopNumber", "PopSysDate" },
                values: new object[,]
                {
                    { 1, "Type", "Momo", "Erica", 1, new DateTime(2023, 5, 31, 15, 24, 31, 615, DateTimeKind.Local).AddTicks(5099) },
                    { 2, "Type", "Card", "Erica", 2, new DateTime(2023, 5, 31, 15, 24, 31, 616, DateTimeKind.Local).AddTicks(9433) },
                    { 3, "Account Scheme", "Visa", "Erica", 3, new DateTime(2023, 5, 31, 15, 24, 31, 616, DateTimeKind.Local).AddTicks(9486) },
                    { 4, "Account Scheme", "Master Card", "Erica", 4, new DateTime(2023, 5, 31, 15, 24, 31, 616, DateTimeKind.Local).AddTicks(9490) },
                    { 5, "Account Scheme", "MTN", "Erica", 5, new DateTime(2023, 5, 31, 15, 24, 31, 616, DateTimeKind.Local).AddTicks(9493) },
                    { 6, "Account Scheme", "Vodafone", "Erica", 6, new DateTime(2023, 5, 31, 15, 24, 31, 616, DateTimeKind.Local).AddTicks(9496) },
                    { 7, "Account Scheme", "AirtelTigo", "Erica", 7, new DateTime(2023, 5, 31, 15, 24, 31, 616, DateTimeKind.Local).AddTicks(9499) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "RoleID", "UserName" },
                values: new object[,]
                {
                    { 4, "erica@ana.com", 2, "Erica Ana" },
                    { 3, "mary@jes.com", 1, "Mary Jes" },
                    { 1, "john@lee.com", 2, "John Lee" },
                    { 2, "saray@ham.com", 1, "Sarah Ham" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "ID", "AccountNumber", "AccountScheme", "CreatedAt", "Name", "Owner", "Type", "UserID" },
                values: new object[,]
                {
                    { 6, "0275676548", "AirtelTigo", new DateTime(2023, 5, 31, 15, 24, 31, 660, DateTimeKind.Local).AddTicks(7374), "Sarah Ham", "0267265438", "Momo", 2 },
                    { 1, "0242567894", "MTN", new DateTime(2023, 5, 31, 15, 24, 31, 617, DateTimeKind.Local).AddTicks(4238), "John Lee", "0242567894", "Momo", 1 },
                    { 2, "0506665432", "Vodafone", new DateTime(2023, 5, 31, 15, 24, 31, 660, DateTimeKind.Local).AddTicks(7170), "John Lee", "0554327654", "Momo", 1 },
                    { 3, "4678459777", "Visa", new DateTime(2023, 5, 31, 15, 24, 31, 660, DateTimeKind.Local).AddTicks(7330), "John Lee", "0207654326", "Card", 1 },
                    { 4, "0207777775", "Vodafone", new DateTime(2023, 5, 31, 15, 24, 31, 660, DateTimeKind.Local).AddTicks(7350), "Sarah Ham", "0206543276", "Momo", 2 },
                    { 5, "2345671123", "Visa", new DateTime(2023, 5, 31, 15, 24, 31, 660, DateTimeKind.Local).AddTicks(7362), "Mary Jes", "0267654327", "Card", 3 },
                    { 7, "9996542266", "Master Card", new DateTime(2023, 5, 31, 15, 24, 31, 660, DateTimeKind.Local).AddTicks(7387), "Erica Ana", "0579876543", "Card", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 7);
        }
    }
}
