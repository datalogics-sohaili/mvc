using System.Web.Mvc;
using WebMarkupMin.Mvc.ActionFilters;

namespace MVC.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        [MinifyHtml]
        public ActionResult Index()
        {
            return View();
        }
    }
}