using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Task01.Controllers;
using Task01.Models;
using Task01.Models.Repository;

namespace Task01Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DataAction_CharacterObjectReturned()
        {
            //Arrange
            Mock<ICharacterRepository> characterRepository = new Mock<ICharacterRepository>();
            characterRepository.Setup(x => x.GetCharacters()).Returns(new List<Character>() { new Character() });
            var homeController = new HomeController(characterRepository.Object);

            //Act
            var viewResult = homeController.Data();

            //Assert
            var character = viewResult.ViewData["character"];
            Assert.IsInstanceOfType(character, typeof(Character));
        }
        [TestMethod]
        public void TestResult_CharacterFirstNameReturned()
        {
            //Arrange
            CharacterRepository characterRepository = new CharacterRepository();
            var homeController = new HomeController(characterRepository);

            //Act
            var viewResult = homeController.TestResult(2);

            //Assert
            var character = viewResult.ViewData["character"];
            Assert.AreEqual("Bob", character);
        }
    }
}
