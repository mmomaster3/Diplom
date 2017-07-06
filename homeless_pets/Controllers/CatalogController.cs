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

        public ActionResult List(string searchString, string all, string MoveGender = null)
        {
            PetsContext petsConx = new PetsContext();
            var pets = from m in petsConx.Pets
                       select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                pets = pets.Where(s => s.Name.Contains(searchString));
            }

            //ViewBag.SelectedGender = gender;

            if (MoveGender != null && MoveGender != "Выбрать пол")
            {
                pets = pets.Where(s => s.Gender == (MoveGender == "Женский" ? true: false));

            }

            List<SelectListItem> genderItems = new List<SelectListItem>();
            genderItems.Add(new SelectListItem() { Text = "Выбрать пол", Selected = (MoveGender) == null ? true : false });
            genderItems.Add(new SelectListItem() { Text = "Мужской", Value = "Мужской", Selected = (MoveGender) == "Мужской" ? true : false });
            genderItems.Add(new SelectListItem() { Text = "Женский", Value = "Женский", Selected = (MoveGender) == "Женский" ? true : false });
            ViewBag.MoveGender = genderItems;

            return View(pets);
        }
    }
}