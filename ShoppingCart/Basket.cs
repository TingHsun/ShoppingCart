using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class Basket
    {     
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
                case 3:
                    discount = 0.9;
                    break;
                case 4:
                    discount = 0.8;
                    break;
            }
            double price = books.Select(x => x.Price).Sum() * discount;
            return price;
        }
    }
}