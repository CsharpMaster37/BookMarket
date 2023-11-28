using BookMarket.MVVM.Model.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model
{
    public class Request
    {
        public string Title { get; }
        public string Author { get; }
        public int Price { get; }
        public int YearOfPublication { get; }
        public string Communication { get; }
        public string Username {get;}
        public User Buyer { get; }
        public Book Book { get; }
        public Request(Book book, User user)
        {
            Book = book;
            YearOfPublication = book.YearOfPublication;
            Title = book.Title;
            Author = book.Author;
            Price = book.Price;
            if (user is null)
            {
                Username = "Вы";
                Communication = "abc123@mail.ru";
            }
            else
            {
                Buyer = user;
                Communication = user.Communication;
                Username = user.Username;
            }
        }
    }
}
