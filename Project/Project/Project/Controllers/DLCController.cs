using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class DLCController : Controller
    {
        ProjectContext db;
        public DLCController(ProjectContext context)
        {
            db = context;
        }
        public IActionResult All()
        {
            ViewBag.AllDLC = db.DLCs;
            return View();
        }
        [Route("DLC/CurrentDLC/{Id?}")]
        public IActionResult CurrentDLC(int Id)
        {
            ViewBag.CurrentDLC = db.DLCs.Where(a => a.Id == Id).FirstOrDefault();
            ViewBag.CurrentDLCStudio = db.Studios.Where(a => a.Id == db.DLCs.Where(a => a.Id == Id).FirstOrDefault().StudioId).FirstOrDefault();
            ViewBag.CurrentDLCGame = db.Games.Where(a => a.Id == db.DLCs.Where(a => a.Id == Id).FirstOrDefault().GameId).FirstOrDefault();
            return View();
        }
    }
}