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
        private int? pageCount;
        private int pricee;
        private int Pubyear;
        private string topic;
        private string category;
        public string Author { get;}
        public string Title { get;}
        public string Publisher { get;}
        public int YearOfPublication 
        {
            get { return Pubyear; }
            set
            {
                if (value < 0 || value > 2023)
                    throw new ArgumentException();
                Pubyear = value;
            }
        }
        public int? PageCount
        {
            get { return pageCount; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                pageCount = value;
            }
        }
        public string Topic 
        {
            get { return topic; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]))
                    {
                        throw new ArgumentException();
                    }
                }
                topic = value;
            }
        }
        public string Category 
        {
            get { return category;}
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]))
                    {
                        throw new ArgumentException();
                    }
                }
                category = value;
            }
        }
        public int Count { get; set; }
        public int Price 
        {
            get { return pricee; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException();
                pricee = value; 
            }
        }
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
            Price = price;
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
