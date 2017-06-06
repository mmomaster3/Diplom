using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using homeless_pets.Models;

namespace homeless_pets.Controllers
{
    public class CatalogController : Controller
    {
        public int pagesize = 4;

        // GET: Catalog
        public ActionResult List(int page = 1)
        {
            PetsContext pets = new PetsContext();   
            return View(pets.Pets);
        }

        public ActionResult Card(int? id)
        {
            ViewBag.Variable = id;
            PetsContext pets = new PetsContext();
            return View(pets.Pets);
        }
    }
}