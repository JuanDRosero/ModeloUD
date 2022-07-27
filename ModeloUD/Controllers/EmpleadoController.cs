using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ModeloUD.Interfaces;
using ModeloUD.Models;

namespace ModeloUD.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly IEmpleadoService _empleadoService;
        private readonly ISedeService _sedeService;
        private readonly IRolService _rolService;
        public EmpleadoController(IEmpleadoService empleadoService, ISedeService sedeService, IRolService rolService)
        {
            this._empleadoService = empleadoService;
            this._sedeService = sedeService;
            this._rolService = rolService;
        }

        // GET: EmpleadoController
        public ActionResult Index()
        {
            EmpleadosViewModel model = new EmpleadosViewModel();
            model.Empleados= _empleadoService.GetEmpleados(); //Retorna todos los empleados
            model.listaSedes = _sedeService.GetSedes();
            model.listaRoles = _rolService.GetRoles();
            return View(model);
        }

        // GET: EmpleadoController/Create
        [Route("Empleado/Agregar")]
        public ActionResult Create()
        {
            EmpleadoViewModel model = new EmpleadoViewModel();
            model.listaSedes = getListaSedes();
            model.listaRoles = getListaRoles();

            return View(model);
        }

        [Route("Empleado/Agregar")]
        // POST: EmpleadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpleadoViewModel models )
        {
            if (!ModelState.IsValid)
            {
                models.listaSedes = getListaSedes();
                models.listaRoles = getListaRoles();
                return View(models);
            }
             _empleadoService.AddEmpleado(models.emp);
            return RedirectToAction("Index");

        }
        [Route("Empleado/Editar/{id?}")]
        // GET: EmpleadoController/Edit/5
        public ActionResult Edit(int id)
        {
            EmpleadoViewModel model = new EmpleadoViewModel();
            model.emp = _empleadoService.GetEmpleado(id);
            model.listaSedes = getListaSedes();
            model.listaRoles = getListaRoles();
            return View(model);
        }
        [Route("Empleado/Editar/{id?}")]
        // POST: EmpleadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpleadoViewModel empleado)
        {
            if (!ModelState.IsValid)
            {
                return View(empleado);
            }
            var Resultado = _empleadoService.UpdateEmpleado(empleado.emp);
            return RedirectToAction("Index");

        }

        // GET: EmpleadoController/Delete/5
        public ActionResult Delete(int id)
        {
            var resultado= _empleadoService.DeleteEmpleado(id);
            return RedirectToAction("Index");
        }

        private List<SelectListItem> getListaSedes()
        {
            var l = new List<SelectListItem>();
            foreach (var item in _sedeService.GetSedes())
            {
                l.Add(new SelectListItem { Value = item.Id, Text = item.Nombre });
            }
           
            return l;
        }

        private List<SelectListItem> getListaRoles()
        {
            var l = new List<SelectListItem>();
            foreach (var item in _rolService.GetRoles())
            {
                l.Add(new SelectListItem { Value = item.Id, Text = item.Descripcion });
            }
            return l;
        }
    }
}
