using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectV2.Controllers;
using ProjectV2.Models;
using ProjectV2.Models.Repository;
using System.Collections.Generic;

namespace ProjectV2Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void IndexAction_GameObjectReturned()
        {
            //Arrange
            GameRepository gameRepository = new GameRepository();
            var homeController = new HomeController(gameRepository);

            //Act
            homeController.Index();
            var game = homeController.ViewBag.Games;

            //Assert
            foreach (var a in game)
            Assert.IsInstanceOfType(a, typeof(Game));
        }
    }
}
