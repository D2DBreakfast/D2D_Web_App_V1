using D2D.WebApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
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
    public class FoodMenuController : Controller
    {

        IConfiguration configuration;

        public FoodMenuController(IConfiguration configuration)
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



        public IActionResult AddMainCategory()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            adminconnectionstring = string.Concat(adminconnectionstring, "addMainCategory");
            FoodMenuVM vm = new FoodMenuVM
            {
                Connectionstringaddmanincategory = adminconnectionstring
            };
            return View(vm);
        }

        public IActionResult AddSubCategory()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            string fetchmaincategoryconnectionstring = string.Concat(adminconnectionstring, "fetchMainCategory"); // verify the name once
            string addsubcategoryconnectionstring = string.Concat(adminconnectionstring, "addSubCategory");
            string fetchallsubcatlistconnectionstring = string.Concat(adminconnectionstring, "fetchCategoryList");
            string deleteSubCategoryconnectionstring = string.Concat(adminconnectionstring, "deleteSubCategory");
            FoodMenuVM vm = new FoodMenuVM
            {
                Connectionstringfetchmaincategory = fetchmaincategoryconnectionstring,
                Connectionstringaddsubcategory = addsubcategoryconnectionstring,
                Connectionstringfetchallsubcatlist = fetchallsubcatlistconnectionstring,
                ConnectionstringdeleteSubCategory = deleteSubCategoryconnectionstring
            };
            return View(vm);
        }


        //public IActionResult AddNewMenu()
        //{
        //    string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
        //    string fetchmaincategoryconnectionstring = string.Concat(adminconnectionstring, "fetchMainCategory");
        //    string fetchSubCategoryconnectionstring = string.Concat(adminconnectionstring, "fetchSubCategory");
        //    //string mainadminconnectionstring = string.Concat(adminconnectionstring, "addMenu");
        //    //string addonadminconnectionstring = string.Concat(adminconnectionstring, "getAddOnItemDetails");
        //    FoodMenuVM vm = new FoodMenuVM
        //    {
        //        Connectionstringfetchmaincategory = fetchmaincategoryconnectionstring,
        //        ConnectionstringfetchSubCategory = fetchSubCategoryconnectionstring,
        //        //Connectionstringthree = mainadminconnectionstring,
        //        //Connectionstringaddon = addonadminconnectionstring
        //    };
        //    return View(vm);
        //}

        public IActionResult MenuList()
        {
            string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("restaurantManager").Value;
            string fetchmaincategoryconnectionstring = string.Concat(adminconnectionstring, "fetchMainCategory");
            string fetchSubCategoryconnectionstring = string.Concat(adminconnectionstring, "fetchSubCategory");
            string addmenuconnectionstring = string.Concat(adminconnectionstring, "addMenu");
            string editmenudetailsconnectionstring = string.Concat(adminconnectionstring, "editMenu");
            string fetchMenudashboardconnectionstring = string.Concat(adminconnectionstring, "fetchMenuList");
            string getAddOnNamesconnectionstring = string.Concat(adminconnectionstring, "fetchAddOnTitle");
            string deleteMenuNamesconnectionstring = string.Concat(adminconnectionstring, "deleteMenu");
            FoodMenuVM vm = new FoodMenuVM
            {
                Connectionstringfetchmaincategory = fetchmaincategoryconnectionstring,
                ConnectionstringfetchSubCategory = fetchSubCategoryconnectionstring,
                Connectionstringaddmenu = addmenuconnectionstring,
                Connectionstringeditmenudetails = editmenudetailsconnectionstring,
                ConnectionstringfetchMenudashboard = fetchMenudashboardconnectionstring,
                ConnectionstringgetAddOnNames = getAddOnNamesconnectionstring,
                ConnectionstringdeleteMenuItem = deleteMenuNamesconnectionstring
            };
            return View(vm);

        }

        //public IActionResult EditMenuDetails()
        //{
        //    string adminconnectionstring = configuration.GetSection("BackendAPI").GetSection("manager").Value;
        //    string maincategoryconnectionstring = string.Concat(adminconnectionstring, "fetchMainCategory");
        //    string subcategoryconnectionstring = string.Concat(adminconnectionstring, "fetchSubCategory");
        //    string mainadminconnectionstring = string.Concat(adminconnectionstring, "fetchMenu");
        //    string addadminconnectionstring = string.Concat(adminconnectionstring, "editMenuDetails");
        //    FoodMenuVM vm = new FoodMenuVM
        //    {
        //        Connectionstring = maincategoryconnectionstring,
        //        Connectionstringtwo = subcategoryconnectionstring,
        //        Connectionstringthree = mainadminconnectionstring,
        //        Connectionstringfour = addadminconnectionstring
        //    };

        //    return View(vm);


        //}
    }
}
