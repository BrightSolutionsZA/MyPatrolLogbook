using Microsoft.AspNetCore.Mvc;
using MyPatrolLogbook.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyPatrolLogbook.ViewModels
{
    public class RegisterListViewModel
    {
        public IEnumerable<Register>? Registers { get; set; }
        public IEnumerable<ApplicationUser>? PatrolMembers { get; set; }

        public IEnumerable<Patrol>? Patrols { get; set; }

        [Required]
        [Display(Name = "Meeting Date")]
        public DateTime? MeetingAttendanceDate { get; set; }

		[Required]
        [Display(Name = "Attendance")]
        public List<string>? MeetingAttendanceScouts { get; set; }

		[BindProperty(SupportsGet = true)]
        public DateTime StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; }

    }
}
