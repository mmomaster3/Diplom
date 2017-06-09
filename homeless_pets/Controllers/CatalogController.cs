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
        //public ActionResult List(int page = 1)
        //{
        //    PetsContext pets = new PetsContext();   
        //    return View(pets.Pets);
        //}

        public ActionResult Card(int? id)
        {
            ViewBag.Variable = id;
            PetsContext pets = new PetsContext();
            return View(pets.Pets);
        }

        public ActionResult List(string searchString, bool? gender, string all)
        {
            PetsContext petsConx = new PetsContext();
            var pets = from m in petsConx.Pets
                       select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                pets = pets.Where(s => s.Name.Contains(searchString));
            }

            ViewBag.SelectedGender = gender;

            if (gender != null)
            {
                pets = pets.Where(s => s.Gender == gender);

            }

            return View(pets);
        }
    }
}