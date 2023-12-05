using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookMarket.MVVM.ViewModels
{
    public class SystemManagementViewModel : ViewModelBase
    {
        public int count;
        public bool IsEnabled_Add { get; set; } = true;
        public bool IsEnabled_Clear { get; set; } = true;
        public bool IsEnabled_Generate { get; set; } = true;
        public int CountType
        {
            get { return count; }
            set
            {
                if (value < 0) 
                    count = 0;
                else
                    count = value;

            }
        }
        public Visibility _visibility_count { get; set; }
        public Visibility _visibility_count_button { get; set; }
        public SystemManagementViewModel()
        {
            _visibility_count = Visibility.Hidden;
            _visibility_count_button = Visibility.Hidden;
        }

        public RelayCommand AddBookButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    Helpers.CloseSettings();
                    Helpers.Synchronization_Info();
                    App._createBook.View();
                });
            }
        }
        public RelayCommand ClearButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    Helpers.Synchronization_Button();
                    Helpers.Synchronization_Info();
                    App._market._assortmentBooks._assortment.Clear();
                    App._listBooks.ListBooks.Clear();
                    App._history.History.Clear();
                    App._requests.Requests.Clear();
                    App._statement.Statement.Clear();
                });
            }
        }
        public RelayCommand OK_GenateButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    if(CountType > 0) 
                    {
                        Helpers.Synchronization_Button();
                        Helpers.Synchronization_Info();
                        App._market.Generation(CountType);
                        CountType = 0;
                    }
                    Helpers.GenerateButton();
                });
            }
        }
        public RelayCommand GenerateButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    Helpers.Synchronization_Button();
                    Helpers.GenerateButton();
                });
            }
        }
    }
}
