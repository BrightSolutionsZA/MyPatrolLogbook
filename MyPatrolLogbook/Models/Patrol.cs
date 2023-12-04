using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyPatrolLogbook.Models
{
    public class Patrol
    {
        // Patrol Table 
        // Column's in Troop Table in Database
        // all columns are required - meaning that they cannot be left blank
        public int PatrolId { get; set; }
        public int TroopId { get; set; }

        [Required]
        [Display(Name = "Patrol Name")]
        public string? PatrolName { get; set; }

		[Required(ErrorMessage = "Please select an option from the dropdown.")]
		[Display(Name = "Patrol Corner")]
		public bool HasPatrolCorner { get; set; }
	}
}
