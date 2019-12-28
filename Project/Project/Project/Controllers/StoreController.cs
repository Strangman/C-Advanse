using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class StoreController : Controller
    {
        ProjectContext db;
        public StoreController(ProjectContext context)
        {
            db = context;
        }
        public IActionResult All()
        {
            ViewBag.AllStores = db.Stores;
            return View();
        }
        [Route("Store/CurrentStore/{Id?}")]
        public IActionResult CurrentStore(int Id)
        {
            ViewBag.CurrentStore = db.Stores.Where(a => a.Id == Id).FirstOrDefault();
            ViewBag.CurrentStoregames = db.Games.Where(a => a.StoreId == db.Stores.Where(a => a.Id == Id).FirstOrDefault().Id);
            return View();
        }
    }
}