using Conversiones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conversiones.Controllers
{
    public class ConversionesController : Controller
    {
        Convertir con = new Convertir();
        // GET: Conversiones
        public ActionResult Index()
        {
           

            return View();
        }
        [HttpPost]
        public ActionResult Index(string unidadingresada,string unidadesperada,double cantidad)
        {
            ViewBag.res = con.resultado(unidadingresada,unidadesperada,cantidad);

            return View();
        }
    }
}