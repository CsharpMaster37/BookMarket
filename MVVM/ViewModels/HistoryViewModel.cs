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
    public class HistoryViewModel : ViewModelBase
    {
        public Visibility _historyVisibility { get; set; } = Visibility.Hidden;
        public ObservableCollection<History> History { get; set; }
        public HistoryViewModel()
        {
            History = new ObservableCollection<History>();
        }
        public void Add(Book book, User user)
        {
            History.Add(new History(book, user));
        }
    }
}
