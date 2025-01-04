using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Capstone.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 12, 26, 13, 52, 52, 5, DateTimeKind.Local).AddTicks(8356));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2024, 12, 23, 20, 19, 24, 91, DateTimeKind.Local).AddTicks(3527));
        }
    }
}
