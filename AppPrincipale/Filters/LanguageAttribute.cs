using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Filters;
using System.Web.Mvc;
using System.Threading;
using System.Globalization;

namespace AppPrincipale.Filters
{
    public class LanguageAttribute : ActionFilterAttribute
    {
        public string Language { get; set; }

        public LanguageAttribute(string language)
        {
            Language = language;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Language);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(  Language);
            base.OnActionExecuting(filterContext);
        }

    }
}