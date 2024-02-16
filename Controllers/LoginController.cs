using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using UrbanClapClone.BusinessManager.IBAL;
using UrbanClapClone.Models;

namespace UrbanClapClone.Controllers
{
    public class LoginController : Controller
    {
        readonly ILoginBAL _ILoginBAL;
        public LoginController(ILoginBAL loginBAL)
        {
            _ILoginBAL = loginBAL;
        }        

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost(string UserName, string Password) 
        {
            UserLoginModel login = new UserLoginModel();

            if (ModelState.IsValid) 
            {
                login = _ILoginBAL.LoginUser(UserName, Password);

                if (!login.NameExist) 
                {
                    return Json(new { status = "warning", message = "UserName does Not Exist!" });
                }
                else if(login.GetPassword != login.ExistingPassword) 
                {
                    return Json(new { status = "warning", message = "Invalid Password!" });
                }
            }

         //   _ILoginBAL.LoginUser(UserName, Password, Id);

            return Json(new { status = "success", message = "User Logged In Successfully!!!" });

            //return Json("index");
        }
    }
}
