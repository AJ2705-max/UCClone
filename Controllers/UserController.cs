using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Text.Json;
using UrbanClapClone.BusinessManager.IBAL;
using UrbanClapClone.Models;

namespace UrbanClapClone.Controllers
{
    public class UserController : Controller
    {
        readonly IUrbanBAL _IUrbanBAL;

        public UserController(IUrbanBAL UrbanBAL)
        {
            _IUrbanBAL = UrbanBAL;
        }

        public IActionResult Register() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterPost([FromBody] UserRegistrationModel model) 
        {          
             _IUrbanBAL.Register(model);

            return Json(new { status = "success", message = "User Registered Successfully!!!" });
        }
    }
}
