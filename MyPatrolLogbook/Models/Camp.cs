using System.ComponentModel.DataAnnotations;

namespace MyPatrolLogbook.Models
{
    public class Camp
    {
        // Camp Table 
        // Column's in Troop Table in Database
        // all columns are required - meaning that they cannot be left blank
        public int CampId { get; set; }
        public int PatrolId { get; set; }

        [Required]
        [Display(Name = "Camp Name")]
        public string? CampName { get; set; }

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
        [Display(Name = "Venue Name")]
        public string? VenueName { get; set; }

        [Required]
        [Display(Name = "Venue Address")]
        public string? VenueAddress { get; set; }

        [Required]
        [Display(Name = "Camp Cost")]
        public int? CampCost { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string? CampDescription { get; set; }

        [Required]
        [Display(Name = "Attendance")]
		public string? CampAttendance { get; set; }

	}
}
