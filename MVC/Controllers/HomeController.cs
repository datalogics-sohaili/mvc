using System.Web.Mvc;
using WebMarkupMin.Mvc.ActionFilters;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [MinifyHtml]
        public ActionResult Index()
        {
            return View();
        }
    }
}