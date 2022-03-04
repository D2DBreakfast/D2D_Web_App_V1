using Microsoft.AspNetCore.Mvc;
using D2D.WebApp.ViewModel;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;

namespace D2D.WebApp.Controllers
{
    public class SubscriptionController : Controller
    {
        IConfiguration configuration;

        public SubscriptionController(IConfiguration configuration)
        {

            this.configuration = configuration;

        }
        public IActionResult ImageSave()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ImageSave(IFormFile files)
        {
            if (files != null)
            {
                if (files.Length > 0)
                {
                    //Getting FileName
                    var fileName = Path.GetFileName(files.FileName);

                    //Assigning Unique Filename (Guid)
                    //var FileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    //var newFileName = String.Concat(fileName, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
            new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images")).Root + $@"\{fileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        files.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }
            return View();
        }


        public IActionResult AddSubscriptionName()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            string createsubscriptiontypesadminconnectionstring = string.Concat(adminconnectionstring, "createSubscriptionTitle");
            AddSubscriptionVM vm = new AddSubscriptionVM
            {
                Connectionstringcreatesubscription = createsubscriptiontypesadminconnectionstring
            };
            return View(vm);
            
        }

        public IActionResult AddSubscription()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            string createsubscriptiontypesadminconnectionstring = string.Concat(adminconnectionstring, "createSubscriptionTitle");
            string fetchsubscriptiontypesadminconnectionstring = string.Concat(adminconnectionstring, "fetchSubscriptionTitle");
            string createsubscriptionmenuadminconnectionstring = string.Concat(adminconnectionstring, "createSubscriptionMeals");
            string fetchsubscriptiondetailsadminconnectionstring = string.Concat(adminconnectionstring, "fetchSubscriptionPlacedOrders");
            string editSubscriptionadminconnectionstring = string.Concat(adminconnectionstring, "editSubscription");
            string fetchSubscriptionMealsadminconnectionstring = string.Concat(adminconnectionstring, "fetchSubscriptionMeals");
            string deletesubScriptionadminconnectionstring = string.Concat(adminconnectionstring, "deleteSubscription");
            string editSubscriptionMenuadminconnectionstring = string.Concat(adminconnectionstring, "editSubscriptionMenu");

            AddSubscriptionVM vm = new AddSubscriptionVM
            {
                Connectionstringcreatesubscription = createsubscriptiontypesadminconnectionstring,
                Connectionstringfetchsubscriptiontype = fetchsubscriptiontypesadminconnectionstring,
                Connectionstringcreatesubscriptionmenu = createsubscriptionmenuadminconnectionstring,
                Connectionstringfetchsubscriptiondetails = fetchsubscriptiondetailsadminconnectionstring,
                ConnectionstringeditSubscription = editSubscriptionadminconnectionstring,
                Connectionstringfetchsubscriptionmeals = fetchSubscriptionMealsadminconnectionstring,
                Connectionstringdeletesubscription= deletesubScriptionadminconnectionstring,
                ConnectionstringeditsubscriptionMenu = editSubscriptionMenuadminconnectionstring

            };
            return View(vm);
        }

        public IActionResult SubscriptionList()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
           
            string fetchsubscriptiondetailsadminconnectionstring = string.Concat(adminconnectionstring, "fetchSubscriptionList");
            AddSubscriptionVM vm = new AddSubscriptionVM
            {
                Connectionstringfetchsubscriptiondetails = fetchsubscriptiondetailsadminconnectionstring
            };
            return View(vm);
        }
        

    }
}
