using InputMaskValidationErrorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InputMaskValidationErrorDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DemoViewModel model = new DemoViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(DemoViewModel model)
        {
            // NOTE: ModelState will NOT be valid because the FROM field has a validation error
            if (ModelState.IsValid)
            {
                return RedirectToAction("Contact");
            }
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}