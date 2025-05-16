using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddCarouselImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Carousels",
                columns: new[] { "CarouselId", "CreatedDate", "Description", "ImageUrl", "IsActive", "LinkUrl", "Order", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 16, 13, 8, 35, 740, DateTimeKind.Local).AddTicks(8649), "Discover the latest additions to our collection.", "/carousel_images/sample_carousel_1.jpeg", true, "/Books/New", 1, "Explore New Books", null },
                    { 2, new DateTime(2025, 5, 16, 13, 8, 35, 740, DateTimeKind.Local).AddTicks(8693), "Dive into the works of featured authors.", "/carousel_images/sample_carousel_2.jpeg", true, "/Authors/Spotlight", 2, "Author Spotlight", null },
                    { 3, new DateTime(2025, 5, 16, 13, 8, 35, 740, DateTimeKind.Local).AddTicks(8696), "Become a member and start borrowing today!", "/carousel_images/sample_carousel_3.webp", true, "/Account/Register", 3, "Join the Library", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carousels",
                keyColumn: "CarouselId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carousels",
                keyColumn: "CarouselId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Carousels",
                keyColumn: "CarouselId",
                keyValue: 3);
        }
    }
}
