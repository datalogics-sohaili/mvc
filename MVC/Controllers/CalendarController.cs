using System;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest() || (!string.IsNullOrEmpty(Request.Params["ajax"]) && Convert.ToBoolean(Request.Params["ajax"])))
                return PartialView();
            else
                return View();
        }
    }
}