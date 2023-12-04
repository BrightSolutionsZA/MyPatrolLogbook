using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyPatrolLogbook.Models
{
    public class Troop
    {
        // Troop Table 
        // Column's in Troop Table in Database
        // all columns are required - meaning that they cannot be left blank
        public int TroopId { get; set; }
        public int ProvinceId { get; set; }

        [Required]
        [Display(Name = "Troop Name")]
        public string TroopName { get; set; }
    }
}
