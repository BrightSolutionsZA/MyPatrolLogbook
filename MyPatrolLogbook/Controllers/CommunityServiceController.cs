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
    public class CommunityServiceController : Controller
    {
        // Readonly variables
        private readonly ICommunityServiceRepository communityServiceRepository;
        private readonly AppDBContext _appDBContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUserRepository applicationUserRepository;

        // Constructor
        public CommunityServiceController(ICommunityServiceRepository communityServiceRepository, AppDBContext appDBContext, UserManager<ApplicationUser> userManager, IApplicationUserRepository applicationUserRepository)
        {
            this.communityServiceRepository = communityServiceRepository;
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
                                var communityServiceListViewModel = new CommunityServiceListViewModel();
                                communityServiceListViewModel.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                return View(communityServiceListViewModel);

                            }
                            else
                            {
                                if (!StartDate.Equals(parsedDate) && !StartDate.Equals(parsedDate))
                                {
                                    if (StartDate >= EndDate)
                                    {
                                        var communityServiceListViewModel = new CommunityServiceListViewModel();
                                        communityServiceListViewModel.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                        TempData["error"] = "Error! End Date cannot be before the Start Date!";

                                        return View(communityServiceListViewModel);
                                    }
                                    else
                                    {
                                        var communityServiceListViewModel = new CommunityServiceListViewModel();
                                        communityServiceListViewModel.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && f.StartDateTime >= StartDate && f.EndDateTime <= EndDate);

                                        return View(communityServiceListViewModel);
                                    }
                                }
                                else
                                {
                                    var communityServiceListViewModel = new CommunityServiceListViewModel();
                                    communityServiceListViewModel.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                    return View(communityServiceListViewModel);
                                }
                            }

                        }
                        else
                        {
                            return RedirectToAction("IndexReadOnly", "CommunityService", new { area = "CommunityService" });
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
                            var communityServiceListViewModel = new CommunityServiceListViewModel();
                            communityServiceListViewModel.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                            return View(communityServiceListViewModel);

                        }
                        else
                        {
                            if (!StartDate.Equals(parsedDate) && !StartDate.Equals(parsedDate))
                            {
                                if (StartDate >= EndDate)
                                {
                                    var communityServiceListViewModel = new CommunityServiceListViewModel();
                                    communityServiceListViewModel.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                    TempData["error"] = "Error! End Date cannot be before the Start Date!";

                                    return View(communityServiceListViewModel);
                                }
                                else
                                {
                                    var communityServiceListViewModel = new CommunityServiceListViewModel();
                                    communityServiceListViewModel.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && f.StartDateTime >= StartDate && f.EndDateTime <= EndDate);

                                    return View(communityServiceListViewModel);
                                }
                            }
                            else
                            {
                                var communityServiceListViewModel = new CommunityServiceListViewModel();
                                communityServiceListViewModel.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                return View(communityServiceListViewModel);
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

        public async Task<FileResult> ExportCommunityServiceInExcel()
        {
            var user = await _userManager.GetUserAsync(User);

            var projects = new CommunityServiceListViewModel();
            projects.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId == Int32.Parse(user.PatrolId)).ToList();

            var fileName = "PatrolCommunityServiceProjects.xlsx";
            return GenerateExcel(fileName, projects.Projects);
        }

        private FileResult GenerateExcel(string fileName, IEnumerable<CommunityService> projects)
        {
            DataTable dataTable = new DataTable("CommunityService");
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ProjectName"),
                new DataColumn("PermitId"),
                new DataColumn("StartDateTime"),
                new DataColumn("EndDateTime"),
                new DataColumn("VenueName"),
                new DataColumn("ProjectHours"),
                new DataColumn("ProjectDescription"),
                new DataColumn("ProjectAttendance")
            });

            foreach (var project in projects)
            {
                dataTable.Rows.Add(project.ProjectName, project.PermitId, project.StartDateTimeStr, project.EndDateTimeStr, project.VenueName,
                    project.ProjectHours, project.ProjectDescription, project.ProjectAttendance);
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
        public async Task<IActionResult> Create(List<string> SelectedScouts, CommunityServiceListViewModel model)
        {
            var user = await _userManager.GetUserAsync(User);

            var patrolMembersListViewModel = new HikeListViewModel();
            patrolMembersListViewModel.PatrolMembers = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId?.ToString());

            var patrolMembersList = patrolMembersListViewModel.PatrolMembers.Select(u => u.FirstName + " " + u.LastName).ToList();
            ViewBag.CheckboxOptions = patrolMembersList;

            DateTime minValue = DateTime.MinValue;

			if (ModelState.IsValid)
			{
                var projectDetails = new CommunityService();

                if (!string.IsNullOrEmpty(model.NameOfProject) || !string.IsNullOrEmpty(model.PermitID) || model.StartDateAndTime != minValue || model.EndDateAndTime != minValue || !string.IsNullOrEmpty(model.NameOfVenue) || model.OverallHours != null || !string.IsNullOrEmpty(model.DescriptionOfProject))
                {
                    projectDetails.PatrolId = Int32.Parse(user.PatrolId);

                    projectDetails.ProjectName = model.NameOfProject;
                    projectDetails.PermitId = model.PermitID;
                    projectDetails.VenueName = model.NameOfVenue;
                    projectDetails.ProjectHours = model.OverallHours;
                    projectDetails.ProjectDescription = model.DescriptionOfProject;

                    string projectAttendance = "";

                    foreach (var scout in SelectedScouts)
                    {
                        projectAttendance += scout + ", ";

                    }

                    if (projectAttendance != "")
                    {
                        if (model.StartDateAndTime >= model.EndDateAndTime)
                        {
                            TempData["error"] = "Error! Please ensure that the Project's Start Date and time is before the End Date!";
                            return View();
                        }
                        else
                        {
                            string strStartDate = DateTime.Parse(model.StartDateAndTime.ToString()).ToString("dd/MM/yyyy");

                            var sdt = DateTime.ParseExact(strStartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            projectDetails.StartDateTime = sdt;

                            projectDetails.StartDateTimeStr = strStartDate;


                            string strEndDate = DateTime.Parse(model.EndDateAndTime.ToString()).ToString("dd/MM/yyyy");

                            var edt = DateTime.ParseExact(strEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            projectDetails.EndDateTime = edt;

                            projectDetails.EndDateTimeStr = strEndDate;

                            projectDetails.ProjectAttendance = projectAttendance;

                            // adds the product to the database
                            _appDBContext.Projects.Add(projectDetails);

                            // saves the chanages
                            _appDBContext.SaveChanges();

                            // displays the message tha the product has been successfully saved in the database
                            TempData["success"] = "Community Service Project successfully saved!";

                            // returns the list of products added to the database by the specific farmer taht is loggged in
                            return RedirectToAction("Index");

                        }

                    }
                    else
                    {
                        TempData["error"] = "Error! Please select who took part in the project!";
                        return View();

                    }


                }
                else
                {
                    // displays the message tha the product has been successfully saved in the database
                    TempData["error"] = "Error! Please fill in all details about the project!";
                    return View(model);
                }

            }
            else
            {
                // displays the message tha the product has been successfully saved in the database
                TempData["error"] = "Error! Please fill in all details about the project!";

                return View(model);
            }

        }
    }
}
