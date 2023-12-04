using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyPatrolLogbook.Models;
using MyPatrolLogbook.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;

namespace MyPatrolLogbook.Controllers
{
    [Authorize(Roles = "Scout")]
    public class PatrolActivityController : Controller
	{
        // Readonly variables
        private readonly IPatrolActivityRepository patrolActivityRepository;
        private readonly AppDBContext _appDBContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUserRepository applicationUserRepository;

        // Constructor
        public PatrolActivityController(IPatrolActivityRepository patrolActivityRepository, AppDBContext appDBContext, UserManager<ApplicationUser> userManager, IApplicationUserRepository applicationUserRepository)
        {
            this.patrolActivityRepository = patrolActivityRepository;
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
                                var patrolActivityListViewModel = new PatrolActivityListViewModel();
                                patrolActivityListViewModel.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                return View(patrolActivityListViewModel);
                            }
                            else
                            {
                                if (!StartDate.Equals(parsedDate) && !StartDate.Equals(parsedDate))
                                {
                                    if (StartDate >= EndDate)
                                    {
                                        var patrolActivityListViewModel = new PatrolActivityListViewModel();
                                        patrolActivityListViewModel.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                        TempData["error"] = "Error! End Date cannot be before the Start Date!";

                                        return View(patrolActivityListViewModel);
                                    }
                                    else
                                    {
                                        var patrolActivityListViewModel = new PatrolActivityListViewModel();
                                        patrolActivityListViewModel.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && f.StartDateTime >= StartDate && f.EndDateTime <= EndDate);

                                        return View(patrolActivityListViewModel);
                                    }
                                }
                                else
                                {
                                    var patrolActivityListViewModel = new PatrolActivityListViewModel();
                                    patrolActivityListViewModel.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                    return View(patrolActivityListViewModel);
                                }
                            }
                        }
                        else
                        {
                            return RedirectToAction("IndexReadOnly", "PatrolActivity", new { area = "PatrolActivity" });
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
                            var patrolActivityListViewModel = new PatrolActivityListViewModel();
                            patrolActivityListViewModel.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                            return View(patrolActivityListViewModel);
                        }
                        else
                        {
                            if (!StartDate.Equals(parsedDate) && !StartDate.Equals(parsedDate))
                            {
                                if (StartDate >= EndDate)
                                {
                                    var patrolActivityListViewModel = new PatrolActivityListViewModel();
                                    patrolActivityListViewModel.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                    TempData["error"] = "Error! End Date cannot be before the Start Date!";

                                    return View(patrolActivityListViewModel);
                                }
                                else
                                {
                                    var patrolActivityListViewModel = new PatrolActivityListViewModel();
                                    patrolActivityListViewModel.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && f.StartDateTime >= StartDate && f.EndDateTime <= EndDate);

                                    return View(patrolActivityListViewModel);
                                }
                            }
                            else
                            {
                                var patrolActivityListViewModel = new PatrolActivityListViewModel();
                                patrolActivityListViewModel.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                return View(patrolActivityListViewModel);
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

        public async Task<FileResult> ExportPatrolActivityInExcel()
        {
            var user = await _userManager.GetUserAsync(User);

            var patrolActivity = new PatrolActivityListViewModel();
            patrolActivity.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId == Int32.Parse(user.PatrolId)).ToList();

            var fileName = "PatrolActivities.xlsx";
            return GenerateExcel(fileName, patrolActivity.Activities);
        }
        private FileResult GenerateExcel(string fileName, IEnumerable<PatrolActivity> patrolActivities)
        {
            DataTable dataTable = new DataTable("PatrolActivities");
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ActivityName"),
                new DataColumn("PermitId"),
                new DataColumn("StartDateTime"),
                new DataColumn("EndDateTime"),
                new DataColumn("VenueName"),
                new DataColumn("ActivityDescription"),
                new DataColumn("ActivityAttendance")
            });

            foreach (var patrolActivity in patrolActivities)
            {
                dataTable.Rows.Add(patrolActivity.ActivityName, patrolActivity.PermitId, patrolActivity.StartDateTimeStr, 
                    patrolActivity.EndDateTimeStr, patrolActivity.VenueName, 
                    patrolActivity.ActivityDescription, patrolActivity.ActivityAttendance);
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
                var patrolMembersListViewModel = new PatrolActivityListViewModel();
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
        public async Task<IActionResult> Create(List<string> SelectedScouts, PatrolActivityListViewModel model)
        {
            var user = await _userManager.GetUserAsync(User);

            var patrolMembersListViewModel = new PatrolActivityListViewModel();
            patrolMembersListViewModel.PatrolMembers = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId?.ToString());

            var patrolMembersList = patrolMembersListViewModel.PatrolMembers.Select(u => u.FirstName + " " + u.LastName).ToList();
            ViewBag.CheckboxOptions = patrolMembersList;

            DateTime minValue = DateTime.MinValue;

            if (ModelState.IsValid)
			{
                var activityDetails = new PatrolActivity();

                if  (model.NameOfActivity != null || model.PermitID != null || model.StartDateAndTime != minValue || model.EndDateAndTime != minValue || model.NameOfVenue != null || model.DescriptionOfActivity != null)
				{
					activityDetails.PatrolId = Int32.Parse(user.PatrolId);

                    activityDetails.ActivityName = model.NameOfActivity;
                    activityDetails.PermitId = model.PermitID;
                    activityDetails.VenueName = model.NameOfVenue;
                    activityDetails.ActivityDescription = model.DescriptionOfActivity;

                    string activityAttendance = "";

                    foreach (var scout in SelectedScouts)
                    {
                        activityAttendance += scout + ", ";

                    }

                    if (activityAttendance != "")
                    {
                        if (model.StartDateAndTime >= model.EndDateAndTime)
                        {
                            TempData["error"] = "Error! Please ensure that the Activity's Start Date and time is before the End Date!";
                            return View();
                        }
                        else
                        {
							string strStartDate = DateTime.Parse(model.StartDateAndTime.ToString()).ToString("dd/MM/yyyy");

							var sdt = DateTime.ParseExact(strStartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

							activityDetails.StartDateTime = sdt;

							activityDetails.StartDateTimeStr = strStartDate;


							string strEndDate = DateTime.Parse(model.EndDateAndTime.ToString()).ToString("dd/MM/yyyy");

							var edt = DateTime.ParseExact(strEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

							activityDetails.EndDateTime = edt;

							activityDetails.EndDateTimeStr = strEndDate;


                            activityDetails.ActivityAttendance = activityAttendance;

                            // adds the product to the database
                            _appDBContext.Activities.Add(activityDetails);

                            // saves the chanages
                            _appDBContext.SaveChanges();

                            // displays the message tha the product has been successfully saved in the database
                            TempData["success"] = "Patrol Activity successfully saved!";

                            // returns the list of products added to the database by the specific farmer taht is loggged in
                            return RedirectToAction("Index");

                        }

                    }
                    else
                    {
                        TempData["error"] = "Error! Please select all scouts that attended the Patrol Activity!";
                        return View();

                    }


                }

                // displays the message tha the product has been successfully saved in the database
                TempData["error"] = "Error! Please fill in all details about the activity!";
                return View(model);

            }
            else
            {
                // displays the message tha the product has been successfully saved in the database
                TempData["error"] = "Error! Please fill in all details about the activity!";

                return View(model);
            }

        }
    }
}
