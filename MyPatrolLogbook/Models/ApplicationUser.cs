using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MyPatrolLogbook.Models
{
	public class ApplicationUser : IdentityUser
	{
		public string SSAID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string? ProvinceId { get; set; }
		public bool? IsTroopScouter { get; set; }
		public string? TroopId { get; set; }
		public string? PatrolId { get; set; }
		public bool? IsPatrolLeader { get; set; }
		public bool? IsProvincialAdmin { get; set; }

		public DateTime? Birthday { get; set; }
		public string? BirthdayStr { get; set; }

		public int? CellNumber { get; set; }

		public string? PatrolJob { get; set; }

		public string? CurrentAdvancementAchieved { get; set; }

		public bool? HasAttendedTraining { get; set; }

		public int? NumTravellerTheme { get; set; }

		public int? NumDiscovererTheme { get; set; }

		public int? NumFirstClassTheme { get; set; }

		public int? NumSpringbokTheme { get; set; }

		public bool? HasNationalChallenge { get; set; }
	}
}
