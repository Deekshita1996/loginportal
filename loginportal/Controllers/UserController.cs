using loginportal.AppDB_context;
using loginportal.Models;
using loginportal.Services.IService;
using loginportal.Services.Service;
using Microsoft.AspNetCore.Mvc;

namespace loginportal.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
           
            _userService = userService;
        }


        [HttpPost]
        public IActionResult Index()
        {
           if (ModelState.IsValid)
           {
                return RedirectToAction("Success");
           }
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }
        public IActionResult Registration(Registration registration)
        {
            _userService.insertData(registration);  
            return View("Registration");

        }

        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult AlreadyHaveAccount()
        {
            // Redirect to the main login page
            return RedirectToAction("Login");
        }
    }
}
