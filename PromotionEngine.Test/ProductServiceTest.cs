using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using PromotionEngine.Model;

namespace PromotionEngine.Test
{
    [TestClass]
    public class ProductServiceTest
    {
        ProductService productService;

        public ProductServiceTest()
        {
            productService = new ProductService();
        }

        [TestMethod]
        public void Test_Scenario_1()
        {
            var order = new Order(1, new List<Product>()
                        {
                            new Product("A"),
                            new Product("B"),
                            new Product("C")
                        });

            //Arrange
            decimal expected = 100m;

            //Act
            decimal totalDiscount = productService.GetPromotions()
                                           .Select(promo => productService.GetDiscountedPrice(order, promo))
                                           .Sum();

            decimal actual = order.Products.Sum(x => x.Price) - totalDiscount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Scenario_2()
        {
            var order = new Order(1, new List<Product>()
                        {
                            new Product("A"), new Product("A"), new Product("A"), new Product("A"), new Product("A"),
                            new Product("B"), new Product("B"), new Product("B"), new Product("B"), new Product("B"),
                            new Product("C")
                        });

            //Arrange
            decimal expected = 370m;

            //Act
            decimal totalDiscount = productService.GetPromotions()
                                           .Select(promo => productService.GetDiscountedPrice(order, promo))
                                           .Sum();

            decimal actual = order.Products.Sum(x => x.Price) - totalDiscount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Scenario_3()
        {
            var order = new Order(1, new List<Product>()
                        {
                            new Product("A"), new Product("A"), new Product("A"),
                            new Product("B"), new Product("B"), new Product("B"), new Product("B"), new Product("B"),
                            new Product("C"),
                            new Product("D")
                        });

            //Arrange
            decimal expected = 275m;

            //Act
            decimal totalDiscount = productService.GetPromotions()
                                           .Select(promo => productService.GetDiscountedPrice(order, promo))
                                           .Sum();

            decimal actual = order.Products.Sum(x => x.Price) - totalDiscount;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
