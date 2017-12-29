using System.Web.Mvc;

namespace Newage3D.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Images()
        {
            ViewBag.Message = "Your images page.";

            return View();
        }
        public ActionResult SpriteSpin()
        {
            ViewBag.Message = "Your images page.";

            return View();
        }
    }
}