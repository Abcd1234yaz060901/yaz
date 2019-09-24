using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contacto()
        {
            string pais = "Republica Dominicana";
            string Direccion = "Dr. Luis J Suares #52, La Romana.";

            ViewBag.Pais = pais;
            ViewBag.Direccion = Direccion;

            return View();
        }
    }
}