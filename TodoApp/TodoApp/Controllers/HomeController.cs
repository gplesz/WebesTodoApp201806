using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Models;

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
            var lista = new List<TodoItem>();

            lista.Add(new TodoItem() { Name = "Só", Done = true });
            lista.Add(new TodoItem() { Name = "Cukor", Done = true });
            lista.Add(new TodoItem() { Name = "Spagetti", Done = true });
            lista.Add(new TodoItem() { Name = "Marhahús", Done = false });
            lista.Add(new TodoItem() { Name = "Paradicsom", Done = false });

            return View(lista);
        }

    }
}