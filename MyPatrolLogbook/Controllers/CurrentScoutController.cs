using ClosedXML.Excel;
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
    // Only the users in the Troop Scouter Role can access the CurrentScoutController Views
    [Authorize(Roles = "TroopScouter")]

    // Controller that displays the Current Scouts apart of a specific troop to the Troop Scouters of that Troop
    public class CurrentScoutController : Controller
    {
        // Readonly variables
        private readonly UserManager<ApplicationUser> _userManager;
		private readonly IApplicationUserRepository applicationUserRepository;
		private readonly IPatrolRepository patrolRepository;
		private readonly AppDBContext _appDBContext;
		private readonly ITroopRepository troopRepository;
		private readonly IEmailSender _emailSender;

        // Variables
		private static ApplicationUser scoutFromDb;

        // Constructor
        public CurrentScoutController(ITroopRepository troopRepository, IEmailSender emailSender, AppDBContext appDBContext, IPatrolRepository patrolRepository, UserManager<ApplicationUser> userManager, IApplicationUserRepository applicationUserRepository)
		{
			this.patrolRepository = patrolRepository;
			this.applicationUserRepository = applicationUserRepository;
			_userManager = userManager;
			_appDBContext = appDBContext;
			_emailSender = emailSender;
			this.troopRepository = troopRepository;
		}

        // displays a list of the current scouts who have saved in the database and who are apart of the same troop as the logged in Troop Scouter 
        public async Task<IActionResult> Index(string SearchStringScoutName, string FilterByPatrol) // is this okay? -- not using the 1
		{
            // gets the Troop Scouter's id so that the relevant information can be accessed from the database
            var user = await _userManager.GetUserAsync(User);

			// Before allowing the Troop Scouter to further access the information on this page, their email needs to be verified
			if (user.EmailConfirmed)
			{
                // Before allowing the Troop Scouter to further access the information on this page, they need to have selected the Troop that they belong too
                if (user.TroopId != null)
				{
					// This ensures that only users in the Troop Scouter Role are accessing the information
                    if (user.IsTroopScouter != null)
                    {
                        // The list of Patrols that belong to the Troop Scouter's Troop are populated in the dropdownlist
                        var patrolListViewModel = new CurrentScoutListViewModel();
                        patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                        var patrolList = patrolListViewModel.Patrols.ToList();
                        SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
                        ViewBag.patrolList = list;

                        // if the Troop Scouter does not filter the list of Scouts that belong to their troop, then all of the scouts within their troop are displayed to them 
                        if (SearchStringScoutName == null)
                        {
                            // fetch all of the scouts from the database that are a part of the troop
                            var currentScoutListViewModel = new CurrentScoutListViewModel();
                            currentScoutListViewModel.CurrentScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId && f.IsTroopScouter == false && f.PatrolId != null && f.IsPatrolLeader != null);

							// fetch all of the patrols that are apart of the troop
                            var currentPatrolListViewModel = new CurrentScoutListViewModel();
                            currentPatrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                            // Create the CombinedViewModel and populate it with the data regarding the list of scouts and patrols from the troop 
                            CurrentScoutListViewModel viewModelInformation = new CurrentScoutListViewModel
                            {
                                Patrols = currentPatrolListViewModel.Patrols,
                                CurrentScouts = currentScoutListViewModel.CurrentScouts
                            };

							// Display the information to the Troop Scouter
                            return View(viewModelInformation);

                        }
                        // if the Troop Scouter has searched for a particular scout then do the following
                        else
                        {
                            // fetch all of the scouts from the database that are a part of the troop and that contain the searchstring.
							// Since the information stored in the database is case-sensitive, convert it, as well as the searchstring both to uppercase and then compare
                            var searchedScoutListViewModel = new CurrentScoutListViewModel();
                            searchedScoutListViewModel.CurrentScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId && f.IsTroopScouter == false && f.PatrolId != null && f.IsPatrolLeader != null && (f.FirstName.ToUpper().Contains(SearchStringScoutName.ToUpper()) || f.LastName.ToUpper().Contains(SearchStringScoutName.ToUpper())));

                            // fetch all of the patrols that are apart of the troop
                            var searchedScoutPatrolListViewModel = new CurrentScoutListViewModel();
                            searchedScoutPatrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                            // Create the CombinedViewModel and populate it with the data regarding the list of filtered scouts and patrols from the troop 
                            CurrentScoutListViewModel viewSearchedScoutInformation = new CurrentScoutListViewModel
                            {
                                Patrols = searchedScoutPatrolListViewModel.Patrols,
                                CurrentScouts = searchedScoutListViewModel.CurrentScouts
                            };

                            // Display the filtered information to the Troop Scouter
                            return View(viewSearchedScoutInformation);
                        }

                    }
					// Otherwise redirect the user to the page stating that they must confirm their email!
                    else
                    {
                        return RedirectToAction("AdminMustConfirm", "CurrentScout", new { area = "CurrentScout" });

                    }

                }
                // Otherwise redirect the user to the page where they must select their troop!
                else
                {
					return RedirectToAction("Assign", "Troop", new { area = "Troop" });
				}

            }
            // Otherwise redirect the user to the page where they must select their troop and province!
            else
            {
				return RedirectToAction("Confirm", "Role", new { area = "Role" });
			}
		}

		// If the Troop Scouter filters the list of current scouts by a specific patrol, then the following is displayed
		[HttpPost]
		public async Task<IActionResult> Index(string FilterByPatrol)
        {
			// gets the Troop Scouter's id so that the relevant information can be accessed from the database
            var user = await _userManager.GetUserAsync(User);

            // The list of Patrols that belong to the Troop Scouter's Troop are populated in the dropdownlist
            var patrolListViewModel = new CurrentScoutListViewModel();
			patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

			var patrolList = patrolListViewModel.Patrols.ToList();
			SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
			ViewBag.patrolList = list;

			// Get the value of the selected patrol from the dropdownlist
			FilterByPatrol = Request.Form["PatrolList"];

            // if the Troop Scouter does not filter the list of Scouts that belong to their troop, then all of the scouts within their troop are displayed to them 
            if (!string.IsNullOrEmpty(FilterByPatrol))
            {
                string patrolName = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrol)).Select(s => s.PatrolName).FirstOrDefault().ToString();

                ViewData["filterByPatrolCurrentScout"] = "Selected Patrol: " + patrolName;

                // fetch all of the scouts from the database that are a part of the selected patrol
                var currentScoutListViewModel = new CurrentScoutListViewModel();
				currentScoutListViewModel.CurrentScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId && f.IsTroopScouter == false && f.PatrolId.Equals(FilterByPatrol) && f.IsPatrolLeader != null);

                // fetch all of the patrols that are apart of the troop
                var currentPatrolListViewModel = new CurrentScoutListViewModel();
				currentPatrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                // Create the CombinedViewModel and populate it with the data regarding the list of scouts and patrols from the troop 
                CurrentScoutListViewModel viewModelInformation = new CurrentScoutListViewModel
				{
					Patrols = currentPatrolListViewModel.Patrols,
					CurrentScouts = currentScoutListViewModel.CurrentScouts
				};

                // Display the information to the Troop Scouter
                return View(viewModelInformation);

            }
            // if the Troop Scouter has filtered the list of scouts by a particular patrol, then do the following
            else
            {
                ViewData["filterByPatrolCurrentScout"] = "No Patrol Selected";
                // fetch all of the scouts from the database that are a part of the troop and that belong to the selected patrol
                var scoutsInFilteredPatroltListViewModel = new CurrentScoutListViewModel();
                scoutsInFilteredPatroltListViewModel.CurrentScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId && f.IsTroopScouter == false && f.PatrolId == FilterByPatrol && f.IsPatrolLeader != null);

                // fetch all of the patrols that are apart of the troop
                var filteredPatroltListViewModel = new CurrentScoutListViewModel();
                filteredPatroltListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                // Create the CombinedViewModel and populate it with the data regarding the list of filtered scouts and patrols from the troop 
                CurrentScoutListViewModel viewSearchedScoutInformation = new CurrentScoutListViewModel
				{
					Patrols = filteredPatroltListViewModel.Patrols,
					CurrentScouts = scoutsInFilteredPatroltListViewModel.CurrentScouts
				};

                // Display the filtered information to the Troop Scouter
                return View(viewSearchedScoutInformation);

			}

		}

        public async Task<FileResult> ExportCurrentScoutsInExcel()
        {
            var user = await _userManager.GetUserAsync(User);

            var currentScouts = new CurrentScoutListViewModel();
            currentScouts.CurrentScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId).ToList();

            var fileName = "CurrentScouts.xlsx";
            return GenerateExcel(fileName, currentScouts.CurrentScouts);
        }

        private FileResult GenerateExcel(string fileName, IEnumerable<ApplicationUser> currentScouts)
        {
            DataTable dataTable = new DataTable("ApplicationUser");
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("SSAID"),
                new DataColumn("FirstName"),
                new DataColumn("LastName"),
                new DataColumn("PatrolId"),
                new DataColumn("IsPatrolLeader")
            });

            foreach (var currentScout in currentScouts)
            {
                dataTable.Rows.Add(currentScout.SSAID, currentScout.FirstName, currentScout.LastName, currentScout.PatrolId, currentScout.IsPatrolLeader);
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dataTable);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);

                    return File(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        fileName);
                }
            }

        }

        // Method for the Troop Scouter to update the Scouts details, when the edit button is clicked
        public async Task<IActionResult> Edit(string? id)
		{
            // gets the Troop Scouter's id so that the relevant information can be accessed from the database
            var user = await _userManager.GetUserAsync(User);

			// check if id is null
			if (id == null)
			{
				// return notfound() as it is an invalid id
				return NotFound();
			}
			else
			{
				// fetch the selected scout's information from the database
				var currentScoutListViewModel = new CurrentScoutListViewModel(); // changed from New
				currentScoutListViewModel.CurrentScouts = applicationUserRepository.GetSelectedScouts;

				// Save the scouts ID to this variable
				scoutFromDb = currentScoutListViewModel.CurrentScouts.FirstOrDefault(u => u.Id == id);

				if (scoutFromDb != null)
				{
					// Displays the latest patrol name that the selected scout was assigned to
					var currentPatrolListViewModel = new CurrentScoutListViewModel();
					currentPatrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

					//var patrolList = currentPatrolListViewModel.Patrols.Where(f => f.PatrolId == Int32.Parse(scoutFromDb.PatrolId));

					List<SelectListItem> plist = new List<SelectListItem>();

					foreach (var scout in currentPatrolListViewModel.Patrols)
					{
						// Assuming you want to use some property from scout as the text and value
						plist.Add(new SelectListItem { Value = scout.PatrolId.ToString(), Text = scout.PatrolName.ToString() });
					}
					ViewBag.scoutsPatrolList = plist;

					// Displays the options for the Troop Scouter to select whether or not teh Scout is a Patrol Leader
					List<SelectListItem> isPLOptions = new List<SelectListItem>
					{
					new SelectListItem { Value = "True", Text = "Yes" },
					new SelectListItem { Value = "False", Text = "No" }
					};

					// Add the itemoptionss to the ViewBag
					ViewBag.IsPlList = isPLOptions;
				}
				else
				{
					return NotFound();
				}

                // if the selected scout is found, then return it to the view with the information populated
                return View(scoutFromDb);
            }
			
		}

		[HttpPost]
		public async Task<IActionResult> EditScoutDetails(ApplicationUser model)
		{
			var user = _appDBContext.Users.FirstOrDefault(u => u.Id == scoutFromDb.Id);

            // Get the value of the selected patrol from the dropdownlist
            string selectedValuePatrol = model.PatrolId;
            string selectedValuePL = model.IsPatrolLeader.ToString();

			if (!string.IsNullOrEmpty(selectedValuePatrol))
			{
				if (user != null)
				{
					
					if (!string.IsNullOrEmpty(selectedValuePL))
					{
						// Assign the scout to their new Patrol
						user.PatrolId = selectedValuePatrol;
						user.IsPatrolLeader = null;

						if (selectedValuePL.Equals("True"))
						{
							//TempData["success"] = selectedValuePatrol + " ++ user <-WHY + saved->" + model.PatrolId;
							var newScoutListViewModelCount = new NewScoutListViewModel();
							newScoutListViewModelCount.Scouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == selectedValuePatrol && f.IsPatrolLeader == true);


							if (newScoutListViewModelCount.Scouts.Count() == 0)
							{
								user.IsPatrolLeader = true;
								user.PatrolJob = "Patrol Leader";
								TempData["success"] = "Scout successfully assigned to a patrol and Scout has been assigned the role of PL!";

								await _userManager.UpdateAsync(user);
							}
							else
                            {
                                user.IsPatrolLeader = false;
                                TempData["error"] = "Error! A Patrol Leader for this patrol has already been assigned!";
								return RedirectToAction("Index", "CurrentScout");
							}

						}
						else
						{
							user.IsPatrolLeader = false;
                            user.PatrolJob = "";
                            TempData["success"] = "Scout successfully assigned to a patrol and Scout has not been assigned the role of PL!";

							await _userManager.UpdateAsync(user);
						}
					}
					else
					{
						var newScoutListViewModelCount = new NewScoutListViewModel();
						newScoutListViewModelCount.Scouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId && f.PatrolId == selectedValuePatrol && f.IsPatrolLeader == true);

						if (newScoutListViewModelCount.Scouts.Count() == 0)
						{
							// New
                            user.IsPatrolLeader = true;
                            user.PatrolJob = "Patrol Leader";

                            await _userManager.UpdateAsync(user);
						}
						else
						{
							if (user.IsPatrolLeader == true)
							{

                                user.PatrolJob = "";
                                TempData["error"] = "Error! A Patrol Leader for this patrol has already been assigned! Please update the Scout's role!";
								return RedirectToAction("Index", "CurrentScout");

							}
							else
                            {
                                TempData["success"] = "Scout's Patrol has successfully been updated!";

								await _userManager.UpdateAsync(user);

								return RedirectToAction("Index", "CurrentScout");
							}
						}
					}

				}

			}
			else
			{
				if (!string.IsNullOrEmpty(selectedValuePL))
				{
					if (selectedValuePL.Equals("True"))
					{

						var newScoutListViewModelCount = new NewScoutListViewModel();
						newScoutListViewModelCount.Scouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId && f.PatrolId == user.PatrolId && f.IsPatrolLeader == true);

						if (newScoutListViewModelCount.Scouts.Count() == 0)
						{
							user.IsPatrolLeader = true;
							user.PatrolJob = "Patrol Leader";
							TempData["success"] = "Scout successfully assigned to a patrol and Scout has been assigned the role of PL!";

							await _userManager.UpdateAsync(user);
						}
						else
						{
							TempData["error"] = "Error! A Patrol Leader for this patrol has already been assigned!";
							return RedirectToAction("Index", "CurrentScout");
						}

					}
					else
					{
						user.IsPatrolLeader = false;
						user.PatrolJob = "";
						TempData["success"] = "Scout successfully assigned to a patrol and Scout has not been assigned the role of PL!";

						await _userManager.UpdateAsync(user);
					}
				}
				else
				{
					// displays error message
					TempData["error"] = "No change to the Scout's Details.";
				}
			}

            return RedirectToAction("Index", "CurrentScout");
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
			var currentScoutListViewModel = new CurrentScoutListViewModel();
			currentScoutListViewModel.CurrentScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId && f.IsTroopScouter == false && f.PatrolId != null && f.IsPatrolLeader != null);


			var currentPatrolListViewModel = new CurrentScoutListViewModel();
			currentPatrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

			scoutFromDb = currentScoutListViewModel.CurrentScouts.FirstOrDefault(u => u.Id == id.ToString());


			// now check if the product from the database is null - then return not found
			if (scoutFromDb == null)
			{
				return NotFound();
			}
			else
			{
				//currentPatrolListViewModel.Patrols.Where(f => f.PatrolId == Int32.Parse(scoutFromDb.PatrolId));

				var patrolList = currentPatrolListViewModel.Patrols.Where(f => f.PatrolId == Int32.Parse(scoutFromDb.PatrolId));
				SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
				ViewBag.patrolList = list;
			}

			// if the product is found, then return it to the view with the products's information populated
			return View(scoutFromDb);
		}

		[HttpPost]
		public async Task<IActionResult> RemoveScout()
		{
			var obj = _appDBContext.Users.FirstOrDefault(u => u.Id == scoutFromDb.Id);

            var troopListViewModel = new TroopListViewModel();
            troopListViewModel.Troops = troopRepository.GetAllTroops;

            string scoutSelectedTroop = troopListViewModel.Troops.Where(e => e.TroopId.ToString() == obj.TroopId).Select(u => u.TroopName).FirstOrDefault().ToString();

            // Get the new scout's email and notify them that the TS has removed them from their selected troop
            var newScoutListViewModel = new NewScoutListViewModel();
            newScoutListViewModel.Scouts = applicationUserRepository.GetSelectedScouts;

            var scoutEmail = newScoutListViewModel.Scouts.Where(e => e.Id == scoutFromDb.Id).Select(u => u.Email).FirstOrDefault().ToString();

            if (obj != null)
            {
                // remove the information from the database
                _appDBContext.Users.Remove(obj);

                // save the changes
                _appDBContext.SaveChanges();

                await _emailSender.SendEmailAsync(
                scoutEmail,
                "You have been removed from " + scoutSelectedTroop,
                $"Greetings!\nYou have been removed from \n" + scoutSelectedTroop + "\n. If this is an error, please contact your Troop Scouter. \nThank you!");

                // display a message that the information has been removed successfully
                TempData["success"] = "Scout has successfully been removed from your troop!";

            }
            else
            {
                // displays error message
                TempData["error"] = "Error! Could not remove scout!";
            }

			return RedirectToAction("Index", "CurrentScout");

		}

        public IActionResult AdminMustConfirm() => View();

        public async Task <IActionResult> DisplayPatrolLeaders()
		{
            var user = await _userManager.GetUserAsync(User);

            var currentScoutListViewModel = new CurrentScoutListViewModel();
            currentScoutListViewModel.CurrentScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId && f.IsTroopScouter == false && f.PatrolId != null && f.IsPatrolLeader == true);

            var currentPatrolListViewModel = new CurrentScoutListViewModel();
            currentPatrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

            // Create the CombinedViewModel and populate it with data
            CurrentScoutListViewModel viewModelInformation = new CurrentScoutListViewModel
            {
                Patrols = currentPatrolListViewModel.Patrols,
                CurrentScouts = currentScoutListViewModel.CurrentScouts
            };

            return View(viewModelInformation);
        }
    }
}
