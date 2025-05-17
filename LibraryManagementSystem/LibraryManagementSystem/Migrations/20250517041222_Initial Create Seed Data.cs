using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Biography", "CreatedDate", "DateOfBirth", "Email", "FirstName", "LastName", "Nationality", "Website" },
                values: new object[,]
                {
                    { 1, "Uncle Bob, software engineer and author of Clean Code.", new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6007), new DateTime(1952, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "unclebob@cleancode.com", "Robert", "Martin", "American", "https://cleancoder.com" },
                    { 2, "Creator of C++ and prolific technical writer.", new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6012), new DateTime(1950, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "bjarne@cppworld.org", "Bjarne", "Stroustrup", "Danish", "https://stroustrup.com" },
                    { 3, "Author of the Harry Potter fantasy series.", new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6015), new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "jk@hogwarts.co.uk", "J.K.", "Rowling", "British", "https://jkrowling.com" },
                    { 4, "Known for his dystopian fiction works.", new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6019), new DateTime(1903, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "george@orwell.net", "George", "Orwell", "British", "https://orwellfoundation.com" },
                    { 5, "Prolific science fiction writer and biochemist.", new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6022), new DateTime(1920, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "isaac@asimovbooks.com", "Isaac", "Asimov", "American", "https://asimovonline.com" },
                    { 6, "Science fiction author of 2001: A Space Odyssey.", new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6026), new DateTime(1917, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "arthur@clarkeuniverse.org", "Arthur", "Clarke", "British", "https://clarkefoundation.com" }
                });

            migrationBuilder.InsertData(
                table: "Carousels",
                columns: new[] { "CarouselId", "CreatedDate", "Description", "ImageUrl", "IsActive", "LinkUrl", "Order", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(5750), "Discover the latest additions to our collection.", "/images//carousel_images/sample_carousel_1.jpeg", true, "/Books/New", 1, "Explore New Books", null },
                    { 2, new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(5807), "Dive into the works of featured authors.", "/images/carousel_images/sample_carousel_2.jpeg", false, "/Authors/Spotlight", 2, "Author Spotlight", null },
                    { 3, new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(5810), "Become a member and start borrowing today!", "/images/carousel_images/sample_carousel_3.webp", false, "/Account/Register", 3, "Join the Library", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Avatar", "CreatedDate", "Description", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "/categories/programming_book.jpg", new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(5963), "Books related to programming languages and software development.", true, "Programming Book", null },
                    { 2, "/categories/fiction.png", new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(5967), "Books that contain fictional stories and literature.", true, "Fiction Book", null },
                    { 3, "/categories/science_fiction.jpeg", new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(5970), "Books based on futuristic science and technology concepts.", true, "Science Fiction Book", null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "AvailableCopies", "Avatar", "BookCode", "CategoryId", "CreatedDate", "Description", "Pdf", "PublishedYear", "Publisher", "Title", "TotalCopies" },
                values: new object[,]
                {
                    { 1, 1, 10, "/books/clean_code.jpeg", "PRG001", 1, new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6400), "A Handbook of Agile Software Craftsmanship.", "pdfs/sample.pdf", new DateTime(2008, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prentice Hall", "Clean Code", 10 },
                    { 2, 2, 8, "/books/theCPP_programing_language.jpeg", "PRG002", 1, new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6435), "Comprehensive guide to C++ by its creator.", "pdfs/sample.pdf", new DateTime(2013, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Addison-Wesley", "The C++ Programming Language", 8 },
                    { 3, 1, 7, "/books/clean_architecture.jpg", "PRG003", 1, new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6452), "A guide to software structure and design.", "pdfs/sample.pdf", new DateTime(2017, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prentice Hall", "Clean Architecture", 7 },
                    { 4, 3, 12, "/books/harry_potter_and_philosopher_stones.jpeg", "FIC001", 2, new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6456), "The first book in the famous fantasy series.", "pdfs/sample.pdf", new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloomsbury", "Harry Potter and the Philosopher's Stone", 12 },
                    { 5, 3, 10, "/books/harry_potter_and_chamber_of_secrets.jpg", "FIC002", 2, new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6468), "The second adventure at Hogwarts.", "pdfs/sample.pdf", new DateTime(1998, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloomsbury", "Harry Potter and the Chamber of Secrets", 10 },
                    { 6, 4, 9, "/books/1984-book.png", "FIC003", 2, new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6472), "A dystopian novel about totalitarianism.", "pdfs/sample.pdf", new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secker & Warburg", "1984", 9 },
                    { 7, 5, 6, "/books/foundation.jpg", "SCI001", 3, new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6486), "A science fiction epic on the fall of a galactic empire.", "pdfs/sample.pdf", new DateTime(1951, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gnome Press", "Foundation", 6 },
                    { 8, 5, 5, "/books/IRobot.jpg", "SCI002", 3, new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6490), "A collection of science fiction short stories.", "pdfs/sample.pdf", new DateTime(1950, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gnome Press", "I, Robot", 5 },
                    { 9, 6, 4, "/books/space_odyssey.jpg", "SCI003", 3, new DateTime(2025, 5, 17, 11, 12, 21, 769, DateTimeKind.Local).AddTicks(6502), "A novel about humanity’s place in the universe.", "pdfs/sample.pdf", new DateTime(1968, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hutchinson", "2001: A Space Odyssey", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

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

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
