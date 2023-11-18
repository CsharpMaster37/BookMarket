using BookMarket.MVVM.Model.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model
{
    public class History
    {
        public string Title { get; }
        public string Author { get; }
        public int Price { get; }
        public int YearOfPublication { get; }
        public string Username { get; }
        public Book Book { get; }
        public History(Book book, User user)
        {
            Book = book;
            YearOfPublication = book.YearOfPublication;
            Title = book.Title;
            Author = book.Author;
            Price = book.Price;
            if(user is null)
                Username = "Вы";
            else { Username = user.Username; }
        }
    }
}
