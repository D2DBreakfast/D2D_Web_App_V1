using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D2D.WebApp.Controllers
{
    public class AddonsController : Controller
    {
        public IActionResult Addons()
        {
            return View();
        }
    }
}
