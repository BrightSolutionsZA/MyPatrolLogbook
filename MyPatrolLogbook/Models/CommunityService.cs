using System.ComponentModel.DataAnnotations;

namespace MyPatrolLogbook.Models
{
    public class CommunityService
    {
        // Community Service Table 
        // Column's in Troop Table in Database
        // all columns are required - meaning that they cannot be left blank
        public int CommunityServiceId { get; set; }
        public int PatrolId { get; set; }

        [Required]
        [Display(Name = "Project Name")]
        public string? ProjectName { get; set; }

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
        [Display(Name = "Project Venue Name")]
        public string? VenueName { get; set; }

        [Required]
        [Display(Name = "Overall Hours")]
        public int? ProjectHours { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string? ProjectDescription { get; set; }

        [Required]
        [Display(Name = "Attendance")]
        public string? ProjectAttendance { get; set; }
    }
}
