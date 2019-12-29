using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectV2.Models.Repository;

namespace ProjectV2.Controllers
{
    public class NewsController : Controller
    {
        INewsRepository newsRepository;
        IGameRepository gameRepository;
        public NewsController(INewsRepository newsRepository, IGameRepository gameRepository)
        {
            this.newsRepository = newsRepository;
            this.gameRepository = gameRepository;
        }
        public IActionResult All()
        {
            ViewBag.AllNews = newsRepository.GetNews();
            return View();
        }
        [Route("News/CurrentNews/{Id?}")]
        public IActionResult CurrentNews(int Id)
        {
            ViewBag.CurrentNews = newsRepository.GetNews().Where(a => a.Id == Id).FirstOrDefault();
            ViewBag.CurrentNewsGame = gameRepository.GetGames().Where(a => a.Id == newsRepository.GetNews().Where(a => a.Id == Id).FirstOrDefault().GamesId).FirstOrDefault();
            return View();
        }
    }
}