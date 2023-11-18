using BookMarket.MVVM.Model.Books;
using BookMarket.MVVM.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model
{
    public class Statement : IStatement
    {
        public string Title { get;}
        public string Author { get;}
        public int Price { get;}
        public int YearOfPublication { get;}
        public int DeliveryTime { get; set; }
        public int Count { get;}
        public Book Book { get;}
        public Statement(Book book, int deliverytime, int count) 
        {
            Book = book;
            DeliveryTime = deliverytime;
            YearOfPublication = book.YearOfPublication;
            Count = count;
            Title = book.Title;
            Author = book.Author;
            Price = book.Price;
        }
        public bool DayPassed()
        {
            DeliveryTime--;
            if (DeliveryTime == 0)
            {
                Done();
                return true;
            }
            return false;
        }
        public void Done()
        {
            App._market.AddBook(Book, Count);
        }
    }
}
