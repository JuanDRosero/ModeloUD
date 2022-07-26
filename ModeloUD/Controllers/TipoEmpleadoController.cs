using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModeloUD.Interfaces;
using ModeloUD.Models;

namespace ModeloUD.Controllers
{
    public class TipoEmpleadoController : Controller
    {
        private readonly ILogger<SedeController> _logger;
        private readonly IRolService _rolService;
        public TipoEmpleadoController(ILogger<SedeController> logger, IRolService rolService)
        {
            this._logger = logger;
            this._rolService = rolService;
        }
        [Route("Rol/")]
        // GET: TipoEmpleadoController
        public ActionResult Index()
        {
            var lista = _rolService.GetRoles();
            return View(lista);
        }

        [Route("Rol/Agregar")]
        // GET: TipoEmpleadoController/Create
        public ActionResult Create()
        {
            return View();
        }
        [Route("Rol/Agregar")]
        // POST: TipoEmpleadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Rol rol)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _rolService.AddRol(rol);
            return RedirectToAction("Index");
        }
        [Route("Rol/Editar")]
        // GET: TipoEmpleadoController/Edit/5
        public ActionResult Edit(int id)
        {
            var rol = _rolService.GetRol(id);
            return View(rol);
        }
        [Route("Rol/Editar")]
        // POST: TipoEmpleadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Rol rol)
        {
            if (!ModelState.IsValid)
            {
                return View(rol);
            }
            var res = _rolService.UpdateRol(rol);
            return RedirectToAction("Index");
        }
        [Route("Rol/Eliminar")]
        // GET: TipoEmpleadoController/Delete/5
        public ActionResult Delete(int id)
        {
            var res = _rolService.DeleteRol(id);
            return RedirectToAction("Index");
        }

       
    }
}
