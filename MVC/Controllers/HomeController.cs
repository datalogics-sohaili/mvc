using System;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest() || (!string.IsNullOrEmpty(Request.Params["ajax"]) && Convert.ToBoolean(Request.Params["ajax"])))
                return PartialView();
            else
                return View();
        }
    }
}