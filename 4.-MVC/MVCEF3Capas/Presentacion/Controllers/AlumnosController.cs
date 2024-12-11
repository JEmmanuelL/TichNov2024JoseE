using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class AlumnosController : Controller
    {
        private NAlumno objCRUDAlu = new NAlumno();
        private NEstado objCRUDEstado = new NEstado();
        private NEstatus objCRUDEstatus = new NEstatus();

        // GET: Alumnos
        public ActionResult Index()
        {
            return View(objCRUDAlu.NConsultar());
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int idAlumno)
        {
            return View(objCRUDAlu.NConsultar(idAlumno));
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            ViewBag.idEstado = new SelectList(objCRUDEstado.NConsultar(), "id", "nombre");
            ViewBag.idEstatus = new SelectList(objCRUDEstatus.NConsultar(), "id", "nombre");
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(Alumnos alumno)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add insert logic here
                    objCRUDAlu.NAgregar(alumno);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                ViewBag.idEstado = new SelectList(objCRUDEstado.NConsultar(), "id", "nombre");
                ViewBag.idEstatus = new SelectList(objCRUDEstatus.NConsultar(), "id", "nombre");
                return View(alumno);
            }
  

        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int idAlumno)
        {
            Alumnos unAlumno = objCRUDAlu.NConsultar(idAlumno);
            ViewBag.idEstado = new SelectList(objCRUDEstado.NConsultar(), "id", "nombre", unAlumno.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(objCRUDEstatus.NConsultar(), "id", "nombre", unAlumno.idEstatus);
            return View(unAlumno);
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int idAlumno, Alumnos unAlumno)
        {
           
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add update logic here
                    objCRUDAlu.NActualizar(unAlumno);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                ViewBag.idEstado = new SelectList(objCRUDEstado.NConsultar(), "id", "nombre");
                ViewBag.idEstatus = new SelectList(objCRUDEstatus.NConsultar(), "id", "nombre");
                return View(unAlumno);
            }

        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int idAlumno)
        {
            return View(objCRUDAlu.NConsultar(idAlumno));
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int idAlumno, Alumnos alumno)
        {
            try
            {
                // TODO: Add delete logic here
                objCRUDAlu.NEliminar(idAlumno);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Regresar()
        {
            return RedirectToAction("Index");
        }
    }
}
