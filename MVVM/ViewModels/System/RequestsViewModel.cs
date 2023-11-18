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
    public class RequestsViewModel : ViewModelBase
    {
        public Visibility _requestVisibility { get; set; } = Visibility.Hidden;
        public ObservableCollection<Request> Requests { get; set; }
        public RequestsViewModel()
        {
            Requests = new ObservableCollection<Request>();
        }
        public void Add(Book book, User user)
        {
            Requests.Add(new Request(book, user));
        }
    }
}
