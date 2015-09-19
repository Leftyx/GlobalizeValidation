using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalizeValidation.Controllers
{
    using GlobalizeValidation.Infrastructure;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Models.PersonViewModel() { Name = "Anonymous", Deposit = 50 };
            return View(model);
        }

        [HttpPost]
        public JsonResult Index(Models.PersonViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { result = false, message = ModelState.Errors() }, JsonRequestBehavior.DenyGet);
            }

            return Json(new { result = true, message = "", data = new { name = model.Name, deposit = model.Deposit } }, JsonRequestBehavior.DenyGet);

        }
    }
}