using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab21;
using Lab21.Controllers;
using Lab21.Models;

namespace Lab21.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Register()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Register() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AddUser()
        {
            // Arrange
            HomeController controller = new HomeController();
            AddUserViewModel model = new AddUserViewModel();

            // Act
            ViewResult result = controller.AddUser(model) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
