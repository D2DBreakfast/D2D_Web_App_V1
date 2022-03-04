using D2D.WebApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D2D.WebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public IActionResult CheckUser(LoginVM vm)
        {

            // code to connect backend . 

            return RedirectToAction("Statistics", "Dashboard");
        }
        public IActionResult RegisterUser()
        {
            return View();
        }
    }
}
