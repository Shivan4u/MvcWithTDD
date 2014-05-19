using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcWithTDD;
using MvcWithTDD.Models;
using MvcWithTDD.Controllers;
using Telerik.JustMock;


namespace MvcWithTDD.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        [TestMethod]
        public void Index_Return_AllProductsInDB()
        { 
            //Arrange
            var productRepositry = Mock.Create<IRepositry>();
            Mock.Arrange(() => productRepositry.GetProducts())
                .Returns(new List<Product>()
                {
                    new Product { Genre="Action", Name="Rambo", ID=1, Price=4.6m },
                    new Product { Genre="Comedy", Name="Meet the parents", ID=1, Price=5.2m },
                    new Product { Genre="Classic", Name="Great escape", ID=3, Price=4.5m },
                });
                
            //Act
            HomeController controller = new HomeController(productRepositry);
            ViewResult viewResult = controller.Index();
            var model = viewResult.Model as IEnumerable<Product>;

            //Assert
            Assert.AreEqual(3, model.Count());
        }

        [TestMethod]
        public void Index_Return_ProductsByGenre()
        { 
            //Arrange
            var productRepositry = Mock.Create<IRepositry>();
            //Mock.Arrange
            Mock.Arrange(() => productRepositry.GetProducts())
                .Returns(new List<Product>() { });

        }

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
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
