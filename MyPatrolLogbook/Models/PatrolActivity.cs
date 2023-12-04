using System.ComponentModel.DataAnnotations;

namespace MyPatrolLogbook.Models
{
	public class PatrolActivity
	{
		// Patrol Activity Table 
		// Column's in Troop Table in Database
		// all columns are required - meaning that they cannot be left blank
		public int PatrolActivityId { get; set; }
		public int PatrolId { get; set; }

		[Required]
		[Display(Name = "Activity Name")]
		public string? ActivityName { get; set; }

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
		[Display(Name = "Activity Venue Name")]
		public string? VenueName { get; set; }

		[Required]
		[Display(Name = "Description")]
		public string? ActivityDescription { get; set; }

		[Required]
		[Display(Name = "Attendance")]
		public string? ActivityAttendance { get; set; }
	}
}
