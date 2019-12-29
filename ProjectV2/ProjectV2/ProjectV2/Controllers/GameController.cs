using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectV2.Models.Repository;

namespace ProjectV2.Controllers
{
    public class GameController : Controller
    {
        IGameRepository gameRepository;
        IStudioRepository studioRepository;
        IStoreRepository storeRepository;
        INewsRepository newsRepository;
        IDLCRepository dLCRepository;
        public GameController(IGameRepository gameRepository, IStudioRepository studioRepository, IStoreRepository storeRepository, 
            INewsRepository newsRepository, IDLCRepository dLCRepository)
        {
            this.gameRepository = gameRepository;
            this.studioRepository = studioRepository;
            this.storeRepository = storeRepository;
            this.newsRepository = newsRepository;
            this.dLCRepository = dLCRepository;
        }
        public IActionResult All()
        {
            ViewBag.AllGames = gameRepository.GetGames();
            return View();
        }
        [Route("Game/CurrentGame/{Id?}")]
        public IActionResult CurrentGame(int Id)
        {
            ViewBag.CurrentGame = gameRepository.GetGames().Where(a => a.Id == Id).FirstOrDefault();
            ViewBag.CurrentGameStudio = studioRepository.GetStudios().Where(a => a.Id == gameRepository.GetGames().Where(a => a.Id == Id).FirstOrDefault().StudioId).FirstOrDefault();
            ViewBag.CurrentGameNews = newsRepository.GetNews().Where(a => a.GamesId == Id);
            ViewBag.CurrentGameStore = storeRepository.GetStores().Where(a => a.Id == gameRepository.GetGames().Where(a => a.Id == Id).FirstOrDefault().StoreId).FirstOrDefault();
            ViewBag.CurrentGameDLC = dLCRepository.GetDLCs().Where(a => a.GameId == Id);
            return View();
        }
    }
}