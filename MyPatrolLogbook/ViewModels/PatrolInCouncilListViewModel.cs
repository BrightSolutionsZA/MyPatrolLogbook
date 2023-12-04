using Microsoft.AspNetCore.Mvc;
using MyPatrolLogbook.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyPatrolLogbook.ViewModels
{
    public class PatrolInCouncilListViewModel
    {
        public IEnumerable<PatrolInCouncil>? PatrolInCouncils { get; set; }
        public IEnumerable<ApplicationUser>? PatrolMembers { get; set; }

        public IEnumerable<Patrol>? Patrols { get; set; }

        [Required]
        [Display(Name = "Patrol In Council Date")]
        public DateTime? DateofPIC { get; set; }

        [Required]
        [Display(Name = "Patrol In Council Matters Discussed")]
        public string? PointsDiscussedInPIC { get; set; }

        [Required]
        [Display(Name = "Patrol In Council Description")]
        public string? DescriptionOfPIC { get; set; }

        [Required]
        [Display(Name = "Attendance")]
        public List<string>? AttendanceAtPIC { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; }
    }
}
