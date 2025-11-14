using System.ComponentModel.DataAnnotations;

namespace Restaurent_Ordering_System.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; } = null!;

        [MaxLength(255)]
        public string? Description { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsActive { get; set; } = true;

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime? ModifiedDate { get; set; }

        // Navigation
        public ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
    }
}
