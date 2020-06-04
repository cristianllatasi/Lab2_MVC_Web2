using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC_LLATASI.Models;

namespace Lab2_MVC_LLATASI.Controllers
{
    
    public class PersonaController : Controller
    {
        ClsPersona objPersona = new ClsPersona();
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VisualizarDatos()
        {
            objPersona.apellido = "Llatasi";
            objPersona.nombre = "Cristian";
            objPersona.email = "cristianllatasi@gmail.com";
            objPersona.sexo = true;
            objPersona.edad = 23;
            objPersona.talla = 1.85;

            return View("VisualizarDatos", objPersona);
        }

        public ActionResult VisualizarPersonas()
        {

            List<ClsPersona> ListaPersona = new List<ClsPersona>();


            ClsPersona objPersona1 = new ClsPersona();

            objPersona1.apellido = "Alvarez";
            objPersona1.nombre = "Carlos";
            objPersona1.email = "cristianllatasi@gmail.com";
            objPersona1.sexo = true;
            objPersona1.edad = 21;
            objPersona1.talla = 1.85;
            ListaPersona.Add(objPersona1);


            ClsPersona objPersona2 = new ClsPersona();
            objPersona2.apellido = "Alcantara";
            objPersona2.nombre = "Ruben";
            objPersona2.email = "ruben@gmail.com";
            objPersona2.sexo = false;
            objPersona2.edad = 11;
            objPersona2.talla = 1.50;
            ListaPersona.Add(objPersona2);

            return View("VisualizarPersonas", ListaPersona);
        }

        }
}