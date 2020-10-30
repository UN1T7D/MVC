using ejemploMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }
        //POST: Prueba/Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Calculo obCalculo)
        {
            //Suma
            int resultado = obCalculo.numero1 + obCalculo.numero2;
            ViewBag.resultado = resultado;
            return View(obCalculo);
        }
    }
}