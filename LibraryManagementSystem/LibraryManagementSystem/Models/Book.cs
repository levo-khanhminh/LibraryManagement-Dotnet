using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string BookCode { get; set; }

        public string Publisher { get; set; }

        [Required]
        public DateTime PublishedYear { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public int TotalCopies { get; set; }

        [Required]
        public int AvailableCopies { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string Avatar { get; set; }

        public string Pdf { get; set; }

        [ForeignKey("CategoryId")] public Category Category { get; set; } = null!;

        [ForeignKey("AuthorId")] public Author Author { get; set; } = null !;

        public Book()
        {
        }
    }
}