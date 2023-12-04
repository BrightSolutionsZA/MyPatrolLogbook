using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyPatrolLogbook.Models;
using Microsoft.Extensions.Options;
using MyPatrolLogbook.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Text.Encodings.Web;

namespace MyPatrolLogbook.Controllers
{
	// Controller that controls the Different Roles added to the database by the SuperUser, as well as the assignment of Roles when the user registers
	public class RoleController : Controller
    {
        // variables
        private RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> userManager;
        private readonly IProvinceRepository provinceRepository;
        private readonly IEmailSender _emailSender;

        // constructor
        public RoleController(IProvinceRepository provinceRepository, IEmailSender emailSender, RoleManager<IdentityRole> roleMgr, UserManager<ApplicationUser> _userManager)
        {
            this.provinceRepository = provinceRepository;
            roleManager = roleMgr;
            userManager = _userManager;
            _emailSender = emailSender;
        }

        // Only the  SuperUser Role can access the RoleController Views

        [Authorize(Roles = "SuperUser")]

        // returns the index view - which displays all the roles saved in the database 
        public ViewResult Index() => View(roleManager.Roles);

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        [Authorize(Roles = "SuperUser")]
        // returns the create view - which allows the SuperUser to add new roles to the database
        public IActionResult Create() => View();

        // when a new role is created by the SuperUser, this is the method that saves it to the database
        [HttpPost]
        public async Task<IActionResult> Create([Required] string name)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await roleManager.CreateAsync(new IdentityRole(name));
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            return View(name);
        }

        // when a new role is deleted by the SuperUser, this is the method that removed it from the database
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                IdentityResult result = await roleManager.DeleteAsync(role);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            else
                ModelState.AddModelError("", "No role found");
            return View("Index", roleManager.Roles);
        }

        [Authorize(Roles = "SuperUser")]
        // this is the method that allows the SuperUser to edit the role that a user has selected for themselves
        public async Task<IActionResult> Update(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            List<ApplicationUser> members = new List<ApplicationUser>();
            List<ApplicationUser> nonMembers = new List<ApplicationUser>();
            foreach (ApplicationUser user in userManager.Users)
            {
                var list = await userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
            }
            return View(new RoleEdit
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            });
        }

        // when a new role is updated by the SuperUser, this is the method that updates it in the database
        [HttpPost]
        public async Task<IActionResult> Update(RoleModification model)
        {
            IdentityResult result;
            if (ModelState.IsValid)
            {
                foreach (string userId in model.AddIds ?? new string[] { })
                {
                    ApplicationUser user = await userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        result = await userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                            Errors(result);
                    }
                }
                foreach (string userId in model.DeleteIds ?? new string[] { })
                {
                    ApplicationUser user = await userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        result = await userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                            Errors(result);
                    }
                }
            }

            if (ModelState.IsValid)
                return RedirectToAction(nameof(Index));
            else
                return await Update(model.RoleId);
        }

        public ViewResult Assign() => View();


        // returns the Assign view - which is the page where the user must select their role when registering
        public ViewResult AssignScout() 
        {
            // Populate DropdownList
            var displayProvinceListViewModel = new ProvinceListViewModel();
            displayProvinceListViewModel.Provinces = provinceRepository.GetAllProvinces;

            var provinceList = displayProvinceListViewModel.Provinces.ToList();
            SelectList list = new SelectList(provinceList, "ProvinceId", "ProvinceName");
            ViewBag.provinceList = list;

            return View(roleManager.Roles);
        } 

        // This is the method that saves the user's role in the database
        public async Task<IActionResult> SubmitScout(string selectedRole, string returnUrl = null)
        {
            // Save the province that the user is from to the table
            var user = await userManager.GetUserAsync(User);

            // Get Selected province from dropdown
            string selectedValue = Request.Form["ProvinceList"];

            if (!selectedValue.Equals(""))
            {
                user.ProvinceId = selectedValue;
                //user.ProvinceId = "UpdateSuccess";
                await userManager.UpdateAsync(user);
            }
            else
            {
                // displays error message
                TempData["error"] = "Error! Please select a valid province!";

                // returns the assign page so that the user can select a valid role
                return RedirectToAction("AssignScout", "Role");
            }

            // checks that the user has selected a role
            selectedRole = "Scout";

                 // Check that the email ends in the gardenglow email suffix
                    if (userManager.GetUserName(User).Contains("@scouts.org.za"))
                    {
                        // displays error message
                        TempData["error"] = "Please select the Troop Scouter option as you are using your Scout's Email!";

                        // returns the assign page so that the user can select a valid role
                        return RedirectToAction("Assign", "Role");
                    }
                    else
                    {
                        // Add the role to the user
                        await userManager.AddToRoleAsync(user, selectedRole);

                        user.IsTroopScouter = false;

                        user.IsProvincialAdmin = false;

                        await userManager.UpdateAsync(user);

                        // displays success message
                       // TempData["success"] = "Scout successfully registered!";

                        returnUrl ??= Url.Content("~/");
                        var userId = await userManager.GetUserIdAsync(user);
                        var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                        var callbackUrl = Url.Page(
                            "/Account/ConfirmEmail",
                            pageHandler: null,
                            values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                        await _emailSender.SendEmailAsync(user.Email, "Confirm your email",
                                   $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                        // redirects the user to a new page
                        return RedirectToAction("Confirm", "Role");

                    }
        }

        public ViewResult AssignTS()
        {
            // Populate DropdownList
            var displayProvinceListViewModel = new ProvinceListViewModel();
            displayProvinceListViewModel.Provinces = provinceRepository.GetAllProvinces;

            var provinceList = displayProvinceListViewModel.Provinces.ToList();
            SelectList list = new SelectList(provinceList, "ProvinceId", "ProvinceName");
            ViewBag.provinceList = list;

            return View(roleManager.Roles);
        }

        // This is the method that saves the user's role in the database
        public async Task<IActionResult> SubmitTS(string selectedRole, string returnUrl = null)
        {
            // Save the province that the user is from to the table
            var user = await userManager.GetUserAsync(User);

            // Get Selected province from dropdown
            string selectedValue = Request.Form["ProvinceList"];

            if (!selectedValue.Equals(""))
            {
                user.ProvinceId = selectedValue;
                //user.ProvinceId = "UpdateSuccess";
                await userManager.UpdateAsync(user);
            }
            else
            {
                // displays error message
                TempData["error"] = "Error! Please select a valid province!";

                // returns the assign page so that the user can select a valid role
                return RedirectToAction("Assign", "Role");
            }

            // checks that the user has selected a role
            selectedRole = "TroopScouter";
            {
                // if the user selects the option to be an employee, the following happens
                // Check that the email ends in the gardenglow email suffix
                if (userManager.GetUserName(User).Contains("@scouts.org.za") || user.Email.Equals("keishamoonasar@gmail.com") || user.Email.Equals("brightsolutionsza@gmail.com"))
                {
                    // Add the role to the user
                    await userManager.AddToRoleAsync(user, selectedRole);

                    user.IsProvincialAdmin = false;

                    /* // displays success message
                     TempData["success"] = "An email has been sent to your provincial admin to verify your account!";
                     user.IsTroopScouter = true;

                     await userManager.UpdateAsync(user);*/

                    returnUrl ??= Url.Content("~/");
                    var userId = await userManager.GetUserIdAsync(user);
                    var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                    protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(user.Email, "Confirm your email",
                               $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    // redirects the user to a new page
                    return RedirectToAction("Confirm", "Role");
                }
                // if a farmer tries to select the employee option, then an error message will be displayed
                else
                {
                    // displays error message
                    TempData["error"] = "To register as a Troop Scouter, please use your Scout's Email!";

                    // returns the assign page so that the user can select a valid role as a farmer
                    return RedirectToAction("Assign", "Role");
                }
            }

        }

        // Returns the page for the user to confirm their account and then signs them out
        public IActionResult Confirm() => View();


    }
}
