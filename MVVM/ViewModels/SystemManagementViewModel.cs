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
        public int CountType { get; set; }
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
                    App._market._assortmentBooks._assortment.Clear();
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
                        App._market.Generation(CountType);
                        Helpers.GenerateButton();
                    }
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
