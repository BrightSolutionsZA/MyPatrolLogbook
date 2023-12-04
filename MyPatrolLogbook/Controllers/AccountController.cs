using Microsoft.AspNetCore.Mvc;

namespace MyPatrolLogbook.Controllers
{
    // Controller that directs the user to the Access Denied Page
    public class AccountController : Controller
    {
		public IActionResult AccessDenied()
		{
			// Returns the Acces Denied View
			return View();
		}
	}
}
