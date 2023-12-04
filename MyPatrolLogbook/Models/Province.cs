using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyPatrolLogbook.Models
{
    public class Province
    {
        // Province Table 
        // Column's in Province Table in Database
        // all columns are required - meaning that they cannot be left blank
        public int ProvinceId { get; set; }

        [Required]
        [Display(Name = "Province Name")]
        public string ProvinceName { get; set; }
    }
}
