using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class StudioController : Controller
    {
        ProjectContext db;
        public StudioController(ProjectContext context)
        {
            db = context;
        }
        public IActionResult All()
        {
            ViewBag.AllStudios = db.Studios.ToList();
            return View();
        }
        [Route("Studio/CurrentStudio/{Id?}")]
        public IActionResult CurrentStuudio(int Id)
        {
            ViewBag.CurrentStudio = db.Studios.Where(a => a.Id == Id).FirstOrDefault();
            ViewBag.CurrentStudioGames = db.Games.Where(a => a.StudioId == Id);
            return View();
        }
    }
}