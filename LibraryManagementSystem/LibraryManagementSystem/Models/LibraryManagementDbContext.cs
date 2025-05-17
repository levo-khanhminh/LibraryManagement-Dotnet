using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Data
{
    public class LibraryManagementDbContext : DbContext
    {
        public LibraryManagementDbContext(DbContextOptions<LibraryManagementDbContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Carousel> Carousels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();
            modelBuilder.Entity<Carousel>().HasData(
                new Carousel
                {
                    CarouselId = 1,
                    ImageUrl = "/images//carousel_images/sample_carousel_1.jpeg",
                    Title = "Explore New Books",
                    Description = "Discover the latest additions to our collection.",
                    LinkUrl = "/Books/New",
                    Order = 1,
                    IsActive = true,
                },
                new Carousel
                {
                    CarouselId = 2,
                    ImageUrl = "/images/carousel_images/sample_carousel_2.jpeg",
                    Title = "Author Spotlight",
                    Description = "Dive into the works of featured authors.",
                    LinkUrl = "/Authors/Spotlight",
                    Order = 2
                },
                new Carousel
                {
                    CarouselId = 3,
                    ImageUrl = "/images/carousel_images/sample_carousel_3.webp",
                    Title = "Join the Library",
                    Description = "Become a member and start borrowing today!",
                    LinkUrl = "/Account/Register",
                    Order = 3
                }
            );


            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Programming Book",
                    Description = "Books related to programming languages and software development.",
                    CreatedDate = DateTime.Now,
                    Avatar = "/categories/programming_book.jpg",
                    IsActive = true
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Fiction Book",
                    Description = "Books that contain fictional stories and literature.",
                    CreatedDate = DateTime.Now,
                    Avatar = "/categories/fiction.png",
                    IsActive = true
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Science Fiction Book",
                    Description = "Books based on futuristic science and technology concepts.",
                    CreatedDate = DateTime.Now,
                    Avatar = "/categories/science_fiction.jpeg",
                    IsActive = true
                }
            );

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    AuthorId = 1,
                    FirstName = "Robert",
                    LastName = "Martin",
                    DateOfBirth = new DateTime(1952, 12, 5),
                    Biography = "Uncle Bob, software engineer and author of Clean Code.",
                    Nationality = "American",
                    Email = "unclebob@cleancode.com",
                    Website = "https://cleancoder.com",
                    CreatedDate = DateTime.Now
                },
                new Author
                {
                    AuthorId = 2,
                    FirstName = "Bjarne",
                    LastName = "Stroustrup",
                    DateOfBirth = new DateTime(1950, 12, 30),
                    Biography = "Creator of C++ and prolific technical writer.",
                    Nationality = "Danish",
                    Email = "bjarne@cppworld.org",
                    Website = "https://stroustrup.com",
                    CreatedDate = DateTime.Now
                },
                new Author
                {
                    AuthorId = 3,
                    FirstName = "J.K.",
                    LastName = "Rowling",
                    DateOfBirth = new DateTime(1965, 7, 31),
                    Biography = "Author of the Harry Potter fantasy series.",
                    Nationality = "British",
                    Email = "jk@hogwarts.co.uk",
                    Website = "https://jkrowling.com",
                    CreatedDate = DateTime.Now
                },
                new Author
                {
                    AuthorId = 4,
                    FirstName = "George",
                    LastName = "Orwell",
                    DateOfBirth = new DateTime(1903, 6, 25),
                    Biography = "Known for his dystopian fiction works.",
                    Nationality = "British",
                    Email = "george@orwell.net",
                    Website = "https://orwellfoundation.com",
                    CreatedDate = DateTime.Now
                },
                new Author
                {
                    AuthorId = 5,
                    FirstName = "Isaac",
                    LastName = "Asimov",
                    DateOfBirth = new DateTime(1920, 1, 2),
                    Biography = "Prolific science fiction writer and biochemist.",
                    Nationality = "American",
                    Email = "isaac@asimovbooks.com",
                    Website = "https://asimovonline.com",
                    CreatedDate = DateTime.Now
                },
                new Author
                {
                    AuthorId = 6,
                    FirstName = "Arthur",
                    LastName = "Clarke",
                    DateOfBirth = new DateTime(1917, 12, 16),
                    Biography = "Science fiction author of 2001: A Space Odyssey.",
                    Nationality = "British",
                    Email = "arthur@clarkeuniverse.org",
                    Website = "https://clarkefoundation.com",
                    CreatedDate = DateTime.Now
                }
            );
            modelBuilder.Entity<Book>().HasData(
                // Programming Books
                new Book
                {
                    BookId = 1,
                    Title = "Clean Code",
                    Description = "A Handbook of Agile Software Craftsmanship.",
                    BookCode = "PRG001",
                    Publisher = "Prentice Hall",
                    PublishedYear = new DateTime(2008, 8, 1),
                    CategoryId = 1,
                    AuthorId = 1,
                    TotalCopies = 10,
                    AvailableCopies = 10,
                    CreatedDate = DateTime.Now,
                    Avatar = "/books/clean_code.jpeg",
                    Pdf = "pdfs/sample.pdf"
                },
                new Book
                {
                    BookId = 2,
                    Title = "The C++ Programming Language",
                    Description = "Comprehensive guide to C++ by its creator.",
                    BookCode = "PRG002",
                    Publisher = "Addison-Wesley",
                    PublishedYear = new DateTime(2013, 5, 19),
                    CategoryId = 1,
                    AuthorId = 2,
                    TotalCopies = 8,
                    AvailableCopies = 8,
                    CreatedDate = DateTime.Now,
                    Avatar = "/books/theCPP_programing_language.jpeg",
                    Pdf = "pdfs/sample.pdf"
                },
                new Book
                {
                    BookId = 3,
                    Title = "Clean Architecture",
                    Description = "A guide to software structure and design.",
                    BookCode = "PRG003",
                    Publisher = "Prentice Hall",
                    PublishedYear = new DateTime(2017, 9, 20),
                    CategoryId = 1,
                    AuthorId = 1,
                    TotalCopies = 7,
                    AvailableCopies = 7,
                    CreatedDate = DateTime.Now,
                    Avatar = "/books/clean_architecture.jpg",
                    Pdf = "pdfs/sample.pdf"
                },

                // Fiction Books
                new Book
                {
                    BookId = 4,
                    Title = "Harry Potter and the Philosopher's Stone",
                    Description = "The first book in the famous fantasy series.",
                    BookCode = "FIC001",
                    Publisher = "Bloomsbury",
                    PublishedYear = new DateTime(1997, 6, 26),
                    CategoryId = 2,
                    AuthorId = 3,
                    TotalCopies = 12,
                    AvailableCopies = 12,
                    CreatedDate = DateTime.Now,
                    Avatar = "/books/harry_potter_and_philosopher_stones.jpeg",
                    Pdf = "pdfs/sample.pdf"
                },
                new Book
                {
                    BookId = 5,
                    Title = "Harry Potter and the Chamber of Secrets",
                    Description = "The second adventure at Hogwarts.",
                    BookCode = "FIC002",
                    Publisher = "Bloomsbury",
                    PublishedYear = new DateTime(1998, 7, 2),
                    CategoryId = 2,
                    AuthorId = 3,
                    TotalCopies = 10,
                    AvailableCopies = 10,
                    CreatedDate = DateTime.Now,
                    Avatar = "/books/harry_potter_and_chamber_of_secrets.jpg",
                    Pdf = "pdfs/sample.pdf"
                },
                new Book
                {
                    BookId = 6,
                    Title = "1984",
                    Description = "A dystopian novel about totalitarianism.",
                    BookCode = "FIC003",
                    Publisher = "Secker & Warburg",
                    PublishedYear = new DateTime(1949, 6, 8),
                    CategoryId = 2,
                    AuthorId = 4,
                    TotalCopies = 9,
                    AvailableCopies = 9,
                    CreatedDate = DateTime.Now,
                    Avatar = "/books/1984-book.png",
                    Pdf = "pdfs/sample.pdf"
                },

                // Science Fiction Books
                new Book
                {
                    BookId = 7,
                    Title = "Foundation",
                    Description = "A science fiction epic on the fall of a galactic empire.",
                    BookCode = "SCI001",
                    Publisher = "Gnome Press",
                    PublishedYear = new DateTime(1951, 6, 1),
                    CategoryId = 3,
                    AuthorId = 5,
                    TotalCopies = 6,
                    AvailableCopies = 6,
                    CreatedDate = DateTime.Now,
                    Avatar = "/books/foundation.jpg",
                    Pdf = "pdfs/sample.pdf"
                },
                new Book
                {
                    BookId = 8,
                    Title = "I, Robot",
                    Description = "A collection of science fiction short stories.",
                    BookCode = "SCI002",
                    Publisher = "Gnome Press",
                    PublishedYear = new DateTime(1950, 12, 2),
                    CategoryId = 3,
                    AuthorId = 5,
                    TotalCopies = 5,
                    AvailableCopies = 5,
                    CreatedDate = DateTime.Now,
                    Avatar = "/books/IRobot.jpg",
                    Pdf = "pdfs/sample.pdf"
                },
                new Book
                {
                    BookId = 9,
                    Title = "2001: A Space Odyssey",
                    Description = "A novel about humanity’s place in the universe.",
                    BookCode = "SCI003",
                    Publisher = "Hutchinson",
                    PublishedYear = new DateTime(1968, 7, 11),
                    CategoryId = 3,
                    AuthorId = 6,
                    TotalCopies = 4,
                    AvailableCopies = 4,
                    CreatedDate = DateTime.Now,
                    Avatar = "/books/space_odyssey.jpg",
                    Pdf = "pdfs/sample.pdf"
                }
            );
        }
    }
}