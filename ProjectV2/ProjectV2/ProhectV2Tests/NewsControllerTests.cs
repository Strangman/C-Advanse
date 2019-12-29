using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectV2.Controllers;
using ProjectV2.Models;
using ProjectV2.Models.Repository;

namespace ProjectV2Tests
{
    [TestClass]
    public class NewsControllerTests
    {
        [TestMethod]
        public void AllAction_NewsObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            INewsRepository newsRepository = new NewsRepository();
            var newsController = new NewsController(newsRepository, gameRepository);

            //Act
            newsController.All();
            var news = newsController.ViewBag.AllNews;

            //Assert
            foreach (var a in news)
                Assert.IsInstanceOfType(a, typeof(News_single));
        }
        [TestMethod]
        public void CurrentNewsAction_NewsObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            INewsRepository newsRepository = new NewsRepository();
            var newsController = new NewsController(newsRepository, gameRepository);

            //Act
            newsController.CurrentNews(1);
            var news = newsController.ViewBag.CurrentNews;

            //Assert
            Assert.IsInstanceOfType(news, typeof(News_single));
        }
        [TestMethod]
        public void CurrentNewsAction_NewsNameReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            INewsRepository newsRepository = new NewsRepository();
            var newsController = new NewsController(newsRepository, gameRepository);

            //Act
            newsController.CurrentNews(1);
            var news = newsController.ViewBag.CurrentNews;

            //Assert
            Assert.AreEqual(news.Title, "Capcom Details ‘Monster Hunter World: Iceborne’ 12.01 Update in Latest Dev Diary");
        }
        [TestMethod]
        public void CurrentNewsAction_GameObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            INewsRepository newsRepository = new NewsRepository();
            var newsController = new NewsController(newsRepository, gameRepository);

            //Act
            newsController.CurrentNews(1);
            var game = newsController.ViewBag.CurrentNewsGame;

            //Assert
            Assert.IsInstanceOfType(game, typeof(Game));
        }
        [TestMethod]
        public void CurrentNewsAction_GameNameReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            INewsRepository newsRepository = new NewsRepository();
            var newsController = new NewsController(newsRepository, gameRepository);

            //Act
            newsController.CurrentNews(1);
            var game = newsController.ViewBag.CurrentNewsGame;

            //Assert
            Assert.AreEqual(game.Name, "MONSTER HUNTER: WORLD");
        }
    }
}
