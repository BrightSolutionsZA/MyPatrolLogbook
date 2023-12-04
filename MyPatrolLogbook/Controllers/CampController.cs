using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPatrolLogbook.Models;
using MyPatrolLogbook.ViewModels;
using System.Data;
using System.Globalization;

namespace MyPatrolLogbook.Controllers
{
    [Authorize(Roles = "Scout")]
    public class CampController : Controller
    {
        // Readonly variables
        private readonly ICampRepository campRepository;
        private readonly AppDBContext _appDBContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUserRepository applicationUserRepository;

        // Constructor
        public CampController(ICampRepository campRepository, AppDBContext appDBContext, UserManager<ApplicationUser> userManager, IApplicationUserRepository applicationUserRepository)
        {
            this.campRepository = campRepository;
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
                                var campListViewModel = new CampListViewModel();
                                campListViewModel.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                return View(campListViewModel);

                            }
                            else
                            {
                                if(!StartDate.Equals(parsedDate) && !StartDate.Equals(parsedDate))
                                {
                                    if (StartDate >= EndDate)
                                    {
                                        var campListViewModel = new CampListViewModel();
                                        campListViewModel.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                        TempData["error"] = "Error! End Date cannot be before the Start Date!";
                                        return View(campListViewModel);
                                    }
                                    else
                                    {
                                        var filteredCampListViewModel = new CampListViewModel();
                                        filteredCampListViewModel.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && f.StartDateTime >= StartDate && f.EndDateTime <= EndDate);

                                        return View(filteredCampListViewModel);
                                    }
                                }
                                else
                                {
                                    var campListViewModel = new CampListViewModel();
                                    campListViewModel.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                    return View(campListViewModel);
                                }
                            }
						}
						else
						{
							return RedirectToAction("IndexReadOnly", "Camp", new { area = "Camp" });
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
                            var campListViewModel = new CampListViewModel();
                            campListViewModel.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                            return View(campListViewModel);

                        }
                        else
                        {
                            if (!StartDate.Equals(parsedDate) && !StartDate.Equals(parsedDate))
                            {
                                if (StartDate >= EndDate)
                                {
                                    var campListViewModel = new CampListViewModel();
                                    campListViewModel.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                    TempData["error"] = "Error! End Date cannot be before the Start Date!";
                                    return View(campListViewModel);
                                }
                                else
                                {
                                    var filteredCampListViewModel = new CampListViewModel();
                                    filteredCampListViewModel.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId == Int32.Parse(user.PatrolId) && f.StartDateTime >= StartDate && f.EndDateTime <= EndDate);

                                    return View(filteredCampListViewModel);
                                }
                            }
                            else
                            {
                                var campListViewModel = new CampListViewModel();
                                campListViewModel.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId == Int32.Parse(user.PatrolId));

                                return View(campListViewModel);
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


        public async Task<FileResult> ExportCampsInExcel()
        {
            var user = await _userManager.GetUserAsync(User);

            var camps = new CampListViewModel();
            camps.Camps = campRepository.GetAllCamps.Where(f => f.PatrolId == Int32.Parse(user.PatrolId)).ToList();

            var fileName = "PatrolCamps.xlsx";
            return GenerateExcel(fileName, camps.Camps);
        }

        private FileResult GenerateExcel(string fileName, IEnumerable<Camp> camps)
        {
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

        // Method that displays the view that the user sees when adding a product to the database 
        public async Task<IActionResult> Create()
        {
            var user = await _userManager.GetUserAsync(User);

            if(user.IsPatrolLeader == true)
            {
                var patrolMembersListViewModel = new CampListViewModel();
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
		public async Task<IActionResult> Create(List<string> SelectedScouts, CampListViewModel model)
		{
			var user = await _userManager.GetUserAsync(User);

			var patrolMembersListViewModel = new CampListViewModel();
			patrolMembersListViewModel.PatrolMembers = applicationUserRepository.GetSelectedScouts.Where(f => f.PatrolId == user.PatrolId?.ToString());

			var patrolMembersList = patrolMembersListViewModel.PatrolMembers.Select(u => u.FirstName + " " + u.LastName).ToList();
			ViewBag.CheckboxOptions = patrolMembersList;

			DateTime minValue = DateTime.MinValue;

            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(model.NameOfCamp) || !string.IsNullOrEmpty(model.PermitID) || model.StartDateAndTime != minValue || model.EndDateAndTime != minValue || !string.IsNullOrEmpty(model.NameOfVenue) || !string.IsNullOrEmpty(model.AddressOfVenue) || model.CostOfCamp != null || !string.IsNullOrEmpty(model.DescriptionOfCamp))
                {
                    var campDetais = new Camp();
                    campDetais.PatrolId = Int32.Parse(user.PatrolId);

                    campDetais.CampName = model.NameOfCamp;
                    campDetais.PermitId = model.PermitID;
                    campDetais.VenueName = model.NameOfVenue;
                    campDetais.VenueAddress = model.AddressOfVenue;
                    campDetais.CampCost = model.CostOfCamp;
                    campDetais.CampDescription = model.DescriptionOfCamp;

                    string campAttendance = "";

                    foreach (var scout in SelectedScouts)
                    {
                        campAttendance += scout + ", ";

                    }

                    if (campAttendance != "")
                    {
                        if (model.StartDateAndTime >= model.EndDateAndTime)
                        {
                            TempData["error"] = "Error! Please ensure that the Camp's Start Date and time is before the End Date!";
                            return View();
                        }
                        else
                        {

                            string strStartDate = DateTime.Parse(model.StartDateAndTime.ToString()).ToString("dd/MM/yyyy");

                            var sdt = DateTime.ParseExact(strStartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            campDetais.StartDateTime = sdt;

                            campDetais.StartDateTimeStr = strStartDate;


                            string strEndDate = DateTime.Parse(model.EndDateAndTime.ToString()).ToString("dd/MM/yyyy");

                            var edt = DateTime.ParseExact(strEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            campDetais.EndDateTime = edt;

                            campDetais.EndDateTimeStr = strEndDate;

                            campDetais.CampAttendance = campAttendance;

                            // adds the product to the database
                            _appDBContext.Camps.Add(campDetais);

                            // saves the chanages
                            _appDBContext.SaveChanges();

                            // displays the message tha the product has been successfully saved in the database
                            TempData["success"] = "Camp successfully saved!";

                            // returns the list of products added to the database by the specific farmer taht is loggged in
                            return RedirectToAction("Index");
                        }
                    }
                    else
                    {
                        TempData["error"] = "Error! Please select who attended the camp!";
                        return View();

                    }


                }
                else
                {

                    // displays the message tha the product has been successfully saved in the database
                    TempData["error"] = "Error! Please fill in all details about the camp!";
                    return View(model);
                }
            }
            else
            {
                // displays the message tha the product has been successfully saved in the database
                TempData["error"] = "Error! Please fill in all details about the camp!";

                return View(model);
            }

		}
		/*// Method for the user to update the products details
        public IActionResult Edit(int? id)
        {
            // check if id is null or equal to zero
            // return notfound() as it is an invalid id
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // if the id is valid, then retrieve the product's information from the database
            // with the .Find method, we just have to pass the id
            var campFromDb = _appDBContext.Camps.Find(id);

            // now check if the product from the database is null - then return not found
            if (campFromDb == null)
            {
                return NotFound();
            }

            // if the product is found, then return it to the view with the products's information populated
            return View(campFromDb);
        }

        // Method to save the updated information to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Camp obj)
        {
            // obj = _appDBContext.Farmers.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);

            obj.PatrolId = Int32.Parse(user.PatrolId);

            // update the information in the database
            _appDBContext.Camps.Update(obj);

            // save the changes
            _appDBContext.SaveChanges();

            // display a message that the information has been updated successfully
            TempData["success"] = "Camp update successfully saved!";

            // return to the product's index page
            return RedirectToAction("Index");

        }

        // Method for the user to remove the producr details
        public IActionResult Delete(int? id)
        {
            // check if id is null or equal to zero
            // return notfound() as it is an invalid id
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // if the id is valid, then retrieve the product's information from the database
            // with the .Find method, we just have to pass the id
            var campFromDb = _appDBContext.Camps.Find(id);

            // now check if the product from the database is null - then return not found
            if (campFromDb == null)
            {
                return NotFound();
            }

            // if the product is found, then return it to the view with the product's information populated
            return View(campFromDb);
        }

        // Method to remove information from the database
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _appDBContext.Camps.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            // remove the information from the database
            _appDBContext.Camps.Remove(obj);

            // save the changes
            _appDBContext.SaveChanges();

            // display a message that the information has been removed successfully
            TempData["success"] = "Camp successfully removed!";

            // return to the product's index page
            return RedirectToAction("Index");

        }

    */
	}
}
