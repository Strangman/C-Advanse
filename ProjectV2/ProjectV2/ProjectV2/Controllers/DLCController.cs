using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectV2.Models.Repository;

namespace ProjectV2.Controllers
{
    public class DLCController : Controller
    {
        IDLCRepository  dLCRepository;
        IStudioRepository studioRepository;
        IGameRepository gameRepository;
        public DLCController(IDLCRepository dLCRepository, IStudioRepository studioRepository, IGameRepository gameRepository)
        {
            this.dLCRepository = dLCRepository;
            this.studioRepository = studioRepository;
            this.gameRepository = gameRepository;
        }
        public IActionResult All()
        {
            ViewBag.AllDLC = dLCRepository.GetDLCs();
            return View();
        }
        [Route("DLC/CurrentDLC/{Id?}")]
        public IActionResult CurrentDLC(int Id)
        {
            ViewBag.CurrentDLC = dLCRepository.GetDLCs().Where(a => a.Id == Id).FirstOrDefault();
            ViewBag.CurrentDLCStudio = studioRepository.GetStudios().Where(a => a.Id == dLCRepository.GetDLCs().Where(a => a.Id == Id).FirstOrDefault().StudioId).FirstOrDefault();
            ViewBag.CurrentDLCGame = gameRepository.GetGames().Where(a => a.Id == dLCRepository.GetDLCs().Where(a => a.Id == Id).FirstOrDefault().GameId).FirstOrDefault();
            return View();
        }
    }
}