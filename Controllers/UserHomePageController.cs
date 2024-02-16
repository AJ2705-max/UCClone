using Microsoft.AspNetCore.Mvc;

namespace UrbanClapClone.Controllers
{
    public class UserHomePageController : Controller
    {
        public IActionResult UserDashboard()
        {
            return View();
        }
    }
}
