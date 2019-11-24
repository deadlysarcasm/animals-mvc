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
    }
}