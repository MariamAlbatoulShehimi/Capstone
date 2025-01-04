using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Capstone.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class companyRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "beirut", "Aya", "1212", "l", "borj" },
                    { 2, "beirut", "Ali", "1444", "ll", "beer abed" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 1, 1, 19, 7, 28, 627, DateTimeKind.Local).AddTicks(8684));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 1, 1, 18, 27, 17, 354, DateTimeKind.Local).AddTicks(7396));
        }
    }
}
