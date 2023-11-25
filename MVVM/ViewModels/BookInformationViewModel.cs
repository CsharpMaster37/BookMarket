using BookMarket.MVVM.Model.Books;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookMarket.MVVM.ViewModels
{
    public class BookInformationViewModel : ViewModelBase
    {
        public Visibility InfoVisibility { get; set; } = Visibility.Hidden;
        public string Author { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int YearOfPublication { get; set; }
        public int PageCount { get; set; }
        public string Topic { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public void InformationAboutBook(Book book)
        {
            InfoVisibility = Visibility.Visible;
            Author = book.Author;
            Title = book.Title;
            Publisher = book.Publisher;
            YearOfPublication = book.YearOfPublication;
            PageCount = book.PageCount;
            Topic = book.Topic;
            Category = book.Category;
            Count = book.Count;
            Price = book.Price;
        }

        public RelayCommand CancelButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    InfoVisibility = Visibility.Hidden;
                });
            }
        }
    }
}
