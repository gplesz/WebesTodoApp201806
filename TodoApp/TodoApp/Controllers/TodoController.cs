using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {

        public ActionResult Index()
        {
            return View(MyDb.Lista);
        }

        public ActionResult Create(string Name)
        {
            if (!string.IsNullOrEmpty(Name))
            {//ha van adat a paraméterben
                //adatok mentése és vissza az index-re
                MyDb.Lista.Add(new TodoItem() { Name = Name, Done = true });

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}