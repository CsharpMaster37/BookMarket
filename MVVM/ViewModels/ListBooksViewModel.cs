using BookMarket.MVVM.Model;
using BookMarket.MVVM.Model.Books;
using BookMarket.MVVM.View.UserControls;
using DevExpress.Mvvm;
using MaterialDesignThemes.Wpf;
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
        public int selectedBook { get; set; }
        public ListBooksViewModel() {
            ListBooks = new ObservableCollection<Book>(App._market._assortmentBooks.GetAssortment());        
        }
        public RelayCommand BookInformationButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    App._bookInformation.InformationAboutBook(ListBooks[selectedBook]);
                });
            }
        }
    }
}
