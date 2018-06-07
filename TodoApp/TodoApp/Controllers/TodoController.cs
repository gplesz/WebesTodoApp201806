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

        //[HttpGet, HttpPost]
        //[HttpGet]
        //[HttpPost]
        public ActionResult Index()
        {
            return View(MyDb.Lista);
        }

        [HttpGet] //a routing innentől csak a GET kérések esetén irányít ide
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost] //a routing innentől csak a POST kérések esetén irányít ide
        public ActionResult Create(string name, bool isDone)
        {
            if (!string.IsNullOrEmpty(name))
            {//ha van adat a paraméterben
                //adatok mentése és vissza az index-re
                MyDb.Lista.Add(new TodoItem() { Name = name, Done = isDone });

                return RedirectToAction("Index");
            }


            //todo: mivel az adat nem valid, itt kéne a hibaüzenettel valamit kezdeni (kiadni az ügyfél felé)

            return View();
        }
    }
}