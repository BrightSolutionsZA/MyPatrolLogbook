using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPatrolLogbook.Models;
using MyPatrolLogbook.ViewModels;
using System.Data;
using System.Text.Encodings.Web;

namespace MyPatrolLogbook.Controllers
{
	public class TroopController : Controller
	{
		// variables
		private UserManager<ApplicationUser> userManager;
		private readonly ITroopRepository troopRepository;
		private readonly IApplicationUserRepository applicationUserRepository;
		private readonly IEmailSender _emailSender;
		private readonly AppDBContext _appDBContext;

		// constructor
		public TroopController(ITroopRepository troopRepository, AppDBContext appDBContext, UserManager<ApplicationUser> _userManager, IApplicationUserRepository applicationUserRepository, IEmailSender emailSender)
		{
			this.troopRepository = troopRepository;
			userManager = _userManager;
			this.applicationUserRepository = applicationUserRepository;
			_emailSender = emailSender;
			_appDBContext = appDBContext;
		}
		// returns the Assign view - which is the page where the user must select their role when registering
		public async Task<IActionResult> Assign()
		{
			// Save the province that the user is from to the table
			var user = await userManager.GetUserAsync(User);

			//if (user.EmailConfirmed)
			//{
			// Populate DropdownList
			var displayTroopListViewModel = new TroopListViewModel();
			displayTroopListViewModel.Troops = troopRepository.GetAllTroops.Where(t => t.ProvinceId == Int32.Parse(user.ProvinceId));

			var troopList = displayTroopListViewModel.Troops.ToList();
			SelectList list = new SelectList(troopList, "TroopId", "TroopName");
			ViewBag.troopList = list;

			return View();
			//}
			/*else
            {
                return RedirectToAction("Confirm", "Role", new { area = "Role" });
            }*/


		}

		// This is the method that saves the user's role in the database
		public async Task<IActionResult> Submit()
		{
			// Save the province that the user is from to the table
			var user = await userManager.GetUserAsync(User);

			if (user.EmailConfirmed)
			{
				// Get Selected province from dropdown
				string selectedValue = Request.Form["TroopList"];

				string TSEmail;
                string PAEmail;

                if (!selectedValue.Equals(""))
				{
					user.TroopId = selectedValue;
					await userManager.UpdateAsync(user);

					// Get the TS's email and notify them that a new scout has joined
					var troopListViewModel = new TroopListViewModel();
					troopListViewModel.TroopScouters = applicationUserRepository.GetSelectedScouts;

                    string userId = troopListViewModel.TroopScouters.Where(e => e.Id == user.Id).Select(u => u.Id).FirstOrDefault().ToString();

					if(user.Id == userId && user.IsTroopScouter == false)
                    {
                        TempData["success"] = "A notification has been sent to your Troop Scouter to assign you to your patrol!";

                    }
					else
                    if (user.Id == userId && user.IsTroopScouter == null)
                    {
                        // displays success message
                        TempData["success"] = "An email has been sent to your provincial admin to verify your account!";
                    }

                    string isTS = troopListViewModel.TroopScouters.Where(e => e.TroopId == selectedValue).Select(u => u.IsTroopScouter).FirstOrDefault().ToString();
                    
					if (isTS == "true")
					{
                        TSEmail = troopListViewModel.TroopScouters.Where(e => e.TroopId == selectedValue && e.IsTroopScouter == true).Select(u => u.Email).FirstOrDefault().ToString();

                        await _emailSender.SendEmailAsync(
                        TSEmail,
                        "New Scout",
                        $"Greetings!\nPlease assign the new scout \"" + user.FirstName + " " + user.LastName + "\" to a patrol on the Manage New Scout Page.\n Or, if this scout does not belong to your troop, please remove them.\nThank you!");

                    }

					if(user.IsTroopScouter == true)
					{
                        PAEmail = troopListViewModel.TroopScouters.Where(e => e.ProvinceId == user.ProvinceId && e.IsProvincialAdmin == true).Select(u => u.Email).FirstOrDefault().ToString();

                        await _emailSender.SendEmailAsync(
                        PAEmail,
                        "New Troop Scouter",
                        $"Greetings!\nPlease verify the new troop scouter \"" + user.FirstName + " " + user.LastName + "\'s\" account on the Manage New Troop Scouter Page.\n Or, if this troop scouter does not belong to their selected troop, please remove them.\nThank you!");

                    }

                    return RedirectToAction("Index", "Home");
				}
				else
				{
					// displays error message
					TempData["error"] = "Error! Please select a valid troop!";

					// returns the assign page so that the user can select a valid role
					return RedirectToAction("Assign", "Troop");
				}
			}
			else
			{
				return RedirectToAction("Confirm", "Role", new { area = "Role" });
			}

		}

