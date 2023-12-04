using System.ComponentModel.DataAnnotations;

namespace MyPatrolLogbook.Models
{
    public class PatrolInCouncil
    {
        // PatrolInCouncil Table 
        // Column's in Troop Table in Database
        // all columns are required - meaning that they cannot be left blank
        public int PatrolInCouncilId { get; set; }
        public int PatrolId { get; set; }

        [Required]
        [Display(Name = "Patrol In Council Date")]
        public DateTime? PICDate { get; set; }

		public string? PICDateStr { get; set; }

		[Required]
        [Display(Name = "Attendance")]
        public string? PICAttendance { get; set; }

        [Required]
        [Display(Name = "Matters Discussed")]
        public string? PICPoints { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string? PICDescription { get; set; }

    }
}
