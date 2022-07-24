﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModeloUD.Controllers
{
    public class TipoEmpleadoController : Controller
    {
        private readonly ILogger<SedeController> _logger;
        public TipoEmpleadoController(ILogger<SedeController> logger)
        {
            this._logger = logger;
        }
        [Route("Rol/")]
        // GET: TipoEmpleadoController
        public ActionResult Index()
        {
            return View();
        }

        [Route("Rol/Agregar")]
        // GET: TipoEmpleadoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEmpleadoController/Create
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
        [Route("Rol/Editar")]
        // GET: TipoEmpleadoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoEmpleadoController/Edit/5
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

        // GET: TipoEmpleadoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoEmpleadoController/Delete/5
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
