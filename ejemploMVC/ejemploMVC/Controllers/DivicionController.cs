using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejemploMVC.Models;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class DivicionController : Controller
    {
        // GET: Resta
        public ActionResult OpercionDivicion()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OpercionDivicion(Divicion obDivicion)
        {
            int resultado = obDivicion.numer1 / obDivicion.numer2;
            ViewBag.resultado = resultado;
            return View(obDivicion);
        }
    }
}