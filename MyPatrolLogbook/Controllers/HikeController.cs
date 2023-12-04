using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyPatrolLogbook.Models;
using MyPatrolLogbook.ViewModels;
using System.Data;
using System.Globalization;

namespace MyPatrolLogbook.Controllers
{
    [Authorize(Roles = "Scout")]
    public class HikeController : Controller
    {
		// Readonly variables
		private readonly IHikeRepository hikeRepository;
		private readonly AppDBContext _appDBContext;
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly IApplicationUserRepository applicationUserRepository;

		// Constructor
		public HikeController(IHikeRepository hikeRepository, AppDBContext appDBContext, UserManager<ApplicationUser> userManager, IApplicationUserRepository applicationUserRepository)
		{
			this.hikeRepository = hikeRepository;
			_appDBContext = appDBContext;
			_userManager = userManager;
			this.applicationUserRepository = applicationUserRepository;
		}

		public async Task<IActionResult> Index(DateTime StartDate, DateTime EndDate)
		{
			var user = await _userManager.GetUserAsync(User);

            string dateString = "0001-01-01"; // Example date string in "yyyy-MM-dd" format
            DateTime parsedDate = DateTime.Parse(dateString);

            if (user.EmailConfirmed)
			{
				if (user.TroopId != null)
				{
					if (user.PatrolId != null)
					{
						if (user.IsPatrolLeader == true)
						{
                            if (StartDate == parsedDate && EndDate == parsedDate)
                            {
                                var hikeListViewModel = new HikeListViewModel();
                                hikeListViewModel.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                return View(hikeListViewModel);

                            }
                            else
                            {
                                if (!StartDate.Equals(parsedDate) && !StartDate.Equals(parsedDate))
                                {
                                    if (StartDate >= EndDate)
                                    {
                                        var hikeListViewModel = new HikeListViewModel();
                                        hikeListViewModel.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                        TempData["error"] = "Error! End Date cannot be before the Start Date!";

                                        return View(hikeListViewModel);
                                    }
                                    else
                                    {
                                        var hikeListViewModel = new HikeListViewModel();
                                        hikeListViewModel.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && f.StartDateTime >= StartDate && f.EndDateTime <= EndDate);

                                        return View(hikeListViewModel);
                                    }
                                }
                                else
                                {
                                    var hikeListViewModel = new HikeListViewModel();
                                    hikeListViewModel.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                    return View(hikeListViewModel);
                                }
                            }
                        }
						else
						{
							return RedirectToAction("IndexReadOnly", "Hike", new { area = "Hike" });
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

		public async Task<IActionResult> IndexReadOnly(DateTime StartDate, DateTime EndDate)
		{
			var user = await _userManager.GetUserAsync(User);

            string dateString = "0001-01-01"; // Example date string in "yyyy-MM-dd" format
            DateTime parsedDate = DateTime.Parse(dateString);

            if (user.EmailConfirmed)
			{
				if (user.TroopId != null)
				{
					if (user.PatrolId != null)
					{
                        if (StartDate == parsedDate && EndDate == parsedDate)
                        {
                            var hikeListViewModel = new HikeListViewModel();
                            hikeListViewModel.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                            return View(hikeListViewModel);

                        }
                        else
                        {
                            if (!StartDate.Equals(parsedDate) && !StartDate.Equals(parsedDate))
                            {
                                if (StartDate >= EndDate)
                                {
                                    var hikeListViewModel = new HikeListViewModel();
                                    hikeListViewModel.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                    TempData["error"] = "Error! End Date cannot be before the Start Date!";

                                    return View(hikeListViewModel);
                                }
                                else
                                {
                                    var hikeListViewModel = new HikeListViewModel();
                                    hikeListViewModel.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && f.StartDateTime >= StartDate && f.EndDateTime <= EndDate);

                                    return View(hikeListViewModel);
                                }
                            }
                            else
                            {
                                var hikeListViewModel = new HikeListViewModel();
                                hikeListViewModel.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                return View(hikeListViewModel);
                            }
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

        public async Task<FileResult> ExportHikeInExcel()
        {
            var user = await _userManager.GetUserAsync(User);

            var hikes = new HikeListViewModel();
            hikes.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId == Int32.Parse(user.PatrolId)).ToList();

            var fileName = "PatrolHikes.xlsx";
            return GenerateExcel(fileName, hikes.Hikes);
        }

        private FileResult GenerateExcel(string fileName, IEnumerable<Hike> hikes)
        {
            DataTable dataTable = new DataTable("Hike");
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("HikeName"),
                new DataColumn("PermitId"),
                new DataColumn("StartDateTime"),
                new DataColumn("EndDateTime"),
                new DataColumn("VenueName"),
                new DataColumn("VenueAddress"),
                new DataColumn("HikeCost"),
                new DataColumn("Distance"),
                new DataColumn("HikeDescription"),
                new DataColumn("HikeAttendance")
            });

            foreach (var hike in hikes)
            {
                dataTable.Rows.Add(hike.HikeName, hike.PermitId, hike.StartDateTimeStr, hike.EndDateTimeStr, hike.VenueName,
                    hike.VenueAddress, hike.HikeCost, hike.Distance, hike.HikeDescription, hike.HikeAttendance);
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

        // Method that displays the view that the user sees when adding a product to the database 
        public async Task<IActionResult> Create()
		{
			var user = await _userManager.GetUserAsync(User);

			if (user.IsPatrolLeader == true)
			{
				var patrolMembersListViewModel = new HikeListViewModel();
				patrolMembersListViewModel.PatrolMembers = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId?.ToString());

				var patrolMembersList = patrolMembersListViewModel.PatrolMembers.Select(u => u.FirstName + " " + u.LastName).ToList();
				ViewBag.CheckboxOptions = patrolMembersList;

				return View();
			}
			else
			{
				return RedirectToAction("AccessDenied", "Account", new { area = "Account" });
			}

		}

		// This is the method that saves the farmer's product information in the database
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(List<string> SelectedScouts, HikeListViewModel model)
		{
			var user = await _userManager.GetUserAsync(User);

			var patrolMembersListViewModel = new HikeListViewModel();
			patrolMembersListViewModel.PatrolMembers = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId?.ToString());

			var patrolMembersList = patrolMembersListViewModel.PatrolMembers.Select(u => u.FirstName + " " + u.LastName).ToList();
			ViewBag.CheckboxOptions = patrolMembersList;
            
			DateTime minValue = DateTime.MinValue;

			if (ModelState.IsValid)
			{
				if (model.NameOfHike != null || model.PermitID != null || model.StartDateAndTime != minValue || model.EndDateAndTime != minValue || model.NameOfVenue != null || model.AddressOfVenue != null || model.CostOfHike != null || model.DistanceOfHike != 0 || model.DescriptionOfHike != null)
				{
					var hikeDetails = new Hike();

					hikeDetails.PatrolId = Int32.Parse(user.PatrolId);

					hikeDetails.HikeName = model.NameOfHike;
					hikeDetails.PermitId = model.PermitID;
					hikeDetails.VenueName = model.NameOfVenue;
					hikeDetails.VenueAddress = model.AddressOfVenue;
					hikeDetails.HikeCost = model.CostOfHike;
					hikeDetails.Distance = model.DistanceOfHike;
					hikeDetails.HikeDescription = model.DescriptionOfHike;

					string hikeAttendance = "";

					foreach (var scout in SelectedScouts)
					{
						hikeAttendance += scout + ", ";

					}

					if (hikeAttendance != "")
					{
						if (model.StartDateAndTime >= model.EndDateAndTime)
						{
							TempData["error"] = "Error! Please ensure that the Hike's Start Date and time is before the End Date!";
							return View();
						}
						else
						{
							string strStartDate = DateTime.Parse(model.StartDateAndTime.ToString()).ToString("dd/MM/yyyy");

							var sdt = DateTime.ParseExact(strStartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

							hikeDetails.StartDateTime = sdt;

							hikeDetails.StartDateTimeStr = strStartDate;


							string strEndDate = DateTime.Parse(model.EndDateAndTime.ToString()).ToString("dd/MM/yyyy");

							var edt = DateTime.ParseExact(strEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

							hikeDetails.EndDateTime = edt;

							hikeDetails.EndDateTimeStr = strEndDate;


							hikeDetails.HikeAttendance = hikeAttendance;

							// adds the product to the database
							_appDBContext.Hikes.Add(hikeDetails);

							// saves the chanages
							_appDBContext.SaveChanges();

							// displays the message tha the product has been successfully saved in the database
							TempData["success"] = "Hike successfully saved!";

							// returns the list of products added to the database by the specific farmer taht is loggged in
							return RedirectToAction("Index");

						}

					}
					else
					{
						TempData["error"] = "Error! Please select who attended the hike!";
						return View();

					}

				}
				else
				{
					// displays the message tha the product has been successfully saved in the database
					TempData["error"] = "Error! Please fill in all details about the hike!";

					return View(model);
				}
			}
			else
			{
				// displays the message tha the product has been successfully saved in the database
				TempData["error"] = "Error! Please fill in all details about the hike!";

				return View(model);
			}

		}
	}
}
