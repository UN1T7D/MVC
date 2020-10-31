using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejemploMVC.Models;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class LongitudController : Controller
    {
        // GET: Resta
        public ActionResult Longitud()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Longitud(Longitud obLongitud)
        {
            double resultado = obLongitud.Dato / 39.370;
            double Pulgadas = obLongitud.Dato * 39.370;
            ViewBag.resultado = resultado;
            ViewBag.Pulgadas = Pulgadas;
            return View(obLongitud);
        }

    }
}