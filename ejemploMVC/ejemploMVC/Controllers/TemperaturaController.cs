using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejemploMVC.Models;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class TemperaturaController : Controller
    {
        // GET: Resta
        public ActionResult Temperatura()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Temperatura(Temperatura obTemperatura)
        {
            double resultado = obTemperatura.dato - 273.15;
            double kelvin = obTemperatura.dato + 273.15;
            ViewBag.resultado = resultado;
            ViewBag.kelvin = kelvin;
            return View(obTemperatura);
        }

    }
}