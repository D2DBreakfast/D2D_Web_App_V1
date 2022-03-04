using D2D.WebApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D2D.WebApp.Controllers
{
    public class AddOnController : Controller
    {

        IConfiguration configuration;

        public AddOnController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        //public IActionResult AddOn()
        //{
        //    string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
        //    string createaddonnameadminconnectionstring = string.Concat(adminconnectionstring, "createAddOnTitle");
        //    AddOnsVM vm = new AddOnsVM
        //    {
        //        Connectionstringcreateaddonname = createaddonnameadminconnectionstring
        //    };
        //    return View(vm);
        //}

        //public IActionResult AddAddOn()
        //{
        //    string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
        //    string addonnamesadminconnectionstring = string.Concat(adminconnectionstring, "getAddOnNames");
        //    string createaddonitemsadminconnectionstring = string.Concat(adminconnectionstring, "createAddOnItems");
        //    AddOnsVM vm = new AddOnsVM
        //    {
        //        Connectionstringgetaddonnames = addonnamesadminconnectionstring,
        //        ConnectionstringcreateAddOnItems = createaddonitemsadminconnectionstring
        //    };
        //    return View(vm);
        //}

        public IActionResult AddOnList()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            string createaddonnameadminconnectionstring = string.Concat(adminconnectionstring, "createAddOnTitle");
            string addonnamesadminconnectionstring = string.Concat(adminconnectionstring, "fetchAddOnTitle");
            string createaddonitemsadminconnectionstring = string.Concat(adminconnectionstring, "createAddOn");
            string alladdonitemsadminconnectionstring = string.Concat(adminconnectionstring, "fetchAddOnList");
            string editaddonitemadminconnectionstring = string.Concat(adminconnectionstring, "editAddOn");
            string deleteaddonitemadminconnectionstring = string.Concat(adminconnectionstring, "deleteAddOn");
            AddOnsVM vm = new AddOnsVM
            {
                Connectionstringcreateaddonname = createaddonnameadminconnectionstring,
                Connectionstringgetaddonnames = addonnamesadminconnectionstring,
                ConnectionstringcreateAddOnItems = createaddonitemsadminconnectionstring,
                Connectionstringalladdonitems = alladdonitemsadminconnectionstring,
                Connectionstringeditaddonitem = editaddonitemadminconnectionstring,
                Connectionstringdeleteaddonitem = deleteaddonitemadminconnectionstring,
            };
            return View(vm);
        }

    }




}
         

