using Komsky.Data.DataAccess.UnitOfWork;
using Komsky.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Mvc;

namespace Komsky.Web.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private IDataFacade _facade;
        [TestInitialize]
        public void Init()
        {
            Mock<IDataFacade> mock = new Mock<IDataFacade>();
            _facade = new Mock<IDataFacade>().Object;
            

        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(_facade);
            var mock = new Mock<ControllerContext>();
            mock.Setup(p => p.HttpContext.User.Identity.Name).Returns((string)null);
            mock.SetupGet(p => p.HttpContext.Request.IsAuthenticated).Returns(true);
            controller.ControllerContext = mock.Object;

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(null, result.ViewBag.UserDetails);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController(_facade);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController(_facade);

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
