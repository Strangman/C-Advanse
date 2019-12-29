using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectV2.Controllers;
using ProjectV2.Models;
using ProjectV2.Models.Repository;

namespace ProjectV2Tests
{
    [TestClass]
    public class StoreControllerTests
    {
        [TestMethod]
        public void AllAction_StoreObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStoreRepository storeRepository = new StoreRepository();
            var storeController = new StoreController(storeRepository, gameRepository );

            //Act
            storeController.All();
            var stores = storeController.ViewBag.AllStores;

            //Assert
            foreach (var a in stores)
                Assert.IsInstanceOfType(a, typeof(Store));
        }
        [TestMethod]
        public void CurrentStoreAction_StoreObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStoreRepository storeRepository = new StoreRepository();
            var storeController = new StoreController(storeRepository, gameRepository);

            //Act
            storeController.CurrentStore(1);
            var store = storeController.ViewBag.CurrentStore;

            //Assert
            Assert.IsInstanceOfType(store, typeof(Store));
        }
        [TestMethod]
        public void CurrentStoreAction_StoreNameReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStoreRepository storeRepository = new StoreRepository();
            var storeController = new StoreController(storeRepository, gameRepository);

            //Act
            storeController.CurrentStore(1);
            var store = storeController.ViewBag.CurrentStore;

            //Assert
            Assert.AreEqual(store.Name, "Steam");
        }
        [TestMethod]
        public void CurrentStoreAction_GameObjectReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStoreRepository storeRepository = new StoreRepository();
            var storeController = new StoreController(storeRepository, gameRepository);

            //Act
            storeController.CurrentStore(1);
            var games = storeController.ViewBag.CurrentStoreGames;

            //Assert
            foreach(var a in games)
            Assert.IsInstanceOfType(a, typeof(Game));
        }
        [TestMethod]
        public void CurrentStoreAction_GameNameReturned()
        {
            //Arrange
            IGameRepository gameRepository = new GameRepository();
            IStoreRepository storeRepository = new StoreRepository();
            var storeController = new StoreController(storeRepository, gameRepository);

            //Act
            storeController.CurrentStore(1);
            var games = storeController.ViewBag.CurrentStoreGames;

            //Assert
            foreach(var a in games)
            Assert.AreEqual(a.Name, "MONSTER HUNTER: WORLD");
        }
    }
}
