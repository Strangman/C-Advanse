using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Task01.Models;
using Task01.Models.Repository;

namespace Task01.Controllers
{
    public class HomeController : Controller
    {
        private ICharacterRepository characterRepository;

        public HomeController(ICharacterRepository characterRepository)
        {
            this.characterRepository = characterRepository;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [Route("Home/GetCharacter/{i?}")]
        public IActionResult GetCharacter(int i)
        {
            if (i == 0)
            {
                return Content("Please, enter characters Id");
            }
            else
            {
                ViewBag.CharacterList = characterRepository.GetCharacters().FirstOrDefault(some => some.Id == i);
                return View();
            }
        }
        public ViewResult Data()  //Methode for unit testing
        {
            ViewData["character"] = characterRepository.GetCharacters().FirstOrDefault();
            return View();
        }
        public ViewResult TestResult(int i)   //Methode for unit testing
        {
            ViewData["character"] = characterRepository.GetCharacters().FirstOrDefault(some => some.Id == i).FirstName;
            return View();
        }
    }
}
