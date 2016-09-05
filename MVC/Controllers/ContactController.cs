using System;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest() || (!string.IsNullOrEmpty(Request.Params["ajax"]) && Convert.ToBoolean(Request.Params["ajax"])))
                return PartialView();
            else
                return View();
        }
    }
}