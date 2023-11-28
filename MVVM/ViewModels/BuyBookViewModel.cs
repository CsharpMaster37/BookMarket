using BookMarket.MVVM.Model;
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
    public class BuyBookViewModel : ViewModelBase
    {
        public Visibility BuyVisibility { get; set; } = Visibility.Hidden;
        public string Username { get; set; }
        public string Communication { get; set; }
        public RelayCommand BuyBookButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    if (Username != null && Communication != null)
                        App._market.BuyBook(App._listBooks.selectedBook, new User(Username, Communication));
                    else
                        App._market.BuyBook(App._listBooks.selectedBook, null);
                    BuyVisibility = Visibility.Hidden;
                    Username = "";
                    Communication = "";
                    App._bookInformation.InfoVisibility = Visibility.Hidden;
                });
            }
        }
        public RelayCommand CancelButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    BuyVisibility = Visibility.Hidden;   
                });
            }
        }
        public void CloseBuy()
        {
            BuyVisibility = Visibility.Hidden;
        }
    }
}
