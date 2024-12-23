using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Capstone.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Categories",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        DisplayOrder = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Categories", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Products",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        QuantityAvailable = table.Column<int>(type: "int", nullable: false),
            //        Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        IsNew = table.Column<bool>(type: "bit", nullable: false),
            //        IsDonated = table.Column<bool>(type: "bit", nullable: false),
            //        AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
            //        Condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IsActive = table.Column<bool>(type: "bit", nullable: false),
            //        ListPrice = table.Column<double>(type: "float", nullable: false),
            //        CategoryId = table.Column<int>(type: "int", nullable: false),
            //        ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Products", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Products_Categories_CategoryId",
            //            column: x => x.CategoryId,
            //            principalTable: "Categories",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.InsertData(
            //    table: "Categories",
            //    columns: new[] { "Id", "DisplayOrder", "Name" },
            //    values: new object[,]
            //    {
            //        { 1, 1, "Shelter Assistance" },
            //        { 2, 2, "Food Support" },
            //        { 3, 3, "Essential Supplies" }
            //    });

            //migrationBuilder.InsertData(
            //    table: "Products",
            //    columns: new[] { "Id", "AddedDate", "CategoryId", "Condition", "Description", "ImageUrl", "IsActive", "IsDonated", "IsNew", "ListPrice", "Location", "Name", "QuantityAvailable" },
            //    values: new object[,]
            //    {
            //        { 1, new DateTime(2024, 12, 19, 19, 52, 44, 149, DateTimeKind.Local).AddTicks(1652), 1, "New", "Warm and soft blanket for cold weather.", " ", true, true, true, 0.0, "Beirut", "Blanket", 50 },
            //        { 2, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "New", "Pack of canned food for long shelf life.", " ", true, true, true, 0.0, "Tripoli", "Canned Food Package", 100 },
            //        { 3, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "New", "Comfortable pillow for better sleep.", " ", true, false, true, 10.75, "Zahle", "Pillow", 30 },
            //        { 4, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Used", "Lightweight sleeping bag suitable for outdoor use.", " ", true, false, false, 8.9900000000000002, "Bekaa Valley", "Sleeping Bag", 20 },
            //        { 5, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "New", "Essential hygiene products for personal care.", " ", true, true, true, 0.0, "Sidon", "Hygiene Kit", 50 },
            //        { 6, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Good", "Warm jacket for cold seasons.", " ", true, false, false, 15.5, "Baalbek", "Winter Jacket", 40 }
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Products_CategoryId",
            //    table: "Products",
            //    column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Products");

            //migrationBuilder.DropTable(
            //    name: "Categories");
        }
    }
}
