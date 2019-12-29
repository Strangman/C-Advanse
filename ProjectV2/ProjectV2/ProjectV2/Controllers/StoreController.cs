using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectV2.Models.Repository;

namespace ProjectV2.Controllers
{
    public class StoreController : Controller
    {
        IStoreRepository storeRepository;
        IGameRepository gameRepository;
        public StoreController(IStoreRepository storeRepository, IGameRepository gameRepository)
        {
            this.storeRepository = storeRepository;
            this.gameRepository = gameRepository;
        }
        public IActionResult All()
        {
            ViewBag.AllStores = storeRepository.GetStores();
            return View();
        }
        [Route("Store/CurrentStore/{Id?}")]
        public IActionResult CurrentStore(int Id)
        {
            ViewBag.CurrentStore = storeRepository.GetStores().Where(a => a.Id == Id).FirstOrDefault();
            ViewBag.CurrentStoreGames = gameRepository.GetGames().Where(a => a.StoreId == storeRepository.GetStores().Where(a => a.Id == Id).FirstOrDefault().Id);
            return View();
        }
    }
}