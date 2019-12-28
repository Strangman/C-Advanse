using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        ProjectContext db;
        public HomeController(ProjectContext context)
        {
            db = context;
        }
        public ViewResult Index()
        {
            ViewBag.Games = db.Games.ToList();
            return View();
        }

    }
}
