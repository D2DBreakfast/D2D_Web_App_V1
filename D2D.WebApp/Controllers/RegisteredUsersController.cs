using D2D.WebApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D2D.WebApp.Controllers
{
    public class RegisteredUsersController : Controller
    {
        IConfiguration configuration;
        public RegisteredUsersController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IActionResult RegisteredUsersList()
        {

            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            string allregUsersadminconnectionstring = string.Concat(adminconnectionstring, "fetchAllRegisteredUsers");
            RegisteredUsersVM vm = new RegisteredUsersVM
            {
                ConnectionstringallRegUsers = allregUsersadminconnectionstring
            };
            return View(vm);
        }
    }
}


