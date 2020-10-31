using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejemploMVC.Models;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class NotasController : Controller
    {
        // GET: Notas
        public ActionResult Notas()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Notas(Notas obNota)
        {
            double resultado = (obNota.Nota1 + obNota.Nota2 + obNota.Nota3)/3;
            if (resultado == 10)
            {
                ViewBag.resultado = resultado + " Felicidades";
            }
            else
                 if (resultado > 10)
            {
                ViewBag.resultado = "INGRESE SUS NOTAS CORRECTAMENTE";
            }
            else
                if (resultado >= 7 && resultado < 10)
            {
                ViewBag.resultado = resultado + " Aprobado";
            }
            else
            {
                ViewBag.resultado = resultado + " visite al tutor";
            }
            return View(obNota);
        }
    }
}