using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    public class Basket
    {
        public int CalculateThePrice(BookDao books)
        {
            int price = books.Price;
            return price;
        }

        public int CalculateThePrice(List<BookDao> books)
        {
            throw new NotImplementedException();
        }
    }
}