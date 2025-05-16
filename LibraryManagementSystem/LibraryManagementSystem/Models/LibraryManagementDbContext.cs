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
                    ImageUrl = "/carousel_images/sample_carousel_1.jpeg",
                    Title = "Explore New Books",
                    Description = "Discover the latest additions to our collection.",
                    LinkUrl = "/Books/New",
                    Order = 1
                },
                new Carousel
                {
                    CarouselId = 2,
                    ImageUrl = "/carousel_images/sample_carousel_2.jpeg",
                    Title = "Author Spotlight",
                    Description = "Dive into the works of featured authors.",
                    LinkUrl = "/Authors/Spotlight",
                    Order = 2
                },
                new Carousel
                {
                    CarouselId = 3,
                    ImageUrl = "/carousel_images/sample_carousel_3.webp",
                    Title = "Join the Library",
                    Description = "Become a member and start borrowing today!",
                    LinkUrl = "/Account/Register",
                    Order = 3
                }
            );
        }
    }
}