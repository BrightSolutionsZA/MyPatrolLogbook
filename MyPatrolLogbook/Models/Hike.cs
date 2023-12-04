using System.ComponentModel.DataAnnotations;

namespace MyPatrolLogbook.Models
{
    public class Hike
    {
        // Hike Table 
        // Column's in Troop Table in Database
        // all columns are required - meaning that they cannot be left blank
        public int HikeId { get; set; }
        public int PatrolId { get; set; }

        [Required]
        [Display(Name = "Hike Name")]
        public string? HikeName { get; set; }

        [Required]
        [Display(Name = "Permit ID")]
        public string? PermitId { get; set; }

        [Required]
        [Display(Name = "Start Date and Time")]
        public DateTime? StartDateTime { get; set; }
		public string? StartDateTimeStr { get; set; }

		[Required]
        [Display(Name = "End Date and Time")]
        public DateTime? EndDateTime { get; set; }
		public string? EndDateTimeStr { get; set; }

		[Required]
        [Display(Name = "Hike Venue Name")]
        public string? VenueName { get; set; }

        [Required]
        [Display(Name = "Venue Address")]
        public string? VenueAddress { get; set; }

        [Required]
        [Display(Name = "Hike Cost")]
        public int? HikeCost { get; set; }

        [Required]
        [Display(Name = "Overall Distance")]
        public int? Distance { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string? HikeDescription { get; set; }

        [Required]
        [Display(Name = "Attendance")]
        public string? HikeAttendance { get; set; }
    }
}
