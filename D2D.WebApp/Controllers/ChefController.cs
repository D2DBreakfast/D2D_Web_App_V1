using D2D.WebApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D2D.WebApp.Controllers
{
    public class ChefController : Controller
    {
        IConfiguration configuration;
        public ChefController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IActionResult ChefOder()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            string needtocookadminconnectionstring = string.Concat(adminconnectionstring, "needToCook");
            string needtocooksubscriptionadminconnectionstring = string.Concat(adminconnectionstring, "needToCookSubscription");
            string itemStatusChangeadminconnectionstring = string.Concat(adminconnectionstring, "allACartItemStatusChangePrepared");
            string subscriptionitemsfoodstatuschangeadminconnectionstring = string.Concat(adminconnectionstring, "subscriptionPreparedStatusChange");
            string needToCookAddOnSelectionsadminconnectionstring = string.Concat(adminconnectionstring, "needToCookSelections");
            string needToCookAddOnListadminconnectionstring = string.Concat(adminconnectionstring, "needToCookAddOn");
            NeedtocookVM vm = new NeedtocookVM();

            vm.Connectionstringneedtocook = needtocookadminconnectionstring;
            vm.Connectionstringneedtocooksubscription = needtocooksubscriptionadminconnectionstring;
            vm.Connectionstringitemstatuschange = itemStatusChangeadminconnectionstring;
            vm.Connectionstringsubscriptionitemstatuschange = subscriptionitemsfoodstatuschangeadminconnectionstring;
            vm.Connectionstringneedtocookaddonselection = needToCookAddOnSelectionsadminconnectionstring;
            vm.ConnectionstringneedtocookAddOnlist = needToCookAddOnListadminconnectionstring;
            return View(vm);
        }

        public IActionResult AllPreparedItems()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            string allacartepreparedadminconnectionstring = string.Concat(adminconnectionstring, "fetchAllACartPreparedOrderList");
            string subscriptionpreparedadminconnectionstring = string.Concat(adminconnectionstring, "fetchSubscriptonPreparedOrderList");
            NeedtocookVM vm = new NeedtocookVM();

            vm.ConnectionstringfetchAllPreparedItems = allacartepreparedadminconnectionstring;
            vm.ConnectionstringfetchAllSubscriptionPreparedItems = subscriptionpreparedadminconnectionstring;

            return View(vm);
        }
    }
}
