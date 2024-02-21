using Microsoft.AspNetCore.Mvc;

namespace UrbanClapClone.Controllers
{
    public class AdminHomePage : Controller
    {
        public IActionResult AdminDashboard()
        {
            return View();
        }
    }
}
