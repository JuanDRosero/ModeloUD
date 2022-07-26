using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModeloUD.Interfaces;
using ModeloUD.Models;

namespace ModeloUD.Controllers
{
    public class SedeController : Controller
    {
        private readonly ILogger<SedeController> _logger;
        private readonly ISedeService _sedeService;

        public SedeController(ILogger<SedeController> logger, ISedeService sedeService)
        {
            this._logger = logger;
            this._sedeService = sedeService;
        }
        // GET: SedeController1
        public ActionResult Index()
        {
            var lista=_sedeService.GetSedes();
            return View(lista);
        }

        [Route("Sede/Agregar")]
        // GET: SedeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        [Route("Sede/Agregar")]
        // POST: SedeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sede sede)
        {
            if(!ModelState.IsValid)
            {
                return View(sede);
            }
            _sedeService.AddSede(sede);
            return RedirectToAction("Index");
        }
        [Route("Sede/Editar")]
        // GET: SedeController1/Edit/5
        public ActionResult Edit(int id)
        {
            var sede = _sedeService.GetSede(id);
            return View(sede);
        }

        [Route("Sede/Editar")]
        // POST: SedeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Sede sede)
        {
            if (!ModelState.IsValid)
            {
                return View(sede);
            }
            var res=_sedeService.UpdateSede(sede);
            return RedirectToAction("Index");

        }

        // GET: SedeController1/Delete/5
        public ActionResult Delete(int id)
        {
            var res = _sedeService.DeleteSede(id);
            return RedirectToAction("Index");
        }

       
    }
}
