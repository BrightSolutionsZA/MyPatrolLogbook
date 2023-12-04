using System.ComponentModel.DataAnnotations;

namespace MyPatrolLogbook.Models
{
    public class RoleModification
    {
        // Variables used when modifying the roles of user
        [Required]
        public string RoleName { get; set; }

        public string RoleId { get; set; }

        public string[]? AddIds { get; set; }

        public string[]? DeleteIds { get; set; }
    }
}
