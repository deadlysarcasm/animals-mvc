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
        
        // GET: Animals
        public ActionResult Index()
        {
            var model = StaticData.animals;
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = StaticData.animals[id - 1];
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            try
            {
                var model = StaticData.animals[id - 1];
                return View(model);
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = "Could not find Animal";
                return View("Error");
            }
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Animal animal)
        {
            ModelState.AddModelError("Name", "Text");
            if (ModelState.IsValid)
            {
                var current = StaticData.animals.FirstOrDefault(x => x.Id == animal.Id);
                if (current != null)
                {
                    current.Name = animal.Name;
                    current.Gender = animal.Gender;
                    current.Species = animal.Species;
                }
                return RedirectToAction("Details", new { id = animal.Id });
            }

            return View("Error");
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
                animal.Id = StaticData.animals.Max(x => x.Id) + 1;
                StaticData.animals.Add(animal);
                return RedirectToAction("Details", new { id = animal.Id });
            }

            return View();
        }
    }
}