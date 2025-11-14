using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurent_Ordering_System.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuItemId { get; set; }

        // FK to Category
        [Required]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(150)]
        public string ItemName { get; set; } = null!;

        [MaxLength(500)]
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal BasePrice { get; set; }

        [MaxLength(255)]
        public string? ImageUrl { get; set; }

        // Could be a comma-separated list, JSON, etc. depending on how you handle it
        [MaxLength(500)]
        public string? Ingredients { get; set; }

        public bool IsAvailable { get; set; } = true;

        public bool HasModifiers { get; set; }

        // FK to User (creator)
        [Required]
        public int CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime? ModifiedDate { get; set; }

        // Navigation
        public Category? Category { get; set; }

        public User? CreatedByUser { get; set; }
    }
}
