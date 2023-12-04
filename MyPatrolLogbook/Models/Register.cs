using System.ComponentModel.DataAnnotations;

namespace MyPatrolLogbook.Models
{
    public class Register
    {
        // Register Table 
        // Column's in Troop Table in Database
        // all columns are required - meaning that they cannot be left blank
        public int RegisterId { get; set; }
        public int PatrolId { get; set; }

		[Required]
		[Display(Name = "Date")]
        public DateTime? AttendanceDate { get; set; }
		public string? AttendanceDateStr { get; set; }

		[Required]
		[Display(Name = "Attendance")]
        public string? MeetingAttendance { get; set; }
    }
}
