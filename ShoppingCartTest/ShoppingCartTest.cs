using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;

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
            var books = new BookDao(){ Episode = "1" , Price = 100};
            Basket basket = new Basket();
            int actual = basket.CalculateThePrice(books);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
