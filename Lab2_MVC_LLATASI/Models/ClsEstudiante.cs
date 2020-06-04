using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2_MVC_LLATASI.Models
{
    public class ClsEstudiante
    {
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int codigoestudiante { get; set; }

        public int carrera { get; set; }
    }
}