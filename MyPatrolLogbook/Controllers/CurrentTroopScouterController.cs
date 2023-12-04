using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPatrolLogbook.Models;
using MyPatrolLogbook.ViewModels;
using System.Data;

namespace MyPatrolLogbook.Controllers
{
    // Only the users in the Provincial Admin Role can access the CurrentTroopScouterController Views
	[Authorize(Roles = "ProvincialAdmin")]
	public class CurrentTroopScouterController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUserRepository applicationUserRepository;
        private readonly IPatrolRepository patrolRepository;
        private readonly AppDBContext _appDBContext;
        private static ApplicationUser troopScouterFromDb;
        private readonly ITroopRepository troopRepository;
        private readonly IEmailSender _emailSender;

        public CurrentTroopScouterController(ITroopRepository troopRepository, IEmailSender emailSender, AppDBContext appDBContext, IPatrolRepository patrolRepository, UserManager<ApplicationUser> userManager, IApplicationUserRepository applicationUserRepository)
        {
            this.patrolRepository = patrolRepository;
            this.applicationUserRepository = applicationUserRepository;
            _userManager = userManager;
            _appDBContext = appDBContext;
            _emailSender = emailSender;
            this.troopRepository = troopRepository;
        }

        public async Task<IActionResult> Index(string SearchStringTSName, string FilterByTroop) // is this okay?
        {
            var user = await _userManager.GetUserAsync(User);

            if (user.EmailConfirmed)
            {
                if (user.IsProvincialAdmin == true)
                {
                    // populate the dropdownlist to filter by
                    var troopListViewModel = new CurrentTroopScouterListViewModel();
                    troopListViewModel.Troops = troopRepository.GetAllTroops.Where(f => f.ProvinceId == Int32.Parse(user.ProvinceId));

                    var troopList = troopListViewModel.Troops.ToList();
                    SelectList list = new SelectList(troopList, "TroopId", "TroopName");
                    ViewBag.troopList = list;

                    //string FilterByPatrol = Request.Form["PatrolList"];

                    // both filter options are null, then display all current scouts
                    if (SearchStringTSName == null)
                    {
                        var currentTroopScouterListViewModel = new CurrentTroopScouterListViewModel();
                        currentTroopScouterListViewModel.CurrentTroopScouters = applicationUserRepository.GetSelectedScouts.Where(f => f.ProvinceId == user.ProvinceId && f.IsTroopScouter == true);

                        var currentTroopListViewModel = new CurrentTroopScouterListViewModel();
                        currentTroopListViewModel.Troops = troopRepository.GetAllTroops.Where(f => f.ProvinceId == Int32.Parse(user.ProvinceId));

                        // Create the CombinedViewModel and populate it with data
                        CurrentTroopScouterListViewModel viewModelInformation = new CurrentTroopScouterListViewModel
                        {
                            Troops = currentTroopListViewModel.Troops,
                            CurrentTroopScouters = currentTroopScouterListViewModel.CurrentTroopScouters
                        };

                        return View(viewModelInformation);

                    }
                    // if one if != null then do the following
                    else
                    {
                        var searchedTroopListViewModel = new CurrentTroopScouterListViewModel();
                        searchedTroopListViewModel.CurrentTroopScouters = applicationUserRepository.GetSelectedScouts.Where(f => f.ProvinceId == user.ProvinceId && f.IsTroopScouter == true && (f.FirstName.ToUpper().Contains(SearchStringTSName.ToUpper()) || f.LastName.ToUpper().Contains(SearchStringTSName.ToUpper())));

                        var searchedTroopScouterListViewModel = new CurrentTroopScouterListViewModel();
                        searchedTroopScouterListViewModel.Troops = troopRepository.GetAllTroops.Where(f => f.ProvinceId == Int32.Parse(user.ProvinceId));

                        // Create the CombinedViewModel and populate it with data
                        CurrentTroopScouterListViewModel viewSearchedScoutInformation = new CurrentTroopScouterListViewModel
                        {
                            Troops = searchedTroopScouterListViewModel.Troops,
                            CurrentTroopScouters = searchedTroopListViewModel.CurrentTroopScouters
                        };

                        return View(viewSearchedScoutInformation);
                        // }
                    }

                }
                else
                {
                    return View();
                }

            }
            else
            {
                return View();
            }
        }


        [HttpPost]
        public async Task<IActionResult> Index(string FilterByTroop)
        {
            var user = await _userManager.GetUserAsync(User);

            // populate the dropdownlist
            var troopListViewModel = new CurrentTroopScouterListViewModel();
            troopListViewModel.Troops =troopRepository.GetAllTroops.Where(f => f.ProvinceId == Int32.Parse(user.ProvinceId));

            var troopList = troopListViewModel.Troops.ToList();
            SelectList list = new SelectList(troopList, "TroopId", "TroopName");
            ViewBag.troopList = list;

            FilterByTroop = Request.Form["TroopList"];

            // both filter options are null, then display all current scouts
            if (!string.IsNullOrEmpty(FilterByTroop))
            {
                string troopName = troopRepository.GetAllTroops.Where(f => f.TroopId == Int32.Parse(FilterByTroop)).Select(s => s.TroopName).FirstOrDefault().ToString();

                ViewData["filterByTS"] = "Selected Troop: " + troopName;

                var currentTroopScouterListViewModel = new CurrentTroopScouterListViewModel();
                currentTroopScouterListViewModel.CurrentTroopScouters = applicationUserRepository.GetSelectedScouts.Where(f => f.ProvinceId == user.ProvinceId && f.IsTroopScouter == true && f.TroopId == FilterByTroop);

                var currentTrooplListViewModel = new CurrentTroopScouterListViewModel();
                currentTrooplListViewModel.Troops = troopRepository.GetAllTroops.Where(f => f.ProvinceId == Int32.Parse(user.ProvinceId) && f.TroopId == Int32.Parse(FilterByTroop));

                // Create the CombinedViewModel and populate it with data
                CurrentTroopScouterListViewModel viewModelInformation = new CurrentTroopScouterListViewModel
                {
                    Troops = currentTrooplListViewModel.Troops,
                    CurrentTroopScouters = currentTroopScouterListViewModel.CurrentTroopScouters
                };

                return View(viewModelInformation);

            }
            // if one if != null then do the following
            else
            {
                ViewData["filterByTS"] = "No Troop Selected";

                var searchedTroopScouterListViewModel = new CurrentTroopScouterListViewModel();
                searchedTroopScouterListViewModel.CurrentTroopScouters = applicationUserRepository.GetSelectedScouts.Where(f => f.ProvinceId == user.ProvinceId && f.IsTroopScouter == true && f.TroopId == FilterByTroop);

                var searchedTroopScouterTroopListViewModel = new CurrentTroopScouterListViewModel();
                searchedTroopScouterTroopListViewModel.Troops = troopRepository.GetAllTroops.Where(f => f.ProvinceId == Int32.Parse(user.ProvinceId) && f.TroopId == Int32.Parse(FilterByTroop));

                // Create the CombinedViewModel and populate it with data
                CurrentTroopScouterListViewModel viewSearchedTroopScouterInformation = new CurrentTroopScouterListViewModel
                {
                    Troops = searchedTroopScouterTroopListViewModel.Troops,
                    CurrentTroopScouters = searchedTroopScouterListViewModel.CurrentTroopScouters
                };

                return View(viewSearchedTroopScouterInformation);

            }

        }
        
        public async Task<IActionResult> Delete(string? id)
        {
            var user = await _userManager.GetUserAsync(User);

            // check if id is null or equal to zero
            // return notfound() as it is an invalid id
            if (id == null)
            {
                return NotFound();
            }

            // if the id is valid, then retrieve the product's information from the database
            // with the .Find method, we just have to pass the id
            var currentTroopScouertListViewModel = new CurrentTroopScouterListViewModel();
            currentTroopScouertListViewModel.CurrentTroopScouters = applicationUserRepository.GetSelectedScouts.Where(f => f.ProvinceId == user.ProvinceId && f.IsTroopScouter == true);


            var currentTroopListViewModel = new CurrentTroopScouterListViewModel();
            currentTroopListViewModel.Troops = troopRepository.GetAllTroops.Where(f => f.ProvinceId == Int32.Parse(user.ProvinceId));

            troopScouterFromDb = currentTroopScouertListViewModel.CurrentTroopScouters.FirstOrDefault(u => u.Id == id.ToString());


            // now check if the product from the database is null - then return not found
            if (troopScouterFromDb == null)
            {
                return NotFound();
            }
            else
            {
                var troopList = currentTroopListViewModel.Troops.Where(f => f.TroopId == Int32.Parse(troopScouterFromDb.TroopId));
                SelectList list = new SelectList(troopList, "TroopId", "TroopName");
                ViewBag.troopList = list;
            }

            // if the product is found, then return it to the view with the products's information populated
            return View(troopScouterFromDb);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveTroopScouter()
        {
            var obj = _appDBContext.Users.FirstOrDefault(f => f.Id == troopScouterFromDb.Id);

            var troopListViewModel = new TroopListViewModel();
            troopListViewModel.Troops = troopRepository.GetAllTroops.Where(f => f.ProvinceId == Int32.Parse(obj.ProvinceId) && f.TroopId == Int32.Parse(obj.TroopId));

            var troopScouterTroop = troopListViewModel.Troops.Where(e => e.TroopId.ToString() == obj.TroopId).Select(u => u.TroopName).FirstOrDefault().ToString();

            // Get the new scout's email and notify them that the TS has removed them from their selected troop
            var currentTroopScouterListViewModel = new CurrentTroopScouterListViewModel();
            currentTroopScouterListViewModel.CurrentTroopScouters = applicationUserRepository.GetSelectedScouts;

            var troopScouterEmail = currentTroopScouterListViewModel.CurrentTroopScouters.Where(e => e.Id == troopScouterFromDb.Id).Select(u => u.Email).FirstOrDefault().ToString();

            if (obj != null)
            {
                // remove the information from the database
                _appDBContext.Users.Remove(obj);

                // save the changes
                _appDBContext.SaveChanges();

                await _emailSender.SendEmailAsync(
                troopScouterEmail,
                "You have been removed from " + troopScouterTroop,
                $"Greetings!\nYou have been removed from \n" + troopScouterTroop + "\n. If this is an error, please contact your Provincial Admin. \nThank you!");


                // display a message that the information has been removed successfully
                TempData["success"] = "Troop Scouter successfully removed!";

            }
            else
            {
                // displays error message
                TempData["error"] = "Error! Could not remove Troop Scouter!";
            }

            return RedirectToAction("Index", "CurrentTroopScouter");

        }
    }
}
