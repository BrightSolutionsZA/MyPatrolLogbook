using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPatrolLogbook.Models;
using MyPatrolLogbook.ViewModels;
using System.Data;

namespace MyPatrolLogbook.Controllers
{
    [Authorize(Roles = "TroopScouter")]
    public class PatrolController : Controller
    {
        // Readonly variables
        private readonly IPatrolRepository patrolRepository;
        private readonly AppDBContext _appDBContext;
        private readonly UserManager<ApplicationUser> _userManager;

        // Constructor
        public PatrolController(IPatrolRepository patrolRepository, AppDBContext appDBContext, UserManager<ApplicationUser> userManager)
        {
            this.patrolRepository = patrolRepository;
            _appDBContext = appDBContext;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            if(user.EmailConfirmed)
            {
                if(user.TroopId != null)
                {
                    if(user.IsTroopScouter != null)
                    {
                        var patrolListViewModel = new PatrolListViewModel();
                        patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                        return View(patrolListViewModel);

                    }
                    else
                    {
                        return RedirectToAction("AdminMustConfirm", "Patrol", new { area = "Patrol" });

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

        // Method that displays the view that the user sees when adding a product to the database 
        public IActionResult Create()
        {
			// Displays the options for the Troop Scouter to select whether or not teh Scout is a Patrol Leader
			List<SelectListItem> boolLists = new List<SelectListItem>
			{
				new SelectListItem { Value = "True", Text = "Yes" },
				new SelectListItem { Value = "False", Text = "No" }
                // Add more options as needed
            };

			// Add the items to the ViewBag
			//ViewBag.BoolDropDown = boolLists;
            ViewData["PatrolCorner"] = boolLists;
            return View();
        }

        // This is the method that saves the farmer's product information in the database
        [HttpPost]
        [ValidateAntiForgeryToken]  
        public async Task<IActionResult> Create(Patrol obj)
		{
			List<SelectListItem> boolLists = new List<SelectListItem>
				{
				new SelectListItem { Value = "True", Text = "Yes" },
				new SelectListItem { Value = "False", Text = "No" }
                // Add more options as needed
                };

			ViewData["PatrolCorner"] = boolLists;

			if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(obj.PatrolName))
                {
					// Add the items to the ViewBag
					//ViewBag.BoolDropDown = boolLists;

					string selectedValuePatrolCorner = Request.Form["PatrolCorner"];

					var user = await _userManager.GetUserAsync(User);

					obj.TroopId = Int32.Parse(user.TroopId);

					string patrolName = obj.PatrolName;

					// Check if the patrol already exists
					var patrolListViewModel = new PatrolListViewModel();
					patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == obj.TroopId && f.PatrolName == patrolName);

					if (patrolListViewModel.Patrols.Count() == 0)
					{

						if (!selectedValuePatrolCorner.Equals(""))
						{
							if (selectedValuePatrolCorner.Equals("True"))
							{
								obj.HasPatrolCorner = true;

							}
							else
							{
								obj.HasPatrolCorner = false;
							}

						}

						// adds the product to the database
						_appDBContext.Patrols.Add(obj);

						// saves the chanages
						_appDBContext.SaveChanges();

						// displays the message tha the product has been successfully saved in the database
						TempData["success"] = "Patrol successfully saved!";

						// returns the list of products added to the database by the specific farmer taht is loggged in
						return RedirectToAction("Index");

					}
					else
					{
						TempData["error"] = "Patrol already exists!";

						return View(obj);
					}
				}
                else
                {

					return View(obj);
				}

            }
            else
			{
				return View(obj);

			}
        }

        // Method for the user to update the products details
        public async Task<IActionResult> Edit(int? id)
        {
			var user = await _userManager.GetUserAsync(User);

			// check if id is null or equal to zero
			// return notfound() as it is an invalid id
			if (id == null || id == 0)
            {
                return NotFound();
            }

            // if the id is valid, then retrieve the product's information from the database
            // with the .Find method, we just have to pass the id
            var patrolFromDb = _appDBContext.Patrols.Find(id);

            // now check if the product from the database is null - then return not found
            if (patrolFromDb == null)
            {
                return NotFound();
            }
            else
            {
				var patrolListViewModel = new PatrolListViewModel();
				patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

				//var patrolCorner = patrolListViewModel.Patrols.Where(f => f.PatrolId == id);
				//SelectList plist = new SelectList(patrolCorner, "PatrolId", "HasPatrolCorner");
				List<SelectListItem> boolLists = new List<SelectListItem>
			{
				new SelectListItem { Value = "True", Text = "Yes" },
				new SelectListItem { Value = "False", Text = "No" }
                // Add more options as needed
            };

				// Add the items to the ViewBag
				ViewBag.BoolDropDown = boolLists;


			}

            // if the product is found, then return it to the view with the products's information populated
            return View(patrolFromDb);
        }

        // Method to save the updated information to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Edit(int? id, Patrol obj, string hasPatrolCorner)
        {
			//var patrolCorner = patrolListViewModel.Patrols.Where(f => f.PatrolId == id);
			//SelectList plist = new SelectList(patrolCorner, "PatrolId", "HasPatrolCorner");
			List<SelectListItem> boolLists = new List<SelectListItem>
			{
				new SelectListItem { Value = "True", Text = "Yes" },
				new SelectListItem { Value = "False", Text = "No" }
                // Add more options as needed
            };

			// Add the items to the ViewBag
			ViewBag.BoolDropDown = boolLists;

			obj = _appDBContext.Patrols.FirstOrDefault(u => u.PatrolId == id);
			
			if (obj == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);

			//string selectedValuePatrolCorner = Request.Form["PatrolCorner2"];

			if (!hasPatrolCorner.Equals(""))
			{
				if (hasPatrolCorner.Equals("True"))
				{
					obj.HasPatrolCorner = true;

				}
				else
				{
					obj.HasPatrolCorner = false;
				}

			}

			// update the information in the database
			_appDBContext.Patrols.Update(obj);

            // save the changes
            _appDBContext.SaveChanges();

            // display a message that the information has been updated successfully
            TempData["success"] = "Patrol update successfully saved!";

            // return to the product's index page
            return RedirectToAction("Index");

        }

        /*// Method for the user to remove the producr details
        public async Task<IActionResult> Delete(int? id)
		{
			var user = await _userManager.GetUserAsync(User);

			// check if id is null or equal to zero
			// return notfound() as it is an invalid id
			if (id == null || id == 0)
            {
                return NotFound();
            }



			// if the id is valid, then retrieve the product's information from the database
			// with the .Find method, we just have to pass the id
			var patrolFromDb = _appDBContext.Patrols.Find(id);

            // now check if the product from the database is null - then return not found
            if (patrolFromDb == null)
            {
                return NotFound();
            }
			else
			{
				var patrolListViewModel = new PatrolListViewModel();
				patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

				var patrolCorner = patrolListViewModel.Patrols.Where(f => f.PatrolId == id);
				SelectList plist = new SelectList(patrolCorner, "PatrolId", "HasPatrolCorner");
				ViewBag.patrolCorner = plist;
			}

			// if the product is found, then return it to the view with the product's information populated
			return View(patrolFromDb);
        }

        // Method to remove information from the database
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _appDBContext.Patrols.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            // remove the information from the database
            _appDBContext.Patrols.Remove(obj);

            // save the changes
            _appDBContext.SaveChanges();

            // display a message that the information has been removed successfully
            TempData["success"] = "Patrol successfully removed!";

            // return to the product's index page
            return RedirectToAction("Index");

        }*/

        public IActionResult AdminMustConfirm() => View();
    }
}

