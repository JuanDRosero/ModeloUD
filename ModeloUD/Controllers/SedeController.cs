using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModeloUD.Controllers
{
    public class SedeController : Controller
    {
        private readonly ILogger<SedeController> _logger;

        public SedeController(ILogger<SedeController> logger)
        {
            this._logger = logger;
        }
        // GET: SedeController1
        public ActionResult Index()
        {
            return View();
        }

        [Route("Sede/Agregar")]
        // GET: SedeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SedeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [Route("Sede/Editar")]
        // GET: SedeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SedeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SedeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SedeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
