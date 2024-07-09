using FormValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormValidation.Controllers
{
    
    public class AccountController : Controller
    {
        public IActionResult WeaklyTypedLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginPost(string username, string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();  
        }
        public IActionResult StronglyTypedLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginSuccess(LoginViewModel Login)
        {
            ViewBag.username = Login.Username;
            ViewBag.password = Login.Password;
            return View();
        }
    }
}
