using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectV2.Models.Repository;

namespace ProjectV2.Controllers
{
    public class StudioController : Controller
    {
        IGameRepository gameRepository;
        IStudioRepository studioRepository;
        public StudioController(IGameRepository gameRepository, IStudioRepository studioRepository)
        {
            this.gameRepository = gameRepository;
            this.studioRepository = studioRepository;
        }
        public IActionResult All()
        {
            ViewBag.AllStudios = studioRepository.GetStudios().ToList();
            return View();
        }
        [Route("Studio/CurrentStudio/{Id?}")]
        public IActionResult CurrentStudio(int Id)
        {
            ViewBag.CurrentStudio = studioRepository.GetStudios().Where(a => a.Id == Id).FirstOrDefault();
            ViewBag.CurrentStudioGames = gameRepository.GetGames().Where(a => a.StudioId == Id);
            return View();
        }
    }
}