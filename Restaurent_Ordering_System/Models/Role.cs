using System.ComponentModel.DataAnnotations;

namespace Restaurent_Ordering_System.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [MaxLength(50)]
        public string RoleName { get; set; } = null!;  // e.g. Admin/Manager/Waiter/Chef/Customer

        // Navigation
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
