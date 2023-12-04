using Microsoft.AspNetCore.Mvc;
using MyPatrolLogbook.Models;
using System.ComponentModel.DataAnnotations;

namespace MyPatrolLogbook.ViewModels
{
    public class CommunityServiceListViewModel
    {
        public IEnumerable<CommunityService>? Projects { get; set; }
        public IEnumerable<ApplicationUser>? PatrolMembers { get; set; }

        public IEnumerable<Patrol>? Patrols { get; set; }

        [Required]
        [Display(Name = "Project Name")]
        public string? NameOfProject { get; set; }

		[Required]
		[Display(Name = "Permit ID")]
		public string? PermitID { get; set; }

		[Required]
        [Display(Name = "Start Date")]
        public DateTime? StartDateAndTime { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime? EndDateAndTime { get; set; }

        [Required]
        [Display(Name = "Venue Name")]
        public string? NameOfVenue { get; set; }

        [Required]
        [Display(Name = "Overall Hours")]
        public int? OverallHours { get; set; }

        [Required]
        [Display(Name = " Project Description")]
        public string? DescriptionOfProject { get; set; }

        [Required]
        [Display(Name = "Attendance")]
        public List<string>? SelectedScouts { get; set; }

		[BindProperty(SupportsGet = true)]
        public DateTime StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; }
    }
}
