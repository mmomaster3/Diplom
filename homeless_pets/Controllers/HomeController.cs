using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using homeless_pets.Models;

namespace homeless_pets.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NewsContext newsConx = new NewsContext();

            var pets = from m in newsConx.News
                       select m;

            return View(pets);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}