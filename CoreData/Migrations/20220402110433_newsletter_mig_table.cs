using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreData.Migrations
{
    public partial class newsletter_mig_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewsLetters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CreateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsLetters", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 2, 14, 4, 32, 835, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 2, 14, 4, 32, 836, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 2, 14, 4, 32, 839, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 2, 14, 4, 32, 840, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 2, 14, 4, 32, 844, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 2, 14, 4, 32, 844, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 4, 2, 14, 4, 32, 846, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 4, 2, 14, 4, 32, 846, DateTimeKind.Local).AddTicks(5824));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsLetters");

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
    }
}
