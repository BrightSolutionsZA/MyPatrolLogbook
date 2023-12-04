using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MyPatrolLogbook.Models
{
    public class RoleEdit
    {
        // Variables used when modifying the roles of users
        public IdentityRole Role { get; set; }
        public IEnumerable<ApplicationUser> Members { get; set; }
        public IEnumerable<ApplicationUser> NonMembers { get; set; }
    }
}