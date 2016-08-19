using System.Web.Mvc;
using WebMarkupMin.Mvc.ActionFilters;

namespace MVC.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [MinifyHtml]
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            else
                return View();
        }

        // GET: Contact/Showing
        [MinifyHtml]
        public ActionResult Showing()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            else
                return View();
        }
    }
}