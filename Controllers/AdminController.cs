using Microsoft.AspNetCore.Mvc;
using UrbanClapClone.BusinessManager.IBAL;
using UrbanClapClone.Models;

namespace UrbanClapClone.Controllers
{
    public class AdminController : Controller
    {
        readonly IAdminBAL _IAdminBAL;
        public AdminController(IAdminBAL AdminBAL)
        {
            _IAdminBAL = AdminBAL;
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult RegisterPost([FromBody] AdminRegistrationModel model)
        {
            _IAdminBAL.Register(model);

            return Json(new { status = "success", message = "User Registered Successfully!!!" });
        }
    }
}
