using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreData.Migrations
{
    public partial class evcomp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 1, 22, 45, 59, 84, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 1, 22, 45, 59, 87, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 1, 22, 45, 59, 93, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 1, 22, 45, 59, 93, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 1, 22, 45, 59, 96, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 1, 22, 45, 59, 96, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 1, 22, 45, 59, 98, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 1, 22, 45, 59, 98, DateTimeKind.Local).AddTicks(7974));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 3, 28, 16, 24, 49, 250, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 3, 28, 16, 24, 49, 251, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 3, 28, 16, 24, 49, 253, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 3, 28, 16, 24, 49, 253, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 3, 28, 16, 24, 49, 254, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 3, 28, 16, 24, 49, 254, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 3, 28, 16, 24, 49, 255, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 3, 28, 16, 24, 49, 255, DateTimeKind.Local).AddTicks(5160));
        }
    }
}
