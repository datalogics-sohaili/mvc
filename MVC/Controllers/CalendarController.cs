using System;
using System.Web.Mvc;
using WebMarkupMin.Mvc.ActionFilters;

namespace MVC.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        [MinifyHtml]
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest() || (!string.IsNullOrEmpty(Request.Params["ajax"]) && Convert.ToBoolean(Request.Params["ajax"])))
                return PartialView();
            else
                return View();
        }
    }
}