using HolaMundoEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolaMundoEF.Controllers
{
    public class CursoController : Controller
    {
        InstitutoTichEntities _DBContext = new InstitutoTichEntities();

        // GET: Curso
        public ActionResult Index()
        {
            List<Cursos> ListaCursos= _DBContext.Cursos.ToList();
            return View(ListaCursos);
        }

        // GET: Curso/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Curso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Curso/Create
        [HttpPost]
        public ActionResult Create(Cursos curso)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Curso/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Curso/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cursos curso)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Curso/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Curso/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