		// Only the users in the Provincial Admin Role can access the TroopController Views
		[Authorize(Roles = "ProvincialAdmin")]
		public async Task<IActionResult> Index()
		{
			var user = await userManager.GetUserAsync(User);

			var troopListViewModel = new TroopListViewModel();
			troopListViewModel.Troops = troopRepository.GetAllTroops.Where(f => f.ProvinceId == Int32.Parse(user.ProvinceId));

			return View(troopListViewModel);
		}

		// Only the users in the Provincial Admin Role can access the TroopController Views
		[Authorize(Roles = "ProvincialAdmin")]
		// Method that displays the view that the user sees when adding a product to the database 
		public IActionResult Create()
		{
			return View();
		}

		// This is the method that saves the farmer's product information in the database
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Troop obj)
		{
			if (ModelState.IsValid)
			{
				var user = await userManager.GetUserAsync(User);

				obj.ProvinceId = Int32.Parse(user.ProvinceId);

				string TroopName = obj.TroopName;

				// Check if the troop already exists
				var troopListViewModel = new TroopListViewModel();
				troopListViewModel.Troops = troopRepository.GetAllTroops.Where(f => f.ProvinceId == obj.ProvinceId && f.TroopName == TroopName);

				if (troopListViewModel.Troops.Count() == 0)
				{
					// adds the product to the database
					_appDBContext.Troops.Add(obj);

					// saves the chanages
					_appDBContext.SaveChanges();

					// displays the message tha the product has been successfully saved in the database
					TempData["success"] = "Troop successfully saved!";

				}
				else
				{
					TempData["error"] = "Troop already exists!";
				}


				// returns the list of products added to the database by the specific farmer taht is loggged in
				return RedirectToAction("Index");

			}
			return View(obj);
		}

		// Method for the user to update the products details
		public IActionResult Edit(int? id)
		{
			// check if id is null or equal to zero
			// return notfound() as it is an invalid id
			if (id == null || id == 0)
			{
				return NotFound();
			}

			// if the id is valid, then retrieve the product's information from the database
			// with the .Find method, we just have to pass the id
			var troopFromDb = _appDBContext.Troops.Find(id);

			// now check if the product from the database is null - then return not found
			if (troopFromDb == null)
			{
				return NotFound();
			}

			// if the product is found, then return it to the view with the products's information populated
			return View(troopFromDb);
		}

		// Method to save the updated information to the database
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(Troop obj)
		{
			// obj = _appDBContext.Farmers.Find(id);
			if (obj == null)
			{
				return NotFound();
			}

			var user = await userManager.GetUserAsync(User);

			obj.ProvinceId = Int32.Parse(user.ProvinceId);


			// update the information in the database
			_appDBContext.Troops.Update(obj);

			// save the changes
			_appDBContext.SaveChanges();

			// display a message that the information has been updated successfully
			TempData["success"] = "Troop update successfully saved!";

			// return to the product's index page
			return RedirectToAction("Index");

		}

		// Method for the user to remove the producr details
		public IActionResult Delete(int? id)
		{
			// check if id is null or equal to zero
			// return notfound() as it is an invalid id
			if (id == null || id == 0)
			{
				return NotFound();
			}

			// if the id is valid, then retrieve the product's information from the database
			// with the .Find method, we just have to pass the id
			var troopFromDb = _appDBContext.Troops.Find(id);

			// now check if the product from the database is null - then return not found
			if (troopFromDb == null)
			{
				return NotFound();
			}

			// if the product is found, then return it to the view with the product's information populated
			return View(troopFromDb);
		}

		// Method to remove information from the database
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeletePOST(int? id)
		{
			var obj = _appDBContext.Troops.Find(id);
			if (obj == null)
			{
				return NotFound();
			}

			// remove the information from the database
			_appDBContext.Troops.Remove(obj);

			// save the changes
			_appDBContext.SaveChanges();

			// display a message that the information has been removed successfully
			TempData["success"] = "Troop successfully removed!";

			// return to the product's index page
			return RedirectToAction("Index");

		}

	}
}
