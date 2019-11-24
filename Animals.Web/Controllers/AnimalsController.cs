using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animals.Web.Data;
using Animals.Web.Models;

namespace Animals.Web.Controllers
{
    public class AnimalsController : Controller
    {
        private InMemoryData data;

        public AnimalsController()
        {
            data = new InMemoryData();
        }
        // GET: Animals
        public ActionResult Index()
        {
            var model = data.GetAll();
            return View(model);
        }

        public ActionResult Details(int Id)
        {
            var model = data.Get(Id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var model = data.Get(Id);
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Animal animal)
        {
            if (ModelState.IsValid)
            {
                data.Update(animal);
                return RedirectToAction("Details", new { id = animal.Id });
            }

            return View(animal);
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Animal animal)
        {
            if(ModelState.IsValid)
            {
                data.Add(animal);
                return RedirectToAction("Details", new { id = animal.Id });
            }

            return View();
        }
    }
}