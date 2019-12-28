using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class GameController : Controller
    {
        ProjectContext db;
        public GameController(ProjectContext context)
        {
            db = context;
        }
        public IActionResult All()
        {
            ViewBag.AllGames = db.Games.ToList();
            return View();
        }
        [Route("Game/CurrentGame/{Id?}")]
        public IActionResult CurrentGame(int Id)
        {
            ViewBag.CurrentGame = db.Games.Where(a => a.Id == Id).FirstOrDefault();
            ViewBag.CurrentGameStudio = db.Studios.Where(a => a.Id == db.Games.Where(a => a.Id == Id).FirstOrDefault().StudioId).FirstOrDefault();
            ViewBag.CurrentGameNews = db.News.Where(a => a.GamesId == Id);
            ViewBag.CurrentGameStore = db.Stores.Where(a => a.Id == db.Games.Where(a => a.Id == Id).FirstOrDefault().StoreId).FirstOrDefault();
            ViewBag.CurrentGameDLC = db.DLCs.Where(a => a.GameId == Id);
            return View();
        }
    }
}