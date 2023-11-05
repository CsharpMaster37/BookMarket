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
        public RelayCommand CancelButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    View();
                });
            }
        }

        public Visibility _visibility { get; set; } = Visibility.Hidden;
        public void View()
        {
            if (_visibility == Visibility.Visible) { _visibility = Visibility.Hidden; }
            else { _visibility = Visibility.Visible; }
        }
    }
}
