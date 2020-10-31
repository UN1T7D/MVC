using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejemploMVC.Models;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class MultiplicacionController : Controller
    {
        // GET: Multiplicacion
        public ActionResult OperacionMulti()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OperacionMulti(Multiplicacion obMultiplicacion)
        {
            int resultado = obMultiplicacion.Numero1 * obMultiplicacion.Numero2;
            ViewBag.resultado = resultado;
            return View(obMultiplicacion);
        }
    }
}