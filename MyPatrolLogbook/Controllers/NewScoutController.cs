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
	// Only the users in the Troop Scouter Role can access the NewScoutController Views
	[Authorize(Roles = "TroopScouter")]
	public class NewScoutController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly IApplicationUserRepository applicationUserRepository;
		private readonly IPatrolRepository patrolRepository;
		private readonly ITroopRepository troopRepository;
		private readonly AppDBContext _appDBContext;
		private static ApplicationUser scoutFromDb;
		private readonly IEmailSender _emailSender;
		public NewScoutController(ITroopRepository troopRepository, AppDBContext appDBContext, IPatrolRepository patrolRepository, UserManager<ApplicationUser> userManager, IApplicationUserRepository applicationUserRepository, IEmailSender emailSender)
		{
			this.troopRepository = troopRepository;
			this.patrolRepository = patrolRepository;
			this.applicationUserRepository = applicationUserRepository;
			_userManager = userManager;
			_appDBContext = appDBContext;
			_emailSender = emailSender;
		}

		public async Task<IActionResult> Index()
		{
			var user = await _userManager.GetUserAsync(User);

			if (user.EmailConfirmed)
			{
				if (user.TroopId != null)
				{
                    if (user.IsTroopScouter != null)
                    {
                        var newScoutListViewModel = new NewScoutListViewModel();
                        newScoutListViewModel.Scouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId && f.IsTroopScouter == false && (f.PatrolId == null || f.IsPatrolLeader == null));

                        return View(newScoutListViewModel);

                    }
                    else
                    {
                        return RedirectToAction("AdminMustConfirm", "NewScout", new { area = "NewScout" });

                    }

				}
				else
				{
					return RedirectToAction("Assign", "Troop", new { area = "Troop" });
				}

			}
			else
			{
				return RedirectToAction("Confirm", "Role", new { area = "Role" });
			}
		}


		// Method for the user to update the products details
		public async Task<IActionResult> AssignPatrol(string? id)
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
			var newScoutListViewModel = new NewScoutListViewModel();
			newScoutListViewModel.Scouts = applicationUserRepository.GetSelectedScouts;

			scoutFromDb = newScoutListViewModel.Scouts.FirstOrDefault(u => u.Id == id.ToString());

			// Populate DropdownList
			var displayTroopPatrolsListViewModel = new PatrolListViewModel();
			displayTroopPatrolsListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(t => t.TroopId == Int32.Parse(user.TroopId));

			var patrolList = displayTroopPatrolsListViewModel.Patrols.ToList();
			SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
			ViewBag.patrolList = list;

			List<SelectListItem> isPLOptions = new List<SelectListItem>
			{
				new SelectListItem { Value = "True", Text = "Yes" },
				new SelectListItem { Value = "False", Text = "No" }
                // Add more options as needed
            };

			// Add the items to the ViewBag
			ViewBag.Items = isPLOptions;

			// now check if the product from the database is null - then return not found
			if (scoutFromDb == null)
			{
				return NotFound();
			}

			// if the product is found, then return it to the view with the products's information populated
			return View(scoutFromDb);
		}

		[HttpPost]
		public async Task<IActionResult> ConfirmScoutDetails()
		{
			var user = _appDBContext.Users.FirstOrDefault(u => u.Id == scoutFromDb.Id);
			string selectedValuePatrol = Request.Form["PatrolList"];
			string selectedValuePL = Request.Form["IsPLDropDown"];

			if (!selectedValuePatrol.Equals(""))
			{
				if (user != null)
				{
					user.PatrolId = selectedValuePatrol;

					if (!selectedValuePL.Equals(""))
					{
						if (selectedValuePL.Equals("True"))
						{

							var newScoutListViewModelCount = new NewScoutListViewModel();
							newScoutListViewModelCount.Scouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId && f.PatrolId == selectedValuePatrol && f.IsPatrolLeader == true);

							if (newScoutListViewModelCount.Scouts.Count() == 0)
							{
								user.IsPatrolLeader = true;
								user.PatrolJob = "Patrol Leader";
								TempData["success"] = "Scout successfully assigned to a patrol and Scout has been assigned the role of PL!";

							}
							else
                            {
                                user.IsPatrolLeader = false;
                                TempData["error"] = "Error! A Patrol Leader for this patrol has already been assigned!";
								return RedirectToAction("Index", "NewScout");
							}

						}
						else
						{
							user.IsPatrolLeader = false;
							TempData["success"] = "Scout successfully assigned to a patrol and Scout has not been assigned the role of PL!";
						}
					}
					else
					{
						// displays error message
						TempData["error"] = "Error! Please select whether the scout is a patrol leader or not!";
					}

					await _userManager.UpdateAsync(user);
				}

			}
			else
			{
				// displays error message
				TempData["error"] = "Error! Please select a valid patrol!";
			}

			return RedirectToAction("Index", "NewScout");
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
			var newScoutListViewModel = new NewScoutListViewModel();
			newScoutListViewModel.Scouts = applicationUserRepository.GetSelectedScouts;

			scoutFromDb = newScoutListViewModel.Scouts.FirstOrDefault(u => u.Id == id.ToString());

			// now check if the product from the database is null - then return not found
			if (scoutFromDb == null)
			{
				return NotFound();
			}

			// if the product is found, then return it to the view with the products's information populated
			return View(scoutFromDb);
		}

		[HttpPost]
		public async Task<IActionResult> RemoveScoutDetails()
		{
			var user = _appDBContext.Users.FirstOrDefault(u => u.Id == scoutFromDb.Id);
			string scoutEmail;
			if (user != null)
			{
				var troopListViewModel = new TroopListViewModel();
				troopListViewModel.Troops = troopRepository.GetAllTroops;

				string scoutSelectedTroop = troopListViewModel.Troops.Where(e => e.TroopId.ToString() == user.TroopId).Select(u => u.TroopName).FirstOrDefault().ToString();

				// Get the new scout's email and notify them that the TS has removed them from their selected troop
				var newScoutListViewModel = new NewScoutListViewModel();
				newScoutListViewModel.Scouts = applicationUserRepository.GetSelectedScouts;

				scoutEmail = newScoutListViewModel.Scouts.Where(e => e.Id == scoutFromDb.Id).Select(u => u.Email).FirstOrDefault().ToString();

				await _emailSender.SendEmailAsync(
				scoutEmail,
				"You have been removed from " + scoutSelectedTroop,
				$"Greetings!\nYou have been removed from \n" + scoutSelectedTroop + "\n. If this is an error, please contact your Troop Scouter, otherwsie, please select your currrent Troop again. \nThank you!");


                user.TroopId = null;

                await _userManager.UpdateAsync(user);

				TempData["success"] = "Scout has successfully been removed from your troop!";


			}
			else
			{
				// displays error message
				TempData["error"] = "Error!";
			}

			return RedirectToAction("Index", "NewScout");

		}

        public IActionResult AdminMustConfirm() => View();
    }
}
