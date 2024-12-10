using MVC_Razor_EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Razor_EF.Controllers
{
    public class AlumnosController : Controller
    {
        InstitutoTichEntities _DBContext = new InstitutoTichEntities();
        private List<Alumnos> _lstAlumnos;
        private Alumnos _oAlumno;
        private EstatusAlumnos _oEstatusAlu;

        // GET: Alumnos
        public ActionResult Index()
        {
            _DBContext.Configuration.LazyLoadingEnabled = true;
            _lstAlumnos = _DBContext.Alumnos.ToList();

            return View(_lstAlumnos);
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int idAlumno)
        {
            _DBContext.Configuration.LazyLoadingEnabled = true;
            _oAlumno = _DBContext.Alumnos.Find(idAlumno);
            return View(_oAlumno);
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            List<Estados> ListEstado = _DBContext.Estados.ToList();
            List<EstatusAlumnos> ListEstatusAlu = _DBContext.EstatusAlumnos.ToList();


            ViewBag.idEstado = new SelectList(ListEstado, "id", "nombre");
            ViewBag.idEstatus = new SelectList(ListEstatusAlu, "id", "nombre");
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(Alumnos alumno)
        {
            try
            {
                _DBContext.Alumnos.Add(alumno);
                _DBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int idAlumno)
        {
            _DBContext.Configuration.LazyLoadingEnabled = true;
            _oAlumno = _DBContext.Alumnos.Find(idAlumno);

            List<Estados> ListEstado = _DBContext.Estados.ToList();
            List<EstatusAlumnos> ListEstatusAlu = _DBContext.EstatusAlumnos.ToList();


            ViewBag.idEstado = new SelectList(ListEstado, "id", "nombre", _oAlumno.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(ListEstatusAlu, "id", "nombre", _oAlumno.idEstatus);


            return View(_oAlumno);
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int idAlumno,Alumnos alumno)
        {
            try
            {
                // TODO: Add update logic here
                alumno.id = idAlumno;
                _DBContext.Entry(alumno).State = EntityState.Modified;
                _DBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int idAlumno)
        {
            _DBContext.Configuration.LazyLoadingEnabled = true;

            _oAlumno = _DBContext.Alumnos.Find(idAlumno);

            return View(_oAlumno);
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int idAlumno, Alumnos alumno)
        {
            try
            {
                // TODO: Add delete logic here
                _oAlumno = _DBContext.Alumnos.Find(idAlumno);

                _DBContext.Alumnos.Remove(_oAlumno);
                _DBContext.SaveChanges();
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
