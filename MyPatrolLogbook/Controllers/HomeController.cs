using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPatrolLogbook.Models;
using MyPatrolLogbook.ViewModels;
using System.Diagnostics;

namespace MyPatrolLogbook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITroopRepository troopRepository;
        private UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public HomeController(SignInManager<ApplicationUser> signInManager, ILogger<HomeController> logger, ITroopRepository troopRepository, UserManager<ApplicationUser> _userManager)
        {
            _signInManager = signInManager;
            _logger = logger;
            this.troopRepository = troopRepository;
            userManager = _userManager;
        }

        public async Task<IActionResult> Index()
        {
            // If the signed in user has not selected which province they belong to, or which troop they belong to, then they are forced to select do that
            if(_signInManager.IsSignedIn(User))
            {
                var user = await userManager.GetUserAsync(User);
                
                if (user.ProvinceId == null)
                {
                    return RedirectToAction("Assign", "Role", new { area = "Role" });
                }
                else
                if (!user.EmailConfirmed)
                {
                    return RedirectToAction("Confirm", "Role", new { area = "Role" });
                }
                else
                if (string.IsNullOrEmpty(user.TroopId) && user.IsProvincialAdmin == null)
                {
                    return RedirectToAction("Assign", "Troop", new { area = "Troop" });
                    
                }
                else
                {
                    return View();
                }
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult OurTeam()
        {
            return View();
        }
        public IActionResult HowToGuide()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}