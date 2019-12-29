using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectV2.Data;
using ProjectV2.Models;
using ProjectV2.Models.Repository;

namespace ProjectV2.Controllers
{
    public class HomeController : Controller
    {
        IGameRepository gameRepository;
        public HomeController(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }
        public ViewResult Index()
        {
            ViewBag.Games = gameRepository.GetGames();
            return View();
        }
    }
}