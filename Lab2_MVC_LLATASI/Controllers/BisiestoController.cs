using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC_LLATASI.Models;

namespace Lab2_MVC_LLATASI.Controllers
{
    public class BisiestoController : Controller
    {
        // GET: Bisiesto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarAños()
        {
            return View();
        }
        public ActionResult CalcularAños(ClsBisiesto objBisiesto)
        {

            return View(objBisiesto);
        }

    }
}