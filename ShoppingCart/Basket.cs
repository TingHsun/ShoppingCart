using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class Basket
    {
        public int CalculateThePrice(BookDao books)
        {
            int price = books.Price;
            return price;
        }

        public double CalculateThePrice(List<BookDao> books)
        {
            double discount = 1;
            switch (books.Count)
            {
                case 1:
                    discount = 1;
                    break;
                case 2:
                    discount = 0.95;
                    break;
            }
            double price = books.Select(x => x.Price).Sum() * discount;
            return price;
        }
    }
}