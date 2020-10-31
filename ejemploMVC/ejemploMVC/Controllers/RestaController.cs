using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejemploMVC.Models;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class RestaController : Controller
    {
        // GET: Resta
        public ActionResult OperacionResta()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OperacionResta(Resta obResta)
        {
            int resultado = obResta.num1 - obResta.num2;
            ViewBag.resultado = resultado;
            return View(obResta);
        }
    }
}