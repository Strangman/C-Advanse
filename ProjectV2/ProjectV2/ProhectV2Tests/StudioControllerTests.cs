using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectV2.Controllers;
using ProjectV2.Models;
using ProjectV2.Models.Repository;

namespace ProjectV2Tests
{
    [TestClass]
    public class StudioControllerTests
    {
        [TestMethod]
        public void AllAction_StudioObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            var studioController = new StudioController(gameRepository, studioRepository);

            //Act
            studioController.All();
            var studios = studioController.ViewBag.AllStudios;

            //Assert
            foreach (var a in studios)
                Assert.IsInstanceOfType(a, typeof(Studio));
        }
        [TestMethod]
        public void CurrentStudioAction_StudioObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            var studioController = new StudioController(gameRepository, studioRepository);

            //Act
            studioController.CurrentStudio(1);
            var studio = studioController.ViewBag.CurrentStudio;

            //Assert
            Assert.IsInstanceOfType(studio, typeof(Studio));
        }
        [TestMethod]
        public void CurrentStoreAction_StudioNameReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            var studioController = new StudioController(gameRepository, studioRepository);

            //Act
            studioController.CurrentStudio(1);
            var studio = studioController.ViewBag.CurrentStudio;

            //Assert
            Assert.AreEqual(studio.Name, "Capcom");
        }
        [TestMethod]
        public void CurrentStudioAction_GameoObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            var studioController = new StudioController(gameRepository, studioRepository);

            //Act
            studioController.CurrentStudio(1);
            var games = studioController.ViewBag.CurrentStudioGames;

            //Assert
            foreach(var a in games)
            Assert.IsInstanceOfType(a, typeof(Game));
        }
        [TestMethod]
        public void CurrentStoreAction_GameNameReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStudioRepository studioRepository = new StudioRepository();
            var studioController = new StudioController(gameRepository, studioRepository);

            //Act
            studioController.CurrentStudio(1);
            var games = studioController.ViewBag.CurrentStudioGames;

            //Assert
            foreach(var a in games)
            Assert.AreEqual(a.Name, "MONSTER HUNTER: WORLD");
        }
    }
}
