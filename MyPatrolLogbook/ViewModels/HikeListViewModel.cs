using Microsoft.AspNetCore.Mvc;
using MyPatrolLogbook.Models;
using System.ComponentModel.DataAnnotations;

namespace MyPatrolLogbook.ViewModels
{
    public class HikeListViewModel
    {
        public IEnumerable<Hike>? Hikes { get; set; }
        public IEnumerable<ApplicationUser>? PatrolMembers { get; set; }

        public IEnumerable<Patrol>? Patrols { get; set; }

		[Required]
        [Display(Name = "Hike Name")]
        public string? NameOfHike { get; set; }

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
        [Display(Name = "Venue Address")]
        public string? AddressOfVenue { get; set; }

        [Required]
        [Display(Name = "Hike Cost")]
        public int? CostOfHike { get; set; }

		[Required]
        [Display(Name = "Overall Distance")]
        public int? DistanceOfHike { get; set; }

        [Required]
        [Display(Name = "Hike Description")]
        public string? DescriptionOfHike { get; set; }

		[Required]
        [Display(Name = "Attendance")]
        public List<string>? SelectedScouts { get; set; }

		[BindProperty(SupportsGet = true)]
        public DateTime StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; }

    }
}
