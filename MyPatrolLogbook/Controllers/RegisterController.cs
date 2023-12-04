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
    public class RegisterController : Controller
    {
        // Readonly variables
        private readonly IRegisterRepository registerRepository;
        private readonly AppDBContext _appDBContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUserRepository applicationUserRepository;

        // Constructor
        public RegisterController(IRegisterRepository registerRepository, AppDBContext appDBContext, UserManager<ApplicationUser> userManager, IApplicationUserRepository applicationUserRepository)
        {
            this.registerRepository = registerRepository;
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
                                var registerListViewModel = new RegisterListViewModel();
                                registerListViewModel.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                return View(registerListViewModel);

                            }
                            else
                            {
                                if (!StartDate.Equals(parsedDate) && !StartDate.Equals(parsedDate))
                                {
                                    if (StartDate >= EndDate)
                                    {
                                        var registerListViewModel = new RegisterListViewModel();
                                        registerListViewModel.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                        TempData["error"] = "Error! End Date cannot be before the Start Date!";
                                        return View(registerListViewModel);
                                    }
                                    else
                                    {
                                        var filteredRegisterListViewModel = new RegisterListViewModel();
                                        filteredRegisterListViewModel.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && (f.AttendanceDate >= StartDate && f.AttendanceDate <= EndDate));

                                        return View(filteredRegisterListViewModel);
                                    }
                                }
                                else
                                {
                                    var registerListViewModel = new RegisterListViewModel();
                                    registerListViewModel.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                    return View(registerListViewModel);
                                }
                            }
                        }
                        else
                        {
                            return RedirectToAction("IndexReadOnly", "Register", new { area = "Register" });
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
                            var registerListViewModel = new RegisterListViewModel();
                            registerListViewModel.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                            return View(registerListViewModel);

                        }
                        else
                        {
                            if (!StartDate.Equals(parsedDate) && !StartDate.Equals(parsedDate))
                            {
                                if (StartDate >= EndDate)
                                {
                                    var registerListViewModel = new RegisterListViewModel();
                                    registerListViewModel.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                    TempData["error"] = "Error! End Date cannot be before the Start Date!";
                                    return View(registerListViewModel);
                                }
                                else
                                {
                                    var filteredRegisterListViewModel = new RegisterListViewModel();
                                    filteredRegisterListViewModel.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && f.AttendanceDate >= StartDate && f.AttendanceDate <= EndDate);

                                    return View(filteredRegisterListViewModel);
                                }
                            }
                            else
                            {
                                var registerListViewModel = new RegisterListViewModel();
                                registerListViewModel.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                return View(registerListViewModel);
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

        public async Task<FileResult> ExportRegisterInExcel()
        {
            var user = await _userManager.GetUserAsync(User);

            var register = new RegisterListViewModel();
            register.Registers = registerRepository.GetAllRegisters.Where(f => f.PatrolId == Int32.Parse(user.PatrolId)).ToList();

            var fileName = "PatrolRegister.xlsx";
            return GenerateExcel(fileName, register.Registers);
        }

        private FileResult GenerateExcel(string fileName, IEnumerable<Register> registers)
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

        // Method that displays the view that the user sees when adding a product to the database 
        public async Task<IActionResult> Create()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user.IsPatrolLeader == true)
            {
                var patrolMembersListViewModel = new RegisterListViewModel();
                patrolMembersListViewModel.PatrolMembers = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId?.ToString());

                var patrolMembersList = patrolMembersListViewModel.PatrolMembers.Select(u => u.FirstName +" "+ u.LastName).ToList();
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
        public async Task<IActionResult> Create(List<string> MeetingAttendanceScouts, RegisterListViewModel model)
        {
            var user = await _userManager.GetUserAsync(User);

            var patrolMembersListViewModel = new RegisterListViewModel();
            patrolMembersListViewModel.PatrolMembers = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId?.ToString());

            var patrolMembersList = patrolMembersListViewModel.PatrolMembers.Select(u => u.FirstName + " " + u.LastName).ToList();
            ViewBag.CheckboxOptions = patrolMembersList;

            DateTime minValue = DateTime.MinValue;

            if (ModelState.IsValid)  
            {
                var registerDetails = new Register();

                if (model.MeetingAttendanceDate != minValue)
				{
                    registerDetails.PatrolId = Int32.Parse(user.PatrolId);

					string strDate = DateTime.Parse(model.MeetingAttendanceDate.ToString()).ToString("dd/MM/yyyy");

					var sdt = DateTime.ParseExact(strDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

					registerDetails.AttendanceDate = sdt;

					registerDetails.AttendanceDateStr = strDate;


					string meetingAttendance = "";

                    foreach (var scout in MeetingAttendanceScouts)
                    {
                        meetingAttendance += scout + ", ";

                    }

                    if (meetingAttendance != "")
                    {
                        registerDetails.MeetingAttendance = meetingAttendance;

                        // adds the product to the database
                        _appDBContext.Registers.Add(registerDetails);

                        // saves the chanages
                        _appDBContext.SaveChanges();

                        // displays the message tha the product has been successfully saved in the database
                        TempData["success"] = "Register successfully captured!";

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
