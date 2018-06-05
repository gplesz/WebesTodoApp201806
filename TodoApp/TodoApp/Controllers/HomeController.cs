using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TodoApp.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TodoList()
        {
            //bevásárló lista adatai:
            var lista = new List<string>();

            lista.Add("Só");
            lista.Add("Cukor");
            lista.Add("Spagetti");
            lista.Add("Marhahús");
            lista.Add("Paradicsom");

            //a ViewBag-be tett adatokat a nézeten ki tudjuk olvasni
            //figyelem: az erősen típusos védelmet itt elveszítjük.
            ViewBag.Lista = lista;

            return View();
        }

    }
}