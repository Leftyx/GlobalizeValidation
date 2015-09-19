using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.IO;

namespace GlobalizeValidation.Infrastructure
{
    public class LanguageFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var layoutViewModel = filterContext.Controller.ViewData.Model as ViewModels._LayoutViewModel;
            if (layoutViewModel != null)
            {
                layoutViewModel.Culture = Thread.CurrentThread.CurrentCulture.Name; ;
                layoutViewModel.NeutralCulture = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            }
        }
    }
}