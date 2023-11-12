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
    public class CreateBookViewModel : ViewModelBase
    {
        public string _title { get; set; } = "";
        public string _author { get; set; } = "";
        public string _year { get; set; } = "";
        public string _publisher { get; set; } = "";
        public string _price { get; set; } = "";
        public string _countpages { get; set; } = "";
        public string _category { get; set; } = "";
        public string _topic { get; set; } = "";


        public RelayCommand CancelButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    View();
                    DataClear();
                });
            }
        }



        public RelayCommand Add
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    Book newbook = new Book(_author, _title, _publisher, int.Parse(_year), int.Parse(_countpages), _topic, _category, int.Parse(_price));
                    App._market.AddBook(newbook,1);
                    App._listBooks.ListBooks.Add(newbook);
                    Helpers.CloseCreate();
                    DataClear();
                });
            }
        }

        private void DataClear()
        {
            _title = "";
            _year = "";
            _publisher = "";
            _author = "";
            _price = "";
            _countpages = "";
            _category = "";
            _topic = "";
        }

        public Visibility _visibility { get; set; } = Visibility.Hidden;
        public void View()
        {
            if (_visibility == Visibility.Visible) { _visibility = Visibility.Hidden; }
            else { _visibility = Visibility.Visible; }
        }
    }
}
