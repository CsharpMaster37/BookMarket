using BookMarket.MVVM.Model;
using BookMarket.MVVM.Model.Books;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookMarket.MVVM.ViewModels
{
    public class ListBooksViewModel : ViewModelBase
    {
        public Visibility _listVisibility { get; set; } = Visibility.Visible;
        public ObservableCollection<Book> ListBooks { get; set; }
        public ListBooksViewModel() {
            ListBooks = new ObservableCollection<Book>();        
        }
        public void Update(List<Book> books)
        {
            ListBooks = new ObservableCollection<Book>(books);
        }
    }
}
