using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace BookMarket.MVVM.Model.Books
{
    public class Book
    {
        public string Author { get;}
        public string Title { get;}
        public string Publisher { get;}
        public int YearOfPublication { get;}
        public int? PageCount { get;}
        public string Topic { get; }
        public string Category { get; }
        public int Count { get; set; }
        public int Price { get; set; }
        public int RetailMargin { get; set; }
        public int DemandRating { get; set; }
        public User User { get; }
        public Book(string author, string title, string publisher, int year, int? pagecount, string topic, string category, int price)
        {
            Author = author;
            Title = title;
            Publisher = publisher;
            YearOfPublication = year;
            PageCount = pagecount;
            Topic = topic;
            Category = category;
            Price = price + RetailMargin;
        }
        public override bool Equals(object obj)
        {
            return obj is Book book &&
                Author == book.Author &&
                Title == book.Title &&
                Publisher == book.Publisher &&
                YearOfPublication == book.YearOfPublication;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Author, Title, Publisher, YearOfPublication);
        }

    }
}
