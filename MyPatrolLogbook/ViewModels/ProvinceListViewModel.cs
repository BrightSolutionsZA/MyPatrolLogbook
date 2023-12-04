using Microsoft.AspNetCore.Mvc.Rendering;
using MyPatrolLogbook.Models;

namespace MyPatrolLogbook.ViewModels
{
    public class ProvinceListViewModel
    {
        public IEnumerable<Province> Provinces { get; set; }
    }
}
