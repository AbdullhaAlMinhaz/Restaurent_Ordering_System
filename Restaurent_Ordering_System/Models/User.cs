using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Restaurent_Ordering_System.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; } = null!;

        // Store hashed password only
        [Required]
        [MaxLength(255)]
        public string Password { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }

        // FK to Role
        [Required]
        public int RoleId { get; set; }

        public bool IsActive { get; set; } = true;

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime? LastLoginDate { get; set; }

        // Navigation properties
        public Role? Role { get; set; }

        public ICollection<MenuItem> CreatedMenuItems { get; set; } = new List<MenuItem>();
    }
}
