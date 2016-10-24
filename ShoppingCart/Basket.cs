using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class Basket
    {     
        public double CalculateThePrice(List<BookDao> books)
        {
            //集合總數
            int MaxGroup = books.GroupBy(x => x.Episode)
                .OrderByDescending(y => y.Count())
                .FirstOrDefault()
                .Count();

            List<string> BookGroup = new List<string>();
            double total = 0;

            for (int j = 0; j < MaxGroup; j++)
            {
                double price = 0;
                //選取不同集數為一個集合
                for (int i=0; i< books.Count; i++)
                {
                    if (books[i].Episode != "0" && !BookGroup.Contains(books[i].Episode))
                    {
                        BookGroup.Add(books[i].Episode);
                        price += books[i].Price;
                        books[i].Episode = "0";   //將已購買的書籍排除
                    }
                }
                total += price * GetDiscount(BookGroup.Count);
                BookGroup.Clear();
            }

            return total;
        }

        private static double GetDiscount(int group)
        {
            double discount = 1;   //default
            switch (group)
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
                case 5:
                    discount = 0.75;
                    break;
            }
            return discount;
        }
    }
}