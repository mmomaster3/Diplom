using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using homeless_pets.Models;

namespace homeless_pets.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult NewPage(int? id)
        {
            if (id == null)
            {
                return View("NewsRedactor");
            }

            NewsContext news = new NewsContext();
            return View(news.News.FirstOrDefault(n => n.NewID == id));
        }

        public ActionResult NewsRedactor()
        {
            NewsContext news = new NewsContext();
            return View(news.News);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult EditNews(New newVariable)
        {
            DBforNewsRedactor BDaction = new DBforNewsRedactor();
            if (ModelState.IsValid)
            {
                BDaction.SaveNew(newVariable);
                TempData["message"] = string.Format("Изменения \"{0}\" были сохранены", newVariable.Header);
                return RedirectToAction("NewsRedactor");
            }
            else
            {
                // Что-то не так со значениями данных
                return View(newVariable);
            }
        }

        public ViewResult Create()
        {
            return View("EditNews", new New());
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DBforNewsRedactor BDaction = new DBforNewsRedactor();
            New deletedNew = BDaction.DeleteNew(id);
            if (deletedNew != null)
            {
                TempData["message"] = string.Format(" \"{0}\" была удалена",
                    deletedNew.Header);
            }
            return RedirectToAction("NewsRedactor");
        }
    }
}