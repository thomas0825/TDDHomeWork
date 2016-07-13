using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayTwoHomeWork
{
    public class Book
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
      //  public int Quantity { get; private set; }

        public Book(string name, double price )
        {
            this.Name = name;
            this.Price = price;
            //this.Quantity = quantity;
        }
    }
    public class BookDiscountGroup
    {
        public List<Book> BooksSet = new List<Book>();
        public double GetBookGroupTotalAmountAfterDiscount()
        {
            switch(BooksSet.Count)
            {
                case 1:                   
                    return 100.0;
                case 2:
                    return 190.0;
                case 3:
                    return 270.0;
                case 4:
                    return 320.0;
                case 5:
                    return 375.0;
                default:
                    throw new  NotImplementedException(); 
            }              
        }
        public int GetNotExistBookName()
        {
            for(int i = 1   ; i < 6; i++)
            {
                if(BooksSet.Exists(x => x.Name == i.ToString())) { }
                else { return i; }                
            }
            throw new NotImplementedException();
        }
    } 

            
    public class order
    {
        private List<Book> _books;
        private List<BookDiscountGroup> _BookDiscountGroup = new List<BookDiscountGroup>();
        public order(List<Book> books)
        {
            this._books = books;

            foreach(var b in _books)
            {
                GetABookDiscountGroupWithoutSpecialBookName(b.Name).BooksSet.Add(b);
            }
        }
        private BookDiscountGroup GetABookDiscountGroupWithoutSpecialBookName(string name)
        {
            var q = (from BDG in _BookDiscountGroup
                    where BDG.GetNotExistBookName().ToString() == name
                    select BDG).FirstOrDefault();
            if(q ==null )
            {
                _BookDiscountGroup.Add(new BookDiscountGroup());
                return _BookDiscountGroup.Last();
            }
            return q;
        }
     
        public double GetOrderTotalAmount()
        {    
            return _BookDiscountGroup.Sum<BookDiscountGroup>(x => x.GetBookGroupTotalAmountAfterDiscount());
        }

    }   
}
