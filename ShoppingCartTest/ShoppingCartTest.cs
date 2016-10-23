using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using System.Collections.Generic;

namespace ShoppingCartTest
{
    [TestClass]
    public class ShoppingCartTest
    {
        [TestMethod]
        public void buy_books_episode_1_amount_1_in_shoppingcart()
        {
            //Arrange
            int expected = 100;

            //Act
            var books = new List<BookDao>
            {
                new BookDao { Episode = "1", Price = 100 }
            };
            Basket basket = new Basket();
            double actual = basket.CalculateThePrice(books);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void buy_2_books_ep1_ep2_in_shoppingcart()
        {
            //Arrange
            double expected = 190;

            //Act
            var books = new List<BookDao>
            {
                new BookDao { Episode = "1", Price = 100 },
                new BookDao { Episode = "2", Price = 100 },
            };
            Basket basket = new Basket();
            double actual = basket.CalculateThePrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void buy_3_books_ep1_ep2_ep3_in_shoppingcart()
        {
            //Arrange
            double expected = 270;

            //Act
            var books = new List<BookDao>
            {
                new BookDao { Episode = "1", Price = 100 },
                new BookDao { Episode = "2", Price = 100 },
                new BookDao { Episode = "3", Price = 100 },
            };
            Basket basket = new Basket();
            double actual = basket.CalculateThePrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void buy_4_books_ep1_ep2_ep3_ep4_in_shoppingcart()
        {
            //Arrange
            double expected = 320;

            //Act
            var books = new List<BookDao>
            {
                new BookDao { Episode = "1", Price = 100 },
                new BookDao { Episode = "2", Price = 100 },
                new BookDao { Episode = "3", Price = 100 },
                new BookDao { Episode = "4", Price = 100 },
            };
            Basket basket = new Basket();
            double actual = basket.CalculateThePrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void buy_5_books_ep1_ep2_ep3_ep4_ep5_in_shoppingcart()
        {
            //Arrange
            double expected = 375;

            //Act
            var books = new List<BookDao>
            {
                new BookDao { Episode = "1", Price = 100 },
                new BookDao { Episode = "2", Price = 100 },
                new BookDao { Episode = "3", Price = 100 },
                new BookDao { Episode = "4", Price = 100 },
                new BookDao { Episode = "5", Price = 100 },
            };
            Basket basket = new Basket();
            double actual = basket.CalculateThePrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
