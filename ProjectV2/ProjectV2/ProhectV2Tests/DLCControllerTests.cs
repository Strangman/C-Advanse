using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectV2.Controllers;
using ProjectV2.Models;
using ProjectV2.Models.Repository;

namespace ProjectV2Tests
{
    [TestClass]
    public class DLCControllerTests
    {
        [TestMethod]
        public void AllAction_DLCObjectReturned()
        {
            //Arrange
            IDLCRepository dLCRepository = new DLCRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IGameRepository gameRepository = new GameRepository();
            var dlcController = new DLCController(dLCRepository, studioRepository, gameRepository);

            //Act
            dlcController.All();
            var dlc = dlcController.ViewBag.AllDLC;

            //Assert
            foreach (var a in dlc)
                Assert.IsInstanceOfType(a, typeof(DLC));
        }
        [TestMethod]
        public void CurrentDLCAction_DLCObjectReturned()
        {
            //Arrange
            IDLCRepository dLCRepository = new DLCRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IGameRepository gameRepository = new GameRepository();
            var dlcController = new DLCController(dLCRepository, studioRepository, gameRepository);

            //Act
            dlcController.CurrentDLC(1);
            var dlc = dlcController.ViewBag.CurrentDLC;

            //Assert
            Assert.IsInstanceOfType(dlc, typeof(DLC));
        }
        [TestMethod]
        public void CurrentDLCAction_DLCNameReturned()
        {
            //Arrange
            IDLCRepository dLCRepository = new DLCRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IGameRepository gameRepository = new GameRepository();
            var dlcController = new DLCController(dLCRepository, studioRepository, gameRepository);

            //Act
            dlcController.CurrentDLC(1);
            var dlc = dlcController.ViewBag.CurrentDLC;

            //Assert
            Assert.AreEqual(dlc.Name, "Monster Hunter World: Iceborne");
        }
        [TestMethod]
        public void CurrentDLCAction_StudioObjectReturned()
        {
            //Arrange
            IDLCRepository dLCRepository = new DLCRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IGameRepository gameRepository = new GameRepository();
            var dlcController = new DLCController(dLCRepository, studioRepository, gameRepository);

            //Act
            dlcController.CurrentDLC(1);
            var studio = dlcController.ViewBag.CurrentDLCStudio;

            //Assert
            Assert.IsInstanceOfType(studio, typeof(Studio));
        }
        [TestMethod]
        public void CurrentDLCAction_StudioNameReturned()
        {
            //Arrange
            IDLCRepository dLCRepository = new DLCRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IGameRepository gameRepository = new GameRepository();
            var dlcController = new DLCController(dLCRepository, studioRepository, gameRepository);

            //Act
            dlcController.CurrentDLC(1);
            var studio = dlcController.ViewBag.CurrentDLCStudio;

            //Assert
            Assert.AreEqual(studio.Name, "Capcom");
        }
        [TestMethod]
        public void CurrentDLCAction_GameObjectReturned()
        {
            //Arrange
            IDLCRepository dLCRepository = new DLCRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IGameRepository gameRepository = new GameRepository();
            var dlcController = new DLCController(dLCRepository, studioRepository, gameRepository);

            //Act
            dlcController.CurrentDLC(1);
            var game = dlcController.ViewBag.CurrentDLCGame;

            //Assert
            Assert.IsInstanceOfType(game, typeof(Game));
        }
        [TestMethod]
        public void CurrentDLCAction_GameNameReturned()
        {
            //Arrange
            IDLCRepository dLCRepository = new DLCRepository();
            IStudioRepository studioRepository = new StudioRepository();
            IGameRepository gameRepository = new GameRepository();
            var dlcController = new DLCController(dLCRepository, studioRepository, gameRepository);

            //Act
            dlcController.CurrentDLC(1);
            var game = dlcController.ViewBag.CurrentDLCGame;

            //Assert
            Assert.AreEqual(game.Name, "MONSTER HUNTER: WORLD");
        }
    }
}