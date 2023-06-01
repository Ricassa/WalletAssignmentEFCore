using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hubtel.Wallets.Api.Migrations
{
    public partial class changedseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 1,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 41, 45, 567, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 2,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 41, 45, 568, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 3,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 41, 45, 568, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 4,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 41, 45, 568, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 5,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 41, 45, 568, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 6,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 41, 45, 568, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 7,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 41, 45, 568, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 15, 41, 45, 568, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 15, 41, 45, 628, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AccountNumber", "CreatedAt" },
                values: new object[] { "467845", new DateTime(2023, 5, 31, 15, 41, 45, 628, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 15, 41, 45, 628, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AccountNumber", "CreatedAt" },
                values: new object[] { "234567", new DateTime(2023, 5, 31, 15, 41, 45, 628, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 15, 41, 45, 628, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AccountNumber", "CreatedAt" },
                values: new object[] { "999654", new DateTime(2023, 5, 31, 15, 41, 45, 628, DateTimeKind.Local).AddTicks(3097) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 1,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 24, 31, 615, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 2,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 24, 31, 616, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 3,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 24, 31, 616, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 4,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 24, 31, 616, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 5,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 24, 31, 616, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 6,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 24, 31, 616, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "PopID",
                keyValue: 7,
                column: "PopSysDate",
                value: new DateTime(2023, 5, 31, 15, 24, 31, 616, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 15, 24, 31, 617, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 15, 24, 31, 660, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AccountNumber", "CreatedAt" },
                values: new object[] { "4678459777", new DateTime(2023, 5, 31, 15, 24, 31, 660, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 15, 24, 31, 660, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AccountNumber", "CreatedAt" },
                values: new object[] { "2345671123", new DateTime(2023, 5, 31, 15, 24, 31, 660, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 31, 15, 24, 31, 660, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AccountNumber", "CreatedAt" },
                values: new object[] { "9996542266", new DateTime(2023, 5, 31, 15, 24, 31, 660, DateTimeKind.Local).AddTicks(7387) });
        }
    }
}
