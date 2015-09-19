using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Threading;
using Newtonsoft.Json;

namespace GlobalizeValidation.Controllers
{
    public class CulturesController : Controller
    {
        [HttpGet]
        [OutputCache(Duration = 240, VaryByHeader = "Accept-Language", VaryByParam = "culture;id", Location = System.Web.UI.OutputCacheLocation.Server)]
        public ActionResult Cldr(string culture, string file)
        {
            if (string.IsNullOrEmpty(file))
            {
                return Json(new {}, JsonRequestBehavior.AllowGet);
            }

            file = file + ".json";

            string cultureRoot = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cultures");
            string cultureFolder = Path.Combine(cultureRoot, Thread.CurrentThread.CurrentCulture.Name);

            object json = null;
            string jsonFile = string.Empty;

            if (System.IO.File.Exists(Path.Combine(cultureRoot, file)))
            {
                jsonFile = Path.Combine(cultureRoot, file);
            }
            else if (System.IO.File.Exists(Path.Combine(cultureFolder, file)))
            {
                jsonFile = Path.Combine(cultureFolder, file);
            }

            if (!string.IsNullOrEmpty(jsonFile))
            {
                return Content(System.IO.File.ReadAllText(jsonFile), "application/json");
            }

            return Content("", "application/json");
        }
    }
}