using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreData.Migrations
{
    public partial class fluentMapCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreateDate", "CreateName", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 28, 16, 24, 49, 250, DateTimeKind.Local).AddTicks(7363), "Bülent", "Kategori açıklası", true, "Teknoloji" },
                    { 2, new DateTime(2022, 3, 28, 16, 24, 49, 251, DateTimeKind.Local).AddTicks(4485), "Bülent", "Telefon açıklası", true, "Telefon" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreateDate", "CreateName", "CustomerType", "IsActive" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 28, 16, 24, 49, 255, DateTimeKind.Local).AddTicks(4866), "Admin", "User", true },
                    { 2, new DateTime(2022, 3, 28, 16, 24, 49, 255, DateTimeKind.Local).AddTicks(5160), "Admin", "Admin", true }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreateDate", "CreateName", "Email", "FirstName", "ImageUrl", "IsActive", "LastName", "Password", "RoleID" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 16, 24, 49, 253, DateTimeKind.Local).AddTicks(2568), "Admin", "ayl@gmail.com", "Aylin", "asd.jpg", true, "Kırnmızı", "123", 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreateDate", "CreateName", "Email", "FirstName", "ImageUrl", "IsActive", "LastName", "Password", "RoleID" },
                values: new object[] { 2, new DateTime(2022, 3, 28, 16, 24, 49, 253, DateTimeKind.Local).AddTicks(3657), "Admin", "mehmet@gmail.com", "Mehmet", "asdqwerty.jpg", true, "Yeşil", "123", 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreateDate", "CreateName", "CustomerID", "Description", "IsActive", "Name", "Price", "Stock" },
                values: new object[] { 1, 1, new DateTime(2022, 3, 28, 16, 24, 49, 254, DateTimeKind.Local).AddTicks(7064), "Admin", 1, "İphone 13 tüm özellikleri", true, "İphone13", 19000m, 1000 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreateDate", "CreateName", "CustomerID", "Description", "IsActive", "Name", "Price", "Stock" },
                values: new object[] { 2, 2, new DateTime(2022, 3, 28, 16, 24, 49, 254, DateTimeKind.Local).AddTicks(7086), "Admin", 2, "S20 tüm özellikleri", true, "Samsung S20", 12000m, 100 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
