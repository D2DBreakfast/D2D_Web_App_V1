using D2D.WebApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D2D.WebApp.Controllers
{
    public class OrderController : Controller
    {
        IConfiguration configuration;
        public OrderController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IActionResult FetchOrderDetails()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            string dayorderlistadminconnectionstring = string.Concat(adminconnectionstring, "fetchAllACartReceivedOrders");
            OrderListVM vm = new OrderListVM();

            vm.Connectionstringdayorderhistory = dayorderlistadminconnectionstring;
            return View(vm);
        }

        public IActionResult CancelledOrders()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            string adminconnectionstringfetchAllCancelledOrders = string.Concat(adminconnectionstring, "fetchAllCancelledOrders");
            OrderListVM vm = new OrderListVM();

            vm.ConnectionstringcancelledOrders= adminconnectionstringfetchAllCancelledOrders;
            return View(vm);
        }
    }
}

