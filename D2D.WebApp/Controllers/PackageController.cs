using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using D2D.WebApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D2D.WebApp.Controllers
{
    public class PackageController : Controller
    {
        IConfiguration configuration;
        public PackageController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IActionResult Packing()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            string needtocookadminconnectionstringallprepareditems = string.Concat(adminconnectionstring, "fetchAllACartPreparedOrderList");
            string needtocookadminconnectionstringpackagestatus = string.Concat(adminconnectionstring, "allACartOrderStatusChangedPacked");
            string needtocookadminconnectionstringallpackeditems= string.Concat(adminconnectionstring, "fetchAllACartPackedItemOrderList");
            string needtocookadminconnectionstringsubscriptionprepareditems = string.Concat(adminconnectionstring, "fetchSubscriptonPreparedOrderList");
            string needtocookadminconnectionstringsubscriptionpackstatuschange = string.Concat(adminconnectionstring, "subscriptionPackedStatusChange");
            string adminconnectionstringfetchAllPackedOrders = string.Concat(adminconnectionstring, "fetchAllPackedOrders");

            PackageVM vm = new PackageVM();

            vm.Connectionstringallprepareditem = needtocookadminconnectionstringallprepareditems;
            vm.Connectionstringpackagestatus = needtocookadminconnectionstringpackagestatus;
            vm.Connectionstringallpackeditems = needtocookadminconnectionstringallpackeditems;
            vm.Connectionstringsubscriptionprepareditems = needtocookadminconnectionstringsubscriptionprepareditems;
            vm.Connectionstringsubscriptionpackagestatus = needtocookadminconnectionstringsubscriptionpackstatuschange;
            vm.Connectionstringfetchallpackedorders = adminconnectionstringfetchAllPackedOrders;
            return View(vm);
        }
    }
}
