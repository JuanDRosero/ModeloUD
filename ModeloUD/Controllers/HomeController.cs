using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModeloUD.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }

    }
}
