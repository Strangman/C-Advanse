using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class NewsController : Controller
    {
        ProjectContext db;
        public NewsController(ProjectContext context)
        {
            db = context;
        }
        public IActionResult All()
        {
            ViewBag.AllNews = db.News;
            return View();
        }
        [Route("News/CurrentNews/{Id?}")]
        public IActionResult CurrentNews(int Id)
        {
            ViewBag.CurrentNews = db.News.Where(a => a.Id == Id).FirstOrDefault();
            ViewBag.CurrentNewsGame = db.Games.Where(a => a.Id == db.News.Where(a => a.Id == Id).FirstOrDefault().GamesId).FirstOrDefault();
            return View();
        }
    }
}