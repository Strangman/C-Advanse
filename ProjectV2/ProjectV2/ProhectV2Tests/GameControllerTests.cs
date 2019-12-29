using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectV2.Controllers;
using ProjectV2.Models;
using ProjectV2.Models.Repository;

namespace ProjectV2Tests
{
    [TestClass]
    public class GameControllerTests
    {
        [TestMethod]
        public void AllAction_GameObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IStoreRepository storeRepository = new StoreRepository();
            INewsRepository newsRepository = new NewsRepository();
            IDLCRepository dLCRepository = new DLCRepository();
            var gameController = new GameController(gameRepository, studioRepository, storeRepository, newsRepository, dLCRepository);

            //Act
            gameController.All();
            var games = gameController.ViewBag.AllGames;

            //Assert
            foreach (var a in games)
                Assert.IsInstanceOfType(a, typeof(Game));
        }
        [TestMethod]
        public void CurrentGameAction_GameObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IStoreRepository storeRepository = new StoreRepository();
            INewsRepository newsRepository = new NewsRepository();
            IDLCRepository dLCRepository = new DLCRepository();
            var gameController = new GameController(gameRepository, studioRepository, storeRepository, newsRepository, dLCRepository);

            //Act
            gameController.CurrentGame(1);
            var game = gameController.ViewBag.CurrentGame;

            //Assert
            Assert.IsInstanceOfType(game, typeof(Game));
        }
        [TestMethod]
        public void CurrentGameAction_GameNameReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IStoreRepository storeRepository = new StoreRepository();
            INewsRepository newsRepository = new NewsRepository();
            IDLCRepository dLCRepository = new DLCRepository();
            var gameController = new GameController(gameRepository, studioRepository, storeRepository, newsRepository, dLCRepository);

            //Act
            gameController.CurrentGame(1);
            var game = gameController.ViewBag.CurrentGame;

            //Assert
            Assert.AreEqual(game.Name, "MONSTER HUNTER: WORLD");
        }
        [TestMethod]
        public void CurrentGameAction_StudioObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IStoreRepository storeRepository = new StoreRepository();
            INewsRepository newsRepository = new NewsRepository();
            IDLCRepository dLCRepository = new DLCRepository();
            var gameController = new GameController(gameRepository, studioRepository, storeRepository, newsRepository, dLCRepository);

            //Act
            gameController.CurrentGame(1);
            var studio = gameController.ViewBag.CurrentGameStudio;

            //Assert
            Assert.IsInstanceOfType(studio, typeof(Studio));
        }
        [TestMethod]
        public void CurrentGameAction_StudioNameReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IStoreRepository storeRepository = new StoreRepository();
            INewsRepository newsRepository = new NewsRepository();
            IDLCRepository dLCRepository = new DLCRepository();
            var gameController = new GameController(gameRepository, studioRepository, storeRepository, newsRepository, dLCRepository);

            //Act
            gameController.CurrentGame(1);
            var studio = gameController.ViewBag.CurrentGameStudio;

            //Assert
            Assert.AreEqual(studio.Name, "Capcom");
        }
        [TestMethod]
        public void CurrentGameAction_NewsObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IStoreRepository storeRepository = new StoreRepository();
            INewsRepository newsRepository = new NewsRepository();
            IDLCRepository dLCRepository = new DLCRepository();
            var gameController = new GameController(gameRepository, studioRepository, storeRepository, newsRepository, dLCRepository);

            //Act
            gameController.CurrentGame(1);
            var news = gameController.ViewBag.CurrentGameNews;

            //Assert
            foreach(var a in news)
            Assert.IsInstanceOfType(a, typeof(News_single));
        }
        [TestMethod]
        public void CurrentGameAction_NewsNameReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IStoreRepository storeRepository = new StoreRepository();
            INewsRepository newsRepository = new NewsRepository();
            IDLCRepository dLCRepository = new DLCRepository();
            var gameController = new GameController(gameRepository, studioRepository, storeRepository, newsRepository, dLCRepository);

            //Act
            gameController.CurrentGame(1);
            var news = gameController.ViewBag.CurrentGameNews;

            //Assert
            foreach(var a in news)
            Assert.AreEqual(a.Title, "Capcom Details ‘Monster Hunter World: Iceborne’ 12.01 Update in Latest Dev Diary");
        }
        [TestMethod]
        public void CurrentGameAction_StoreObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IStoreRepository storeRepository = new StoreRepository();
            INewsRepository newsRepository = new NewsRepository();
            IDLCRepository dLCRepository = new DLCRepository();
            var gameController = new GameController(gameRepository, studioRepository, storeRepository, newsRepository, dLCRepository);

            //Act
            gameController.CurrentGame(1);
            var store = gameController.ViewBag.CurrentGameStore;

            //Assert
            Assert.IsInstanceOfType(store, typeof(Store));
        }
        [TestMethod]
        public void CurrentGameAction_StoreNameReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IStoreRepository storeRepository = new StoreRepository();
            INewsRepository newsRepository = new NewsRepository();
            IDLCRepository dLCRepository = new DLCRepository();
            var gameController = new GameController(gameRepository, studioRepository, storeRepository, newsRepository, dLCRepository);

            //Act
            gameController.CurrentGame(1);
            var store = gameController.ViewBag.CurrentGameStore;

            //Assert
            Assert.AreEqual(store.Name, "Steam");
        }
        [TestMethod]
        public void CurrentGameAction_DLCObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IStoreRepository storeRepository = new StoreRepository();
            INewsRepository newsRepository = new NewsRepository();
            IDLCRepository dLCRepository = new DLCRepository();
            var gameController = new GameController(gameRepository, studioRepository, storeRepository, newsRepository, dLCRepository);

            //Act
            gameController.CurrentGame(1);
            var dlc = gameController.ViewBag.CurrentGameDLC;

            //Assert
            foreach (var a in dlc)
                Assert.IsInstanceOfType(a, typeof(DLC));
        }
        [TestMethod]
        public void CurrentGameAction_DLCNameReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IStoreRepository storeRepository = new StoreRepository();
            INewsRepository newsRepository = new NewsRepository();
            IDLCRepository dLCRepository = new DLCRepository();
            var gameController = new GameController(gameRepository, studioRepository, storeRepository, newsRepository, dLCRepository);

            //Act
            gameController.CurrentGame(1);
            var dlc = gameController.ViewBag.CurrentGameDLC;

            //Assert
            foreach (var a in dlc)
                Assert.AreEqual(a.Name, "Monster Hunter World: Iceborne");
        }
    }
}
