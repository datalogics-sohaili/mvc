using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Index()
        {
            return View();
        }
    }
}