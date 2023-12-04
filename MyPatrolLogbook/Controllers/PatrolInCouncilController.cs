using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2019.Drawing.Model3D;
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
    public class PatrolInCouncilController : Controller
    {
        // Readonly variables
        private readonly IPatrolInCouncilRepository patrolInCouncilRepository;
        private readonly AppDBContext _appDBContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUserRepository applicationUserRepository;

        // Constructor
        public PatrolInCouncilController(IPatrolInCouncilRepository patrolInCouncilRepository, AppDBContext appDBContext, UserManager<ApplicationUser> userManager, IApplicationUserRepository applicationUserRepository)
        {
            this.patrolInCouncilRepository = patrolInCouncilRepository;
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
                                var patrolInCouncilListViewModel = new PatrolInCouncilListViewModel();
                                patrolInCouncilListViewModel.PatrolInCouncils = patrolInCouncilRepository.GetAllPatrolInCouncils.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                return View(patrolInCouncilListViewModel);

                            }
                            else
                            {
                                if (!StartDate.Equals(parsedDate) && !StartDate.Equals(parsedDate))
                                {
                                    if (StartDate >= EndDate)
                                    {
                                        var patrolInCouncilListViewModel = new PatrolInCouncilListViewModel();
                                        patrolInCouncilListViewModel.PatrolInCouncils = patrolInCouncilRepository.GetAllPatrolInCouncils.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                        TempData["error"] = "Error! End Date cannot be before the Start Date!";
                                        return View(patrolInCouncilListViewModel);
                                    }
                                    else
                                    {
                                        var filteredPatrolInCouncilListViewModel = new PatrolInCouncilListViewModel();
                                        filteredPatrolInCouncilListViewModel.PatrolInCouncils = patrolInCouncilRepository.GetAllPatrolInCouncils.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && (f.PICDate >= StartDate && f.PICDate <= EndDate));

                                        return View(filteredPatrolInCouncilListViewModel);
                                    }
                                }
                                else
                                {
                                    var patrolInCouncilListViewModel = new PatrolInCouncilListViewModel();
                                    patrolInCouncilListViewModel.PatrolInCouncils = patrolInCouncilRepository.GetAllPatrolInCouncils.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                    return View(patrolInCouncilListViewModel);
                                }
                            }
                        }
                        else
                        {
                            return RedirectToAction("IndexReadOnly", "PatrolInCouncil", new { area = "PatrolInCouncil" });
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
                            var patrolInCouncilListViewModel = new PatrolInCouncilListViewModel();
                            patrolInCouncilListViewModel.PatrolInCouncils = patrolInCouncilRepository.GetAllPatrolInCouncils.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                            return View(patrolInCouncilListViewModel);

                        }
                        else
                        {
                            if (!StartDate.Equals(parsedDate) && !StartDate.Equals(parsedDate))
                            {
                                if (StartDate >= EndDate)
                                {
                                    var patrolInCouncilListViewModel = new PatrolInCouncilListViewModel();
                                    patrolInCouncilListViewModel.PatrolInCouncils = patrolInCouncilRepository.GetAllPatrolInCouncils.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                    TempData["error"] = "Error! End Date cannot be before the Start Date!";
                                    return View(patrolInCouncilListViewModel);
                                }
                                else
                                {
                                    var filteredPatrolInCouncilListViewModel = new PatrolInCouncilListViewModel();
                                    filteredPatrolInCouncilListViewModel.PatrolInCouncils = patrolInCouncilRepository.GetAllPatrolInCouncils.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && f.PICDate >= StartDate && f.PICDate <= EndDate);

                                    return View(filteredPatrolInCouncilListViewModel);
                                }
                            }
                            else
                            {
                                var patrolInCouncilListViewModel = new PatrolInCouncilListViewModel();
                                patrolInCouncilListViewModel.PatrolInCouncils = patrolInCouncilRepository.GetAllPatrolInCouncils.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                return View(patrolInCouncilListViewModel);
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

        public async Task<FileResult> ExportPatrolInCouncilInExcel()
        {
            var user = await _userManager.GetUserAsync(User);

            var patrolInCouncil = new PatrolInCouncilListViewModel();
            patrolInCouncil.PatrolInCouncils = patrolInCouncilRepository.GetAllPatrolInCouncils.Where(f => f.PatrolId == Int32.Parse(user.PatrolId)).ToList();

            var fileName = "PatrolInCouncils.xlsx";
            return GenerateExcel(fileName, patrolInCouncil.PatrolInCouncils);
        }
        private FileResult GenerateExcel(string fileName, IEnumerable<PatrolInCouncil> patrolInCouncils)
        {
            DataTable dataTable = new DataTable("PatrolInCouncils");
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("PICDate"),
                new DataColumn("PICAttendance"),
                new DataColumn("PICPoints"),
                new DataColumn("PICDescription")
            });

            foreach (var patrolInCouncil in patrolInCouncils)
            {
                dataTable.Rows.Add(patrolInCouncil.PICDateStr, patrolInCouncil.PICAttendance,
                    patrolInCouncil.PICPoints, patrolInCouncil.PICDescription);
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
                var patrolMembersListViewModel = new RegisterListViewModel();
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
        public async Task<IActionResult> Create(List<string> AttendanceAtPIC, PatrolInCouncilListViewModel model)
        {
            var user = await _userManager.GetUserAsync(User);

            var patrolMembersListViewModel = new PatrolInCouncilListViewModel();
            patrolMembersListViewModel.PatrolMembers = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId?.ToString());

            var patrolMembersList = patrolMembersListViewModel.PatrolMembers.Select(u => u.FirstName + " " + u.LastName).ToList();
            ViewBag.CheckboxOptions = patrolMembersList;

            if (ModelState.IsValid) 
            {
                var patrolInCouncilDetails = new PatrolInCouncil();

                DateTime minValue = DateTime.MinValue;

				if (!string.IsNullOrEmpty(model.PointsDiscussedInPIC) || !string.IsNullOrEmpty(model.DescriptionOfPIC) || model.DateofPIC != minValue)
				{
                    patrolInCouncilDetails.PatrolId = Int32.Parse(user.PatrolId);

					string strDate = DateTime.Parse(model.DateofPIC.ToString()).ToString("dd/MM/yyyy");

					var sdt = DateTime.ParseExact(strDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

					patrolInCouncilDetails.PICDate = sdt;

					patrolInCouncilDetails.PICDateStr = strDate;

					patrolInCouncilDetails.PICPoints = model.PointsDiscussedInPIC;

                    patrolInCouncilDetails.PICDescription = model.DescriptionOfPIC;

                    string picAttendance = "";

                    foreach (var scout in AttendanceAtPIC)
                    {
                        picAttendance += scout + ", ";

                    }

                    if (picAttendance != "")
                    {
                        patrolInCouncilDetails.PICAttendance = picAttendance;

                        // adds the product to the database
                        _appDBContext.PatrolInCouncils.Add(patrolInCouncilDetails);

                        // saves the chanages
                        _appDBContext.SaveChanges();

                        // displays the message tha the product has been successfully saved in the database
                        TempData["success"] = "Patrol In Council successfully captured!";

                        // returns the list of products added to the database by the specific farmer taht is loggged in
                        return RedirectToAction("Index");

                    }
                    else
                    {
                        TempData["error"] = "Error! Please select who attended the meeting!";
                        return View();

                    }


                }

                // displays the message tha the product has been successfully saved in the database
                TempData["error"] = "Error! Please ensure all details are filled in!";
                return View(model);

            }
            else
            {
                // displays the message tha the product has been successfully saved in the database
                TempData["error"] = "Error! Please ensure all details are filled in!";

                return View(model);
            }

        }
    }
}