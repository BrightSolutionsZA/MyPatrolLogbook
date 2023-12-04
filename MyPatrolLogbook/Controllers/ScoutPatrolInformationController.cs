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
    [Authorize(Roles = "TroopScouter")]
    public class ScoutPatrolInformationController : Controller
    {
        // Readonly variables
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUserRepository applicationUserRepository;
        private readonly IPatrolRepository patrolRepository;
        private readonly AppDBContext _appDBContext;
        private readonly ITroopRepository troopRepository;
        private readonly IEmailSender _emailSender;
        private readonly ICampRepository campRepository; 
        private readonly IHikeRepository hikeRepository;
        private readonly ICommunityServiceRepository communityServiceRepository;
        private readonly IPatrolActivityRepository patrolActivityRepository;
        private readonly IRegisterRepository registerRepository;

        // Variables
        private static ApplicationUser scoutFromDb;
        private static string FilterByPatrolCamp;
        private static string FilterByPatrolInfo;
        private static string FilterByPatrolHike;
        private static string FilterByPatrolCommunityService;
        private static string FilterByPatrolActivity;
        private static string FilterByPatrolRegister;

        // Constructor
        public ScoutPatrolInformationController(IRegisterRepository registerRepository, IPatrolActivityRepository patrolActivityRepository, ICommunityServiceRepository communityServiceRepository, IHikeRepository hikeRepository, ICampRepository campRepository, ITroopRepository troopRepository, IEmailSender emailSender, AppDBContext appDBContext, IPatrolRepository patrolRepository, UserManager<ApplicationUser> userManager, IApplicationUserRepository applicationUserRepository)
        {
            this.patrolRepository = patrolRepository;
            this.applicationUserRepository = applicationUserRepository;
            _userManager = userManager;
            _appDBContext = appDBContext;
            _emailSender = emailSender;
            this.troopRepository = troopRepository;
            this.campRepository = campRepository;
            this.hikeRepository = hikeRepository;
            this.communityServiceRepository = communityServiceRepository;
            this.patrolActivityRepository = patrolActivityRepository;
            this.registerRepository = registerRepository;
        }

        public async Task<IActionResult> PatrolInformationReadOnly()
        {
            // gets the Troop Scouter's id so that the relevant information can be accessed from the database
            var user = await _userManager.GetUserAsync(User);

            //if (!string.IsNullOrEmpty(user.ProvinceId))
            //{
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
                        var patrolListViewModel = new ScoutPatrolInformationListViewModel();
                        patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                        var patrolList = patrolListViewModel.Patrols.ToList();
                        SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
                        ViewBag.patrolList = list;

                        return View();
                        /*// fetch all of the scouts from the database that are a part of the troop
                        var scoutDetailsListViewModel = new ScoutPatrolInformationListViewModel();
                        scoutDetailsListViewModel.Scouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId && f.PatrolId != null && f.IsTroopScouter != false);

                        ScoutPatrolInformationListViewModel viewModelInformation = new ScoutPatrolInformationListViewModel
                        {
                            Patrols = patrolListViewModel.Patrols,
                            Scouts = scoutDetailsListViewModel.Scouts
                        };

                        // Display the information to the Troop Scouter
                        return View(viewModelInformation);*/
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
            /*}
            else
            {

                return RedirectToAction("Assign", "Role", new { area = "Role" });
            }*/
         }

        // If the Troop Scouter filters the list of current scouts by a specific patrol, then the following is displayed
        [HttpPost]
        public async Task<IActionResult> PatrolInformationReadOnly(string pl)
        {
            // gets the Troop Scouter's id so that the relevant information can be accessed from the database
            var user = await _userManager.GetUserAsync(User);

            // The list of Patrols that belong to the Troop Scouter's Troop are populated in the dropdownlist
            var patrolListViewModel = new ScoutPatrolInformationListViewModel();
            patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

            var patrolList = patrolListViewModel.Patrols.ToList();
            SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
            ViewBag.patrolList = list;

            // Get the value of the selected patrol from the dropdownlist
            FilterByPatrolInfo = Request.Form["PatrolList"];

            // if the Troop Scouter does not filter the list of Scouts that belong to their troop, then all of the scouts within their troop are displayed to them 
            if (!string.IsNullOrEmpty(FilterByPatrolInfo))
            {
                string patrolName = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolInfo)).Select(s => s.PatrolName).FirstOrDefault().ToString();

                ViewData["filterByPatrolInformation"] = "Selected Patrol: " + patrolName;

                // fetch all of the scouts from the database that are a part of the troop and that belong to the selected patrol
                var scoutsInFilteredPatroltListViewModel = new ScoutPatrolInformationListViewModel();
                scoutsInFilteredPatroltListViewModel.Scouts = applicationUserRepository.GetSelectedScouts.Where(f => f.TroopId == user.TroopId && f.IsTroopScouter == false && f.PatrolId == FilterByPatrolInfo && f.IsPatrolLeader != null);

                // fetch all of the patrols that are apart of the troop
                var filteredPatroltListViewModel = new ScoutPatrolInformationListViewModel();
                filteredPatroltListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                // Create the CombinedViewModel and populate it with the data regarding the list of filtered scouts and patrols from the troop 
                ScoutPatrolInformationListViewModel viewSearchedScoutInformation = new ScoutPatrolInformationListViewModel
                {
                    Patrols = filteredPatroltListViewModel.Patrols,
                    Scouts = scoutsInFilteredPatroltListViewModel.Scouts
                };

                // Display the filtered information to the Troop Scouter
                return View(viewSearchedScoutInformation);
            }
            // if the Troop Scouter has filtered the list of scouts by a particular patrol, then do the following
            else
            {
                ViewData["filterByPatrolInformation"] = "No Patrol Selected";
                return View();

            }

        }

        public async Task<IActionResult> ExportPatrolInformationInExcel()
        {
            var user = await _userManager.GetUserAsync(User);

            if (!string.IsNullOrEmpty(FilterByPatrolInfo))
            {
                var patrolInformation = new MyPatrolInformationListViewModel();
                patrolInformation.MyScouts = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == FilterByPatrolInfo).ToList();

                var patrols = new PatrolListViewModel();
                patrols.Patrols = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolInfo)).ToList();

                string patrolName = patrols.Patrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolInfo)).Select(n => n.PatrolName).FirstOrDefault().ToString();
                var fileName = patrolName + "_PatrolInformation.xlsx";

                return await GeneratePatrolInfoExcel(fileName, patrolInformation.MyScouts);

            }
            else
            {
                TempData["error"] = "Please filter by a patrol first!";
                return RedirectToAction("PatrolInformationReadOnly", "ScoutPatrolInformation", new { area = "ScoutPatrolInformation" });
            }

        }

        [HttpPost]
        private async Task<FileResult> GeneratePatrolInfoExcel(string fileName, IEnumerable<ApplicationUser> patrolInformation)
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


        public async Task<IActionResult> CampReadOnly()
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
                        var patrolListViewModel = new CampListViewModel();
                        patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                        var patrolList = patrolListViewModel.Patrols.ToList();
                        SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
                        ViewBag.patrolList = list;

                        return View();
                        /*var campListViewModel = new CampListViewModel();
                        campListViewModel.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId.ToString() == FilterByPatrolCamp);

                        CampListViewModel viewCampsInformation = new CampListViewModel
                        {
                            Patrols = patrolListViewModel.Patrols,
                            Camps = campListViewModel.Camps
                        };

                        return View(viewCampsInformation);*/
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
        public async Task<IActionResult> CampReadOnly(DateTime StartDate, DateTime EndDate)
        {
            // gets the Troop Scouter's id so that the relevant information can be accessed from the database
            var user = await _userManager.GetUserAsync(User);

            string dateString = "0001-01-01"; // Example date string in "yyyy-MM-dd" format
            DateTime parsedDate = DateTime.Parse(dateString);

            // The list of Patrols that belong to the Troop Scouter's Troop are populated in the dropdownlist
            var patrolListViewModel = new ScoutPatrolInformationListViewModel();
            patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

            var patrolList = patrolListViewModel.Patrols.ToList();
            SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
            ViewBag.patrolList = list;

            // Get the value of the selected patrol from the dropdownlist
            FilterByPatrolCamp = Request.Form["PatrolList"];
            // Method Call
            //ExportCampsInExcel(FilterByPatrolCamp);

            // if the Troop Scouter does not filter the list of Scouts that belong to their troop, then all of the scouts within their troop are displayed to them 
            if (!string.IsNullOrEmpty(FilterByPatrolCamp))
            {
                string patrolName = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolCamp)).Select(s => s.PatrolName).FirstOrDefault().ToString();

                ViewData["filterByPatrolCamp"] = "Selected Patrol: " + patrolName;

				var campListViewModel = new CampListViewModel();
				campListViewModel.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolCamp));

				CampListViewModel viewCampsInformation = new CampListViewModel
				{
					Patrols = patrolListViewModel.Patrols,
					Camps = campListViewModel.Camps
				};

				return View(viewCampsInformation);

            }
            else
            {
                ViewData["filterByPatrolCamp"] = "No Patrol Selected";
                return View();
			}

        }


        public async Task<IActionResult> ExportCampsInExcel()
        {
            var user = await _userManager.GetUserAsync(User);

            if (!string.IsNullOrEmpty(FilterByPatrolCamp))
            {
                var camps = new CampListViewModel();
                camps.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolCamp)).ToList();

                var patrols = new PatrolListViewModel();
                patrols.Patrols = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolCamp)).ToList();

                string patrolName = patrols.Patrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolCamp)).Select(n => n.PatrolName).FirstOrDefault().ToString();
                var fileName = patrolName + "_PatrolCamps.xlsx";

                return await GenerateCampExcel(fileName, camps.Camps);

            }
            else
            {
                TempData["error"] = "Please filter by a patrol first!";
                return RedirectToAction("CampReadOnly", "ScoutPatrolInformation", new { area = "ScoutPatrolInformation" });
            }
        }

        [HttpPost]
        private async Task<FileResult> GenerateCampExcel(string fileName, IEnumerable<Camp> camps)
        {
            var user = await _userManager.GetUserAsync(User);

            DataTable dataTable = new DataTable("Camp");
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("CampName"),
                new DataColumn("PermitId"),
                new DataColumn("StartDateTime"),
                new DataColumn("EndDateTime"),
                new DataColumn("VenueName"),
                new DataColumn("VenueAddress"),
                new DataColumn("CampCost"),
                new DataColumn("CampDescription"),
                new DataColumn("CampAttendance")
            });

            foreach (var camp in camps)
            {
                dataTable.Rows.Add(camp.CampName, camp.PermitId, camp.StartDateTimeStr, camp.EndDateTimeStr, camp.VenueName,
                    camp.VenueAddress, camp.CampCost, camp.CampDescription, camp.CampAttendance);
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

        public async Task<IActionResult> HikeReadOnly()
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
                        var patrolListViewModel = new HikeListViewModel();
                        patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                        var patrolList = patrolListViewModel.Patrols.ToList();
                        SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
                        ViewBag.patrolList = list;

                        return View();
                        /*var hikeListViewModel = new HikeListViewModel();
                        hikeListViewModel.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId.ToString() == FilterByPatrolHike);

                        HikeListViewModel viewHikeInformation = new HikeListViewModel
                        {
                            Patrols = patrolListViewModel.Patrols,
                            Hikes = hikeListViewModel.Hikes
                        };

                        return View(viewHikeInformation);*/
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
        public async Task<IActionResult> HikeReadOnly(DateTime StartDate, DateTime EndDate)
        {
            // gets the Troop Scouter's id so that the relevant information can be accessed from the database
            var user = await _userManager.GetUserAsync(User);

            // The list of Patrols that belong to the Troop Scouter's Troop are populated in the dropdownlist
            var patrolListViewModel = new ScoutPatrolInformationListViewModel();
            patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

            var patrolList = patrolListViewModel.Patrols.ToList();
            SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
            ViewBag.patrolList = list;

            // Get the value of the selected patrol from the dropdownlist
            FilterByPatrolHike = Request.Form["PatrolList"];

            // if the Troop Scouter does not filter the list of Scouts that belong to their troop, then all of the scouts within their troop are displayed to them 
            if (!string.IsNullOrEmpty(FilterByPatrolHike))
            {
                string patrolName = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolHike)).Select(s => s.PatrolName).FirstOrDefault().ToString();

                ViewData["filterByPatrolHike"] = "Selected Patrol: " + patrolName;

                    var hikeListViewModel = new HikeListViewModel();
                        hikeListViewModel.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolHike));

                        HikeListViewModel viewHikeInformation = new HikeListViewModel
                        {
                            Patrols = patrolListViewModel.Patrols,
                            Hikes = hikeListViewModel.Hikes
                        };

                        return View(viewHikeInformation);
                  
            }
            else
            {
                ViewData["filterByPatrolHike"] = "No Patrol Selected";
                return View();
            }

        }

        public async Task<IActionResult> ExportHikeInExcel()
        {
            var user = await _userManager.GetUserAsync(User);

            if (!string.IsNullOrEmpty(FilterByPatrolHike))
            {
                var hikes = new HikeListViewModel();
                hikes.Hikes = hikeRepository.GetAllHikes.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolHike)).ToList();

                var patrols = new PatrolListViewModel();
                patrols.Patrols = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolHike)).ToList();

                string patrolName = patrols.Patrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolHike)).Select(n => n.PatrolName).FirstOrDefault().ToString();
                var fileName = patrolName + "_PatrolHikes.xlsx";

                return await GeneratePatrolHikeExcel(fileName, hikes.Hikes);

            }
            else
            {
                TempData["error"] = "Please filter by a patrol first!";
                return RedirectToAction("HikeReadOnly", "ScoutPatrolInformation", new { area = "ScoutPatrolInformation" });
            }

        }

        [HttpPost]
        private async Task<FileResult> GeneratePatrolHikeExcel(string fileName, IEnumerable<Hike> hikes)
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


        public async Task<IActionResult> CommunityServiceReadOnly()
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
                        var patrolListViewModel = new HikeListViewModel();
                        patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                        var patrolList = patrolListViewModel.Patrols.ToList();
                        SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
                        ViewBag.patrolList = list;

                        return View();
                        /*var communityServiceListViewModel = new CommunityServiceListViewModel();
                        communityServiceListViewModel.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId.ToString() == FilterByPatrolCommunityService);

                        CommunityServiceListViewModel viewCommunityServiceInformation = new CommunityServiceListViewModel
                        {
                            Patrols = patrolListViewModel.Patrols,
                            Projects = communityServiceListViewModel.Projects
                        };

                        return View(viewCommunityServiceInformation);*/

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
        public async Task<IActionResult> CommunityServiceReadOnly(DateTime StartDate, DateTime EndDate)
        {
            // gets the Troop Scouter's id so that the relevant information can be accessed from the database
            var user = await _userManager.GetUserAsync(User);

            // The list of Patrols that belong to the Troop Scouter's Troop are populated in the dropdownlist
            var patrolListViewModel = new ScoutPatrolInformationListViewModel();
            patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

            var patrolList = patrolListViewModel.Patrols.ToList();
            SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
            ViewBag.patrolList = list;

            // Get the value of the selected patrol from the dropdownlist
            FilterByPatrolCommunityService = Request.Form["PatrolList"];

            // if the Troop Scouter does not filter the list of Scouts that belong to their troop, then all of the scouts within their troop are displayed to them 
            if (!string.IsNullOrEmpty(FilterByPatrolCommunityService))
            {
                string patrolName = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolCommunityService)).Select(s => s.PatrolName).FirstOrDefault().ToString();

                ViewData["filterByPatrolProject"] = "Selected Patrol: " + patrolName;
				
                var communityServiceListViewModel = new CommunityServiceListViewModel();
				communityServiceListViewModel.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId.ToString() == FilterByPatrolCommunityService);

				CommunityServiceListViewModel viewCommunityServiceInformation = new CommunityServiceListViewModel
				{
					Patrols = patrolListViewModel.Patrols,
					Projects = communityServiceListViewModel.Projects
				};

				return View(viewCommunityServiceInformation);

            }
            else
            {
                ViewData["filterByPatrolProject"] = "No Patrol Selected";
                return View();
            }

        }

        public async Task<IActionResult> ExportCommunityServiceInExcel()
        {
            var user = await _userManager.GetUserAsync(User);

            if (!string.IsNullOrEmpty(FilterByPatrolCommunityService))
            {
                var projects = new CommunityServiceListViewModel();
                projects.Projects = communityServiceRepository.GetAllProjects.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolCommunityService)).ToList();

                var patrols = new PatrolListViewModel();
                patrols.Patrols = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolCommunityService)).ToList();

                string patrolName = patrols.Patrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolCommunityService)).Select(n => n.PatrolName).FirstOrDefault().ToString();
                var fileName = patrolName + "_PatrolCommunityServiceProjects.xlsx";

                return await GeneratePatrolCommunityServiceExcel(fileName, projects.Projects);

            }
            else
            {
                TempData["error"] = "Please filter by a patrol first!";
                return RedirectToAction("CommunityServiceReadOnly", "ScoutPatrolInformation", new { area = "ScoutPatrolInformation" });
            }

        }

        [HttpPost]
        private async Task<FileResult> GeneratePatrolCommunityServiceExcel(string fileName, IEnumerable<CommunityService> projects)
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


        public async Task<IActionResult> PatrolActivityReadOnly()
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
                        var patrolListViewModel = new HikeListViewModel();
                        patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                        var patrolList = patrolListViewModel.Patrols.ToList();
                        SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
                        ViewBag.patrolList = list;

                        var patrolActivityListViewModel = new PatrolActivityListViewModel();
                        patrolActivityListViewModel.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId.ToString() == FilterByPatrolActivity);

                        PatrolActivityListViewModel viewPatrolActivityInformation = new PatrolActivityListViewModel
                        {
                            Patrols = patrolListViewModel.Patrols,
                            Activities = patrolActivityListViewModel.Activities
                        };

                        return View(viewPatrolActivityInformation);

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
        public async Task<IActionResult> PatrolActivityReadOnly(DateTime StartDate, DateTime EndDate)
        {
            // gets the Troop Scouter's id so that the relevant information can be accessed from the database
            var user = await _userManager.GetUserAsync(User);

            // The list of Patrols that belong to the Troop Scouter's Troop are populated in the dropdownlist
            var patrolListViewModel = new ScoutPatrolInformationListViewModel();
            patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

            var patrolList = patrolListViewModel.Patrols.ToList();
            SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
            ViewBag.patrolList = list;

            // Get the value of the selected patrol from the dropdownlist
            FilterByPatrolActivity = Request.Form["PatrolList"];

            // if the Troop Scouter does not filter the list of Scouts that belong to their troop, then all of the scouts within their troop are displayed to them 
            if (!string.IsNullOrEmpty(FilterByPatrolActivity))
            {
                string patrolName = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolActivity)).Select(s => s.PatrolName).FirstOrDefault().ToString();

                ViewData["filterByPatrolActivity"] = "Selected Patrol: " + patrolName;

				var patrolActivityListViewModel = new PatrolActivityListViewModel();
				patrolActivityListViewModel.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId.ToString() == FilterByPatrolActivity);

				PatrolActivityListViewModel viewPatrolActivityInformation = new PatrolActivityListViewModel
				{
					Patrols = patrolListViewModel.Patrols,
					Activities = patrolActivityListViewModel.Activities
				};

				return View(viewPatrolActivityInformation);

            }
            else
            {
                ViewData["filterByPatrolActivity"] = "No Patrol Selected";
                return View();
            }

        }

        public async Task<IActionResult> ExportPatrolActivityInExcel()
        {
            var user = await _userManager.GetUserAsync(User);

            if (!string.IsNullOrEmpty(FilterByPatrolActivity))
            {
                var patrolActivity = new PatrolActivityListViewModel();
                patrolActivity.Activities = patrolActivityRepository.GetAllActivities.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolActivity)).ToList();

                var patrols = new PatrolListViewModel();
                patrols.Patrols = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolActivity)).ToList();

                string patrolName = patrols.Patrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolActivity)).Select(n => n.PatrolName).FirstOrDefault().ToString();
                var fileName = patrolName + "_PatrolActivities.xlsx";

                return await GeneratePatrolActivityExcel(fileName, patrolActivity.Activities);

            }
            else
            {
                TempData["error"] = "Please filter by a patrol first!";
                return RedirectToAction("PatrolActivityReadOnly", "ScoutPatrolInformation", new { area = "ScoutPatrolInformation" });
            }

        }

        [HttpPost]
        private async Task<FileResult> GeneratePatrolActivityExcel(string fileName, IEnumerable<PatrolActivity> patrolActivities)
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


        public async Task<IActionResult> RegisterReadOnly()
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
                        var patrolListViewModel = new CampListViewModel();
                        patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

                        var patrolList = patrolListViewModel.Patrols.ToList();
                        SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
                        ViewBag.patrolList = list;


                        return View();
                        /* var registerListViewModel = new RegisterListViewModel();
                         registerListViewModel.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId.ToString() == FilterByPatrolRegister);

                         RegisterListViewModel viewRegistersInformation = new RegisterListViewModel
                         {
                             Patrols = patrolListViewModel.Patrols,
                             Registers = registerListViewModel.Registers
                         };
 
                        return View(viewRegistersInformation);*/
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
        public async Task<IActionResult> RegisterReadOnly(DateTime StartDate, DateTime EndDate)
        {
            // gets the Troop Scouter's id so that the relevant information can be accessed from the database
            var user = await _userManager.GetUserAsync(User);

            // The list of Patrols that belong to the Troop Scouter's Troop are populated in the dropdownlist
            var patrolListViewModel = new ScoutPatrolInformationListViewModel();
            patrolListViewModel.Patrols = patrolRepository.GetAllPatrols.Where(f => f.TroopId == Int32.Parse(user.TroopId));

            var patrolList = patrolListViewModel.Patrols.ToList();
            SelectList list = new SelectList(patrolList, "PatrolId", "PatrolName");
            ViewBag.patrolList = list;

            // Get the value of the selected patrol from the dropdownlist
            FilterByPatrolRegister = Request.Form["PatrolList"];

            // if the Troop Scouter does not filter the list of Scouts that belong to their troop, then all of the scouts within their troop are displayed to them 
            if (!string.IsNullOrEmpty(FilterByPatrolRegister))
            {
                string patrolName = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolRegister)).Select(s => s.PatrolName).FirstOrDefault().ToString();

                ViewData["filterByPatrolRegister"] = "Selected Patrol: " + patrolName;


				var registerListViewModel = new RegisterListViewModel();
				registerListViewModel.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolRegister));

				RegisterListViewModel viewRegistersInformation = new RegisterListViewModel
				{
					Patrols = patrolListViewModel.Patrols,
					Registers = registerListViewModel.Registers
				};

				return View(viewRegistersInformation);

            }
            else
            {
                ViewData["filterByPatrolRegister"] = "No Patrol Selected";
                
                return View();
            }

        }

        public async Task<IActionResult> ExportRegisterInExcel()
        {
            var user = await _userManager.GetUserAsync(User);

            if (!string.IsNullOrEmpty(FilterByPatrolRegister))
            {
                var register = new RegisterListViewModel();
                register.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolRegister)).ToList();

                var patrols = new PatrolListViewModel();
                patrols.Patrols = patrolRepository.GetAllPatrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolRegister)).ToList();

                string patrolName = patrols.Patrols.Where(f => f.PatrolId == Int32.Parse(FilterByPatrolRegister)).Select(n => n.PatrolName).FirstOrDefault().ToString();
                var fileName = patrolName + "_PatrolRegister.xlsx";

                return await GenerateRegisterExcel(fileName, register.Registers);

            }
            else
            {
                TempData["error"] = "Please filter by a patrol first!";
                return RedirectToAction("RegisterReadOnly", "ScoutPatrolInformation", new { area = "ScoutPatrolInformation" });
            }

        }

        [HttpPost]
        private async Task<FileResult> GenerateRegisterExcel(string fileName, IEnumerable<Register> registers)
        {
            DataTable dataTable = new DataTable("Register");
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("AttendanceDate"),
                new DataColumn("MeetingAttendance")
            });

            foreach (var register in registers)
            {
                dataTable.Rows.Add(register.AttendanceDateStr, register.MeetingAttendance);
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

    }
}
