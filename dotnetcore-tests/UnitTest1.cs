using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnetcore_sample.Controllers; 

namespace dotnetcore_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void About()
        {
          // Arrange
          HomeController controller = new HomeController();

          // Act
          ViewResult result = controller.About() as ViewResult;

          // Assert
          Assert.AreEqual("Your application description page.", result.ViewData["Message"]);
        }

        [TestMethod]
        public void Contact()
        {
          // Arrange
          HomeController controller = new HomeController();

          // Act
          ViewResult result = controller.Contact() as ViewResult;

          // Assert
          Assert.AreEqual("Your contact page.", result.ViewData["Message"]);
        }

        [TestMethod]
        public void Contact1()
        {
          // Arrange
          HomeController controller = new HomeController();

          // Act
          ViewResult result = controller.Contact() as ViewResult;

          // Assert
          Assert.AreEqual("Your contact page.", result.ViewData["Message"]);
        }

        [TestMethod]
        public void Contact2()
        {
          // Arrange
          HomeController controller = new HomeController();

          // Act
          ViewResult result = controller.Contact() as ViewResult;

          // Assert
          Assert.AreEqual("Your contact page.", result.ViewData["Message"]);
        }

        [TestMethod]
        public void Contact3()
        {
          // Arrange
          HomeController controller = new HomeController();

          // Act
          ViewResult result = controller.Contact() as ViewResult;

          // Assert
          Assert.AreEqual("Your contact page.", result.ViewData["Message"]);
        }

        [TestMethod]
        public void Contact4()
        {
          // Arrange
          HomeController controller = new HomeController();

          // Act
          ViewResult result = controller.Contact() as ViewResult;

          // Assert
          Assert.AreEqual("Your contact page.", result.ViewData["Message"]);
        }                                
    }
}
