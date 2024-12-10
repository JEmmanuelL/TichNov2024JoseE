using BusinessLogic;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Microsoft.Ajax.Utilities;
using MVC_Razor_ADO.Models;
using System.EnterpriseServices;
using Datos;

namespace MVC_Razor_ADO.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            NAlumno objCRUD = new NAlumno();

            List<Alumno> Alumns = objCRUD.NConsultar();

            NEstado objCRUDestado = new NEstado();
            NEstatusAlumno objCRUDEstatus = new NEstatusAlumno();

            List<Estado> ListEstad = objCRUDestado.NConsultar();
            List<EstatusAlumno> ListEstatu = objCRUDEstatus.NConsultar();


            var ListaAluF5 =
                  (from Alumno in Alumns
                   join Estado in ListEstad on Alumno.idEstadoOrigen equals Estado.id
                   join Estatus in ListEstatu on Alumno.idEstatus equals Estatus.id
                   orderby Alumno.id ascending
                   select new { id = Alumno.id, nombre = Alumno.nombre, primerApellido = Alumno.primerApellido, segundoApellido = Alumno.segundoApellido, correo = Alumno.correo, telefono = Alumno.telefono, idEstadoOrigen = Estado.nombre, idEstatus = Estatus.nombre }).ToList();


            //ViewBag.Alumnos = ListaAluF5;

            var ObjJSON = JsonConvert.SerializeObject(ListaAluF5);

            List<AlumnoIn> IndexAlumnos = JsonConvert.DeserializeObject<List<AlumnoIn>>(ObjJSON);

            return View(IndexAlumnos);
        }

        public ActionResult Details(int idAlumno)
        {
            NAlumno objCRUD = new NAlumno();

            Alumno UnAlumno = objCRUD.NConsultar(idAlumno);
            NEstado objCRUDestado = new NEstado();
            NEstatusAlumno objCRUDEstatus = new NEstatusAlumno();

            ViewBag.idEstadoOrigen = objCRUDestado.NConsultar(UnAlumno.idEstadoOrigen).nombre;
            ViewBag.idEstatus = objCRUDEstatus.NConsultar(UnAlumno.idEstatus).nombre;

            //ViewBag.FechaNaci = UnAlumno.fechaNacimiento.ToString("yyyy-MM-dd");


            return View(UnAlumno);
        }
        public ActionResult Delete(int idAlumno)
        {
            NAlumno objCRUD = new NAlumno();

            Alumno UnAlumno = objCRUD.NConsultar(idAlumno);

            NEstado objCRUDestado = new NEstado();
            NEstatusAlumno objCRUDEstatus = new NEstatusAlumno();

            ViewBag.idEstadoOrigen = objCRUDestado.NConsultar(UnAlumno.idEstadoOrigen).nombre;
            ViewBag.idEstatus = objCRUDEstatus.NConsultar(UnAlumno.idEstatus).nombre;
            return View(UnAlumno);
        }
        [HttpPost]
        public ActionResult Delete(int idAlumno,Alumno alumno)
        {
            NAlumno objCRUD = new NAlumno();

            if (objCRUD.NEliminar(idAlumno) >= 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Create()
        {
            NEstado objCRUDestado = new NEstado();
            NEstatusAlumno objCRUDEstatus = new NEstatusAlumno();

            ViewBag.idEstado = new SelectList(objCRUDestado.NConsultar(), "id", "nombre");
            ViewData["Estatus"] = objCRUDEstatus.NConsultar();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            NAlumno objCRUD = new NAlumno();

            if (objCRUD.NAgregar(alumno) >= 1)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int idAlumno)
        {
            NAlumno objCRUD = new NAlumno();

            Alumno UnAlumno = objCRUD.NConsultar(idAlumno);

            NEstado objCRUDestado = new NEstado();
            NEstatusAlumno objCRUDEstatus = new NEstatusAlumno();

            ViewBag.idEstado = new SelectList(objCRUDestado.NConsultar(), "id", "nombre",UnAlumno.idEstadoOrigen);
            ViewData["Estatus"] = objCRUDEstatus.NConsultar();


            return View(UnAlumno);
        }

        [HttpPost]
        public ActionResult Edit(int idAlumno,Alumno alumno)
        {
            NAlumno objCRUD = new NAlumno();

            if (objCRUD.NActualizar(alumno) >= 1)
            {
                return RedirectToAction("Index");
            }
            else
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