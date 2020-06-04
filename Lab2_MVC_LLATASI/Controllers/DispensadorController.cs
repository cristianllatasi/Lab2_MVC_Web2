using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC_LLATASI.Models;
namespace Lab2_MVC_LLATASI.Controllers
{
    public class DispensadorController : Controller
    {
        // GET: Dispensador
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VisualizarDispensado(ClsDispensador objDispensado)
        {



            if (objDispensado.importe > 0)
            {
                objDispensado.b100 = objDispensado.importe / 100;
                objDispensado.b50 = objDispensado.importe % 100 / 50;
                objDispensado.b20 = objDispensado.importe % 100 % 50 / 20;
                objDispensado.b10 = objDispensado.importe % 100 % 50 % 20 / 10;

               



                objDispensado.cantidad = objDispensado.b100 + objDispensado.b50 + objDispensado.b20 + objDispensado.b10;
            }

            else
            {

                Response.Write("<script languaje=javascript>alert('Ingrese importe correcto');</script");
                return View("Index", objDispensado);

            }

            return View("VisualizarDispensado", objDispensado);


        }

    }
}