using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyPatrolLogbook.Models;
using MyPatrolLogbook.ViewModels;
using System;
using System.Data;
using System.Linq;

namespace MyPatrolLogbook.Controllers
{
    // Only the users in the Provincial Admin Role can access the NewTroopScouterController Views
	[Authorize(Roles = "ProvincialAdmin")]
	public class NewTroopScouterController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUserRepository applicationUserRepository;
        private readonly ITroopRepository troopRepository;
        private readonly AppDBContext _appDBContext;
        private static ApplicationUser troopScouterFromDb;
        private readonly IEmailSender _emailSender;
        public NewTroopScouterController(ITroopRepository troopRepository, AppDBContext appDBContext, UserManager<ApplicationUser> userManager, IApplicationUserRepository applicationUserRepository, IEmailSender emailSender)
        {
            this.troopRepository = troopRepository;
            this.applicationUserRepository = applicationUserRepository;
            _userManager = userManager;
            _appDBContext = appDBContext;
            _emailSender = emailSender;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            var newTroopScouterListViewModel = new NewTroopScouterListViewModel();
            newTroopScouterListViewModel.TroopScouters = applicationUserRepository.GetSelectedScouts.Where(f => f.ProvinceId == user.ProvinceId && f.IsTroopScouter == null && f.TroopId != null && (f.Email.Contains("@scouts.org.za") || f.Email.Contains("keishamoonasar@gmail.com") || f.Email.Equals("brightsolutionsza@gmail.com")));

            var newTroopListViewModel = new NewTroopScouterListViewModel();
            newTroopListViewModel.Troops = troopRepository.GetAllTroops.Where(f => f.ProvinceId == Int32.Parse(user.ProvinceId));

            // Create the CombinedViewModel and populate it with data
            NewTroopScouterListViewModel viewModelInformation = new NewTroopScouterListViewModel
            {
                Troops = newTroopListViewModel.Troops,
                TroopScouters = newTroopScouterListViewModel.TroopScouters
            };

            return View(viewModelInformation);

        }


        // Method for the user to update the products details
        public async Task<IActionResult> Confirm(string? id)
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
            var newTroopScouterListViewModel = new NewTroopScouterListViewModel();
            newTroopScouterListViewModel.TroopScouters = applicationUserRepository.GetSelectedScouts;

            troopScouterFromDb = newTroopScouterListViewModel.TroopScouters.FirstOrDefault(u => u.Id == id.ToString());

            // Populate DropdownList
            var displayTroopListViewModel = new TroopListViewModel();
            displayTroopListViewModel.Troops = troopRepository.GetAllTroops.Where(t => t.ProvinceId == Int32.Parse(user.ProvinceId) && t.TroopId.ToString() == troopScouterFromDb.TroopId);

            var troopList = displayTroopListViewModel.Troops.ToList();
            SelectList list = new SelectList(troopList, "TroopId", "TroopName");
            ViewBag.troopList = list;

            // now check if the product from the database is null - then return not found
            if (troopScouterFromDb == null)
            {
                return NotFound();
            }

            // if the product is found, then return it to the view with the products's information populated
            return View(troopScouterFromDb);
        }

        [HttpPost]
        public async Task<IActionResult> Confirm()
        {
            var user = _appDBContext.Users.FirstOrDefault(u => u.Id == troopScouterFromDb.Id);

            user.IsTroopScouter = true;

            await _userManager.UpdateAsync(user);

            TempData["success"] = "Successfully verified user as Troop Scouter!";

            return RedirectToAction("Index", "NewTroopScouter");
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
            var newTroopScouterListViewModel = new NewTroopScouterListViewModel();
            newTroopScouterListViewModel.TroopScouters = applicationUserRepository.GetSelectedScouts;

            troopScouterFromDb = newTroopScouterListViewModel.TroopScouters.FirstOrDefault(u => u.Id == id.ToString());

            // Populate DropdownList
            var displayTroopListViewModel = new TroopListViewModel();
            displayTroopListViewModel.Troops = troopRepository.GetAllTroops.Where(t => t.ProvinceId == Int32.Parse(user.ProvinceId) && t.TroopId.ToString() == troopScouterFromDb.TroopId);

            var troopList = displayTroopListViewModel.Troops.ToList();
            SelectList list = new SelectList(troopList, "TroopId", "TroopName");
            ViewBag.troopList = list;

            // now check if the product from the database is null - then return not found
            if (troopScouterFromDb == null)
            {
                return NotFound();
            }

            // if the product is found, then return it to the view with the products's information populated
            return View(troopScouterFromDb);
        }

        [HttpPost]
        public async Task<IActionResult> Delete()
        {
            var obj = _appDBContext.Users.FirstOrDefault(f => f.Id == troopScouterFromDb.Id);

            var troopListViewModel = new TroopListViewModel();
            troopListViewModel.Troops = troopRepository.GetAllTroops.Where(f => f.ProvinceId == Int32.Parse(obj.ProvinceId) && f.TroopId == Int32.Parse(obj.TroopId));

            var troopScouterTroop = troopListViewModel.Troops.Where(e => e.TroopId.ToString() == obj.TroopId).Select(u => u.TroopName).FirstOrDefault().ToString();

            // Get the new scout's email and notify them that the TS has removed them from their selected troop
            var newTroopScouterListViewModel = new NewTroopScouterListViewModel();
            newTroopScouterListViewModel.TroopScouters = applicationUserRepository.GetSelectedScouts;

            var troopScouterEmail = newTroopScouterListViewModel.TroopScouters.Where(e => e.Id == troopScouterFromDb.Id).Select(u => u.Email).FirstOrDefault().ToString();

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
