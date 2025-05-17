using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Carousel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarouselId { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string LinkUrl { get; set; }

        [Required]
        public int Order { get; set; }

        public bool IsActive { get; set; } = false;

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? UpdatedDate { get; set; }

        public Carousel()
        {
            
        }

        public Carousel(int carouselId, string imageUrl, string title, string description, string linkUrl, int order)
        {
            CarouselId = carouselId;
            ImageUrl = imageUrl;
            Title = title;
            Description = description;
            LinkUrl = linkUrl;
            Order = order;
        }
    }
}