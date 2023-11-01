using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model.Books
{
    public class Book : IElements
    {
        public string Author { get;}
        public string Title { get;}
        public string Publisher { get;}
        public int YearOfPublication { get;}
        public int PageCount { get;}
        public string Topic { get; }
        public string Category { get; }
        public int Price { get; }
        public int RetailMargin { get; }
        public int DemandRating { get; set; }
        public User User { get; }
        public Book(string author, string title, string publisher, int year, int pagecount, string topic, string category, int price, int retailmargin, int rating)
        {
            Author = author;
            Title = title;
            Publisher = publisher;
            YearOfPublication = year;
            PageCount = pagecount;
            Topic = topic;
            Category = category;
            Price = price + retailmargin;
            RetailMargin = retailmargin;
            DemandRating = rating;
        }
        public override bool Equals(object obj)
        {
            return obj is Book book &&
                Author == book.Author &&
                Title == book.Title &&
                Publisher == book.Publisher &&
                YearOfPublication == book.YearOfPublication &&
                PageCount == book.PageCount &&
                Topic == book.Topic &&
                Category == book.Category &&
                Price == book.Price &&
                RetailMargin == book.RetailMargin;
        }
        public override int GetHashCode()
        {
            var hash = HashCode.Combine(Author, Title,
            Publisher, YearOfPublication,
            PageCount, Topic, Category);
            return HashCode.Combine(hash, Price, RetailMargin);
        }

    }
}
