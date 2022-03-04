using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D2D.WebApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Statistics()
        {
            return View();
        }
    }
}
