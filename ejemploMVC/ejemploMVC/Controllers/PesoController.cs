using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejemploMVC.Models;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class PesoController : Controller
    {
        // GET: Resta
        public ActionResult Peso()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Peso(Peso obPeso)
        {
            double resultado = obPeso.dato1 / 2.2046;
            double libra = obPeso.dato1 * 2.2046;
            ViewBag.resultado = resultado;
            ViewBag.libra = libra;
            return View(obPeso);
        }

    }
}