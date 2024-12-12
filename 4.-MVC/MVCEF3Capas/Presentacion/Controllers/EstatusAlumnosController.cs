using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class EstatusAlumnosController : Controller
    {

        NEstatusAlumnos objCRUD = new NEstatusAlumnos();  
        // GET: EstatusAlumnos
        public ActionResult Index()
        {
            return View(objCRUD.WAPINConsultar());
        }

        // GET: EstatusAlumnos/Details/5
        public ActionResult Details(int id)
        {
            return View(objCRUD.WAPINConsultar(id));
        }

        // GET: EstatusAlumnos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstatusAlumnos/Create
        [HttpPost]
        public ActionResult Create(EstatusAlumnos unEstatus)
        {
            try
            {
                // TODO: Add insert logic here

                unEstatus = objCRUD.WAPINAgregar(unEstatus);

                return View("Details", unEstatus);
            }
            catch
            {
                return View();
            }
        }

        // GET: EstatusAlumnos/Edit/5
        public ActionResult Edit(int id)
        {
            return View(objCRUD.WAPINConsultar(id));
        }

        // POST: EstatusAlumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EstatusAlumnos unEstatus)
        {
            try
            {
                // TODO: Add update logic here
                objCRUD.WAPINActualizar(unEstatus);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EstatusAlumnos/Delete/5
        public ActionResult Delete(int id)
        {
            return View(objCRUD.WAPINConsultar(id));
        }

        // POST: EstatusAlumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                objCRUD.WAPINEliminar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
