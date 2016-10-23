using System;

namespace ShoppingCart
{
    public class Basket
    {
        public int CalculateThePrice(BookDao books)
        {
            int price = books.Price;
            return price;
        }
    }
}