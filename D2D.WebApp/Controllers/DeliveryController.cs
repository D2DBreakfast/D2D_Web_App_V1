using D2D.WebApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D2D.WebApp.Controllers
{
    public class DeliveryController : Controller
    {
        IConfiguration configuration;
        public DeliveryController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IActionResult AddDeliveryBoy()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            string adddeliverydoyadminconnectionstring = string.Concat(adminconnectionstring, "addDeliveryBoy");
            string deliveryboyslistadminconnectionstring = string.Concat(adminconnectionstring, "fetchAllRegisteredDeliveryBoys");
            string editdeliveryboydetailsadminconnectionstring = string.Concat(adminconnectionstring, "editDeliveryBoyDetails");
            deliveryVM vm = new deliveryVM();

            vm.ConnectionstringaddDeliveryBoy = adddeliverydoyadminconnectionstring;
            vm.Connectionstringalldeliveryboyslist = deliveryboyslistadminconnectionstring;
            vm.Connectionstringaeditdeliveryboydetails = editdeliveryboydetailsadminconnectionstring;
            return View(vm);
           
        }

        public IActionResult AssignOrder()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            string adminconnectionstringgetalldeliveryboyslist = string.Concat(adminconnectionstring, "fetchAllRegisteredDeliveryBoys");
            string adminconnectionstringfetchallpackedorders = string.Concat(adminconnectionstring, "fetchAllPackedOrders");
            string adminconnectionstringassignordertodeliveryboy = string.Concat(adminconnectionstring, "assignOrdersToDeliveryBoy");
            deliveryVM vm = new deliveryVM();

            vm.Connectionstringdeliveryboyslist = adminconnectionstringgetalldeliveryboyslist;
            vm.Connectionstringfetchallpackedorders = adminconnectionstringfetchallpackedorders;
            vm.Connectionstringassigntodeliveryboy = adminconnectionstringassignordertodeliveryboy;
            return View(vm);
        }
        public IActionResult Delivery()
        {
            return View();
        }

        
    }


    
}
