using BookMarket.MVVM.View.UserControls;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookMarket.MVVM.ViewModels
{
    public class ShowMessageBox : ViewModelBase
    {
        public Visibility MsgBoxVisibility { get; set; } = Visibility.Hidden;
        public string Message { get; set; }
        public RelayCommand OK_Button
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    MsgBoxVisibility = Visibility.Hidden;
                });
            }
        }
    }
}
