using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayTwoHomeWork
{
    public class Book
    {
        
        public Book(string name, double price ,int quantity )
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }
    }
    public class order
    {
        private List<Book> _books;

        public order(List<Book> books)
        {
            this._books = books;
        }
        public double GetOrderTotalAmount()
        {
            double TotalAmount = 0;
            return TotalAmount;
        }

    }
}
