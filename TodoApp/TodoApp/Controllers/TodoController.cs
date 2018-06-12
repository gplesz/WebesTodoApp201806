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
                //ez nem jó, mert ha törlök a listából akkor 
                //onnantól ez duplázni fogja a számokat
                //var maxId = MyDb.Lista.Count;

                var maxId = MyDb.Lista.Max(x => x.Id);
                MyDb.Lista.Add(new TodoItem() { Id = maxId + 1,  Name = name, Done = isDone });

                return RedirectToAction("Index");
            }


            //todo: mivel az adat nem valid, itt kéne a hibaüzenettel valamit kezdeni (kiadni az ügyfél felé)

            return View();
        }

        /// <summary>
        /// Az action feladata az adott elem megjelenítése módosításra.
        /// </summary>
        /// <param name="id">a módosítandó tétel egyedi azonosítója</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //elő kell keresni az adott elemt

            //ez lesz egy olyan LISTA, amin csak a feltételnek megfelelő elemek vannak
            //MyDb.Lista.Where(x=>x.Id==id); 

            //ha tudom, hogy pontosan egy elemet keresek, akkor ezt így tudom elkérni a listától
            //ezt akkor tudom használni, ha garantálni tudom, hogy ez igaz.
            //ha véletlenül mégsem igaz (több elem is teljesíti a feltételt, vagy egy sem)
            //akkor a kérés hibával elszáll
            var item = MyDb.Lista.Single(x => x.Id == id);

            //ha nem tudom garantálni, akkor
            //ha van ilyen elem, akkor ezt adja vissza
            //ha nincs ilyen elem, akkor null-lal tér vissza.
            //var item = MyDb.Lista.SingleOrDefault(x => x.Id == id);

            //Ezt az elemet kell módosítanunk.

            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(int id, string name, bool done)
        {
            //elem kikeresése
            var item = MyDb.Lista.Single(x => x.Id == id);
            //módosítás
            item.Name = name;
            item.Done = done;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var item = MyDb.Lista.Single(x => x.Id == id);
            return View(item);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var item = MyDb.Lista.Single(x => x.Id == id);
            MyDb.Lista.Remove(item);
            return RedirectToAction("Index");
        }
    }
}