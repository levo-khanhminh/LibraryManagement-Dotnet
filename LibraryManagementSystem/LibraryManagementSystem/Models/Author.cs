using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string Biography { get; set; }

        [StringLength(100)]
        public string Nationality { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Url]
        [StringLength(100)]
        public string Website { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
        public ICollection<Book> Books { get; set; } = new List<Book>();
        public Author()
        {
            
        }
    }
}