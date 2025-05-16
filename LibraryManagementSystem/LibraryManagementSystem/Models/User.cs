using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LibraryManagementSystem.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }  // Auto-incremented primary key

        [Required]
        [StringLength(200)]
        public string FullName { get; set; }  // User's full name

        public string Description { get; set; }  // Bio, interests, etc.

        [Required]
        public string Password { get; set; }  // Hashed password

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }  // Unique email address

        [Required]
        [Phone]
        [StringLength(20, MinimumLength = 8)]
        public string Phone { get; set; }  // Contact number

        public string Address { get; set; }  // Physical address

        public int Status { get; set; }  // User status (e.g., active, banned, etc.)

        [Required]
        public DateTime CreatedDate { get; set; }  // Registration date

        [Required]
        public string UserCode { get; set; }  // Internal unique code

        public bool IsLocked { get; set; }  // Account locked (true = locked)

        public bool IsDeleted { get; set; }  // Soft delete flag

        public bool IsActive { get; set; }  // Activation status

        public string ActiveCode { get; set; }  // Email verification code

        public string Avatar { get; set; }  // File path to user's avatar image

        public User()
        {
            
        }
    }
}