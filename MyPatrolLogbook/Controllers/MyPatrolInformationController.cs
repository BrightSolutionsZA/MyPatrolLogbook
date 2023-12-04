using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPatrolLogbook.Models;
using MyPatrolLogbook.ViewModels;
using static System.Formats.Asn1.AsnWriter;
using Microsoft.VisualBasic;
using ClosedXML.Excel;
using System.Data;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Globalization;
using Microsoft.AspNetCore.Authorization;

namespace MyPatrolLogbook.Controllers
{
	[Authorize(Roles = "Scout")]
	public class MyPatrolInformationController : Controller
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

		public MyPatrolInformationController(ITroopRepository troopRepository, IEmailSender emailSender, AppDBContext appDBContext, IPatrolRepository patrolRepository, UserManager<ApplicationUser> userManager, IApplicationUserRepository applicationUserRepository)
		{
			this.patrolRepository = patrolRepository;
			this.applicationUserRepository = applicationUserRepository;
			_userManager = userManager;
			_appDBContext = appDBContext;
			_emailSender = emailSender;
			this.troopRepository = troopRepository;
		}

		public async Task<IActionResult> Index()
		{
			var user = await _userManager.GetUserAsync(User);

			if (user.EmailConfirmed)
			{
				if (user.TroopId != null)
				{
					if (user.PatrolId != null)
					{
						if (user.IsPatrolLeader == true)
						{

							var patrolMembersListViewModel = new MyPatrolInformationListViewModel();
							patrolMembersListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId);

							return View(patrolMembersListViewModel);
						}
						else
						{
							return RedirectToAction("IndexReadOnly", "MyPatrolInformation", new { area = "MyPatrolInformation" });
						}

					}
					else
					{
						return RedirectToAction("TroopScouterMustConfirm", "MyPatrolInformation", new { area = "MyPatrolInformation" });
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

		public async Task<IActionResult> IndexReadOnly()
		{
			var user = await _userManager.GetUserAsync(User);

			if (user.EmailConfirmed)
			{
				if (user.TroopId != null)
				{
					if (user.PatrolId != null)
					{
						var patrolMembersListViewModel = new MyPatrolInformationListViewModel();
						patrolMembersListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId && f.PatrolId == user.PatrolId);

						return View(patrolMembersListViewModel);

					}
					else
					{
						return RedirectToAction("TroopScouterMustConfirm", "MyPatrolInformation", new { area = "MyPatrolInformation" });
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

		public async Task<FileResult> ExportPatrolInformationInExcel()
		{
			var user = await _userManager.GetUserAsync(User);

			var patrolInformation = new MyPatrolInformationListViewModel();
			patrolInformation.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId).ToList();

			var fileName = "PatrolInformation.xlsx";
			return GenerateExcel(fileName, patrolInformation.MyScouts);
		}

		private FileResult GenerateExcel(string fileName, IEnumerable<ApplicationUser> patrolInformation)
		{
			DataTable dataTable = new DataTable("PatrolInformation");
			dataTable.Columns.AddRange(new DataColumn[]
			{
				new DataColumn("FirstName"),
				new DataColumn("LastName"),
				new DataColumn("Birthday"),
				new DataColumn("CellNumber"),
				new DataColumn("PatrolJob"),
				new DataColumn("CurrentAdvancementAchieved")
			});

			foreach (var patrolInfo in patrolInformation)
			{
				dataTable.Rows.Add(patrolInfo.FirstName, patrolInfo.LastName, patrolInfo.BirthdayStr,
					patrolInfo.CellNumber, patrolInfo.PatrolJob, patrolInfo.CurrentAdvancementAchieved);
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

		public IActionResult TroopScouterMustConfirm() => View();

		// Method for the user to update the products details
		public async Task<IActionResult> Edit(string? id)
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
			var selectedScoutListViewModel = new MyPatrolInformationListViewModel();
			selectedScoutListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts;

			scoutFromDb = selectedScoutListViewModel.MyScouts.FirstOrDefault(u => u.Id == id.ToString());

			// Display the drop down boxes
			List<SelectListItem> patrolJobs = new List<SelectListItem>
			 {
				 new SelectListItem { Value = "Patrol Leader", Text = "Patrol Leader" },
				 new SelectListItem { Value = "Assistant Patrol Leader", Text = "Assistant Patrol Leader" },
				 new SelectListItem { Value = "Scribe", Text = "Scribe" },
				 new SelectListItem { Value = "Treasurer", Text = "Treasurer" },
				 new SelectListItem { Value = "Quartermaster", Text = "Quartermaster" },
				 new SelectListItem { Value = "Other", Text = "Other" }

                 // Add more options as needed
             };

			// Add the items to the ViewBag
			ViewBag.PatrolJobDropDown = patrolJobs;

			// Display the drop down boxes
			List<SelectListItem> advancementBadges = new List<SelectListItem>
			{
				new SelectListItem { Value = "Membership", Text = "Membership" },
				new SelectListItem { Value = "Traveller", Text = "Traveller" },
				new SelectListItem { Value = "Discoverer", Text = "Discoverer" },
				new SelectListItem { Value = "First Class", Text = "First Class" },
				new SelectListItem { Value = "Springbok", Text = "Springbok" }
                // Add more options as needed
            };

			// Add the items to the ViewBag
			ViewBag.AdvancementBadges = advancementBadges;

			List<SelectListItem> boolLists = new List<SelectListItem>
			{
				new SelectListItem { Value = "True", Text = "Yes" },
				new SelectListItem { Value = "False", Text = "No" }
                // Add more options as needed
            };

			// Add the items to the ViewBag
			ViewBag.BoolDropDown = boolLists;


			List<SelectListItem> numBadges = new List<SelectListItem>
			{
				new SelectListItem { Value = "0", Text = "0" },
				new SelectListItem { Value = "1", Text = "1" },
				new SelectListItem { Value = "2", Text = "2" },
				new SelectListItem { Value = "3", Text = "3" },
				new SelectListItem { Value = "4", Text = "4" },
				new SelectListItem { Value = "5", Text = "5" },
				new SelectListItem { Value = "6", Text = "6" }
                // Add more options as needed
            };

			// Add the items to the ViewBag
			ViewBag.BadgeCount = numBadges;

			// if the product is found, then return it to the view with the products's information populated
			return View(scoutFromDb);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(string PatrolJob, string CurrentAdvancementAchieved, string HasAttendedTraining, string NumTravellerTheme, string NumDiscovererTheme, string NumFirstClassTheme, string NumSpringbokTheme, string HasNationalChallenge, int cellNumber, DateTime birthday, ApplicationUser model)
		{
			var user = _appDBContext.Users.FirstOrDefault(u => u.Id == scoutFromDb.Id);


			//string selectedPatrolJob = Request.Form["PatrolJobsSelected"];

			string selectedPatrolJob = model.PatrolJob;

			//string selectedadvancementLevel = Request.Form["CurrentAdvancementAchieved"];
			string selectedadvancementLevel = model.CurrentAdvancementAchieved;

			string selectedTraining = Request.Form["HasAttendedTraining"];
			string selectedNumTravellerTheme = Request.Form["NumTravellerTheme"];
			string selectedNumDiscovererTheme = Request.Form["NumDiscovererTheme"];
			string selectedNumFirstClassTheme = Request.Form["NumFirstClassTheme"];
			string selectedNumSpringbokTheme = Request.Form["NumSpringbokTheme"];
			string selectedNationalChallengeBool = Request.Form["HasNationalChallenge"];

			var selectedScoutPLListViewModel = new MyPatrolInformationListViewModel();
			selectedScoutPLListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId && f.IsPatrolLeader == true);

			var selectedScoutAPLListViewModel = new MyPatrolInformationListViewModel();
			selectedScoutAPLListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId && f.PatrolJob == "Assistant Patrol Leader");

			var selectedScoutScribeListViewModel = new MyPatrolInformationListViewModel();
			selectedScoutScribeListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId && f.PatrolJob == "Scribe");

			var selectedScoutTreasurerListViewModel = new MyPatrolInformationListViewModel();
			selectedScoutTreasurerListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId && f.PatrolJob == "Treasurer");

			var selectedScoutQuaterMasterListViewModel = new MyPatrolInformationListViewModel();
			selectedScoutQuaterMasterListViewModel.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId && f.PatrolJob == "Quatermaster");


			if (user.Id != null)
			{
				if (cellNumber != 0)
				{
					user.CellNumber = cellNumber;

				}
				else
				{
					user.CellNumber = null;
				}

				string strDate = birthday.ToString("dd/MM/yyyy");

				var sdt = DateTime.ParseExact(strDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

				user.Birthday = sdt;

				user.BirthdayStr = strDate;


				/*if (birthday.ToString() != "01/01/0001")
                {
                    
                }
                else
                {
                    TempData["Error"] = "Please select the scout's birthday!";

                    return await Edit(user.Id);
                }*/


				if (selectedPatrolJob != null /*|| selectedPatrolJob != ""*/)
				{
					if (user.IsPatrolLeader == true)
					{
						if (selectedPatrolJob != "Patrol Leader")
						{
							user.IsPatrolLeader = false;
						}
					}

					if (selectedPatrolJob == "Patrol Leader" && (selectedScoutPLListViewModel.MyScouts.Count() != 0) && user.IsPatrolLeader == false)
					//if (selectedPatrolJob == "1" && user.IsPatrolLeader == false)
					{
						TempData["Error"] = "Cannot have more than one Patrol Leader!";

						return await Edit(user.Id);
					}
					else
					 if (selectedPatrolJob == "Patrol Leader" && (selectedScoutAPLListViewModel.MyScouts.Count() == 0))
					{
						user.IsPatrolLeader = true;
						user.PatrolJob = "Patrol Leader";
					}
					else
					if (selectedPatrolJob == "Assistant Patrol Leader" && (selectedScoutAPLListViewModel.MyScouts.Count() != 0) && user.PatrolJob != "Assistant Patrol Leader")
					//if (selectedPatrolJob == "2" && (selectedScoutAPLListViewModel.MyScouts.Count() != 0))
					{
						TempData["Error"] = "Cannot have more than one Assistant Patrol Leader!";

						return await Edit(user.Id);
					}
					else
					if (selectedPatrolJob == "Scribe" && (selectedScoutScribeListViewModel.MyScouts.Count() != 0) && user.PatrolJob != "Scribe")
					//if (selectedPatrolJob == "3" && (selectedScoutScribeListViewModel.MyScouts.Count() != 0))
					{
						TempData["Error"] = "Cannot have more than one Scribe!";

						return await Edit(user.Id);
					}
					else
					if (selectedPatrolJob == "Treasurer" && (selectedScoutTreasurerListViewModel.MyScouts.Count() != 0) && user.PatrolJob != "Treasurer")
					//if (selectedPatrolJob == "4" && (selectedScoutTreasurerListViewModel.MyScouts.Count() != 0))
					{
						TempData["Error"] = "Cannot have more than one Treasurer!";

						return await Edit(user.Id);
					}
					else
					if (selectedPatrolJob == "Quartermaster" && (selectedScoutQuaterMasterListViewModel.MyScouts.Count() != 0) && user.PatrolJob != "Quartermaster")
					//if (selectedPatrolJob == "5" && (selectedScoutQuaterMasterListViewModel.MyScouts.Count() != 0))
					{
						TempData["Error"] = "Cannot have more than one Quartermaster!";

						return await Edit(user.Id);
					}
					else
					{
						user.PatrolJob = selectedPatrolJob;
					}
				}
				else
				{
					TempData["Error"] = "Please select the scout's patrol job!";

					return await Edit(user.Id);
				}

				if (/*selectedadvancementLevel != "" ||*/ selectedadvancementLevel != null)
				{
					user.CurrentAdvancementAchieved = selectedadvancementLevel;
				}
				else
				{
					TempData["Error"] = "Please select the scout's current advancement!";

					return await Edit(user.Id);
				}

				if (selectedTraining == "True")
				{
					user.HasAttendedTraining = true;
				}
				else
				if (selectedTraining == "False")
				{
					user.HasAttendedTraining = false;
				}
				else
				{
					TempData["Error"] = "Please select whether the scout has been to any training!";

					return await Edit(user.Id);
				}

				if (selectedNationalChallengeBool == "True")
				{
					user.HasNationalChallenge = true;
				}
				else
				if (selectedNationalChallengeBool == "False")
				{
					user.HasNationalChallenge = false;
				}
				else
				{
					TempData["Error"] = "Please select whether the scout has completed teh National Challenge!";

					return await Edit(user.Id);
				}

				if (selectedNumTravellerTheme != null && selectedNumTravellerTheme != "")
				{
					user.NumTravellerTheme = Int32.Parse(selectedNumTravellerTheme);
				}
				else
				{
					TempData["Error"] = "Please select the number of Traveller Theme Badges Complete!";

					return await Edit(user.Id);
				}

				if (selectedNumDiscovererTheme != null && selectedNumDiscovererTheme != "")
				{
					user.NumDiscovererTheme = Int32.Parse(selectedNumDiscovererTheme);
				}
				else
				{
					TempData["Error"] = "Please select the number of Discoverer Theme Badges Complete!";

					return await Edit(user.Id);
				}

				if (selectedNumFirstClassTheme != null && selectedNumFirstClassTheme != "")
				{
					user.NumFirstClassTheme = Int32.Parse(selectedNumFirstClassTheme);

				}
				else
				{
					TempData["Error"] = "Please select the number of First Class Theme Badges Complete!";

					return await Edit(user.Id);
				}

				if (selectedNumSpringbokTheme != null && selectedNumSpringbokTheme != "")
				{
					user.NumSpringbokTheme = Int32.Parse(selectedNumSpringbokTheme);
				}
				else
				{
					TempData["Error"] = "Please select the number of Springbok Theme Badges Complete!";

					return await Edit(user.Id);
				}

				// update the information in the database
				await _userManager.UpdateAsync(user);

				TempData["success"] = "Scout's details have successfully been updated!";

				return RedirectToAction("Index", "MyPatrolInformation");
			}
			else
			{
				TempData["error"] = "Error! Scout's details failed to update!";
				return RedirectToAction("Index", "MyPatrolInformation");
			}
		}
	}
}
