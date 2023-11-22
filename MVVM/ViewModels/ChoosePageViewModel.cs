using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookMarket.MVVM.ViewModels
{
    internal class ChoosePageViewModel : ViewModelBase
    {
        public bool btn1 { get; set; }
        public bool btn2 { get; set; }
        public bool btn3 { get; set; }
        public bool btn4 { get; set; }
        public RelayCommand RadioButton_Category
        {
            get
            {
                return new RelayCommand((obj) =>
                {

                    if (btn1)
                        Choose(Visibility.Visible, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden);
                    else if(btn2)
                        Choose(Visibility.Hidden, Visibility.Visible, Visibility.Hidden, Visibility.Hidden);
                    else if (btn3)
                        Choose(Visibility.Hidden, Visibility.Hidden, Visibility.Visible, Visibility.Hidden);
                    else if (btn4)
                        Choose(Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Visible);
                });
            }
        }
        public void Choose(Visibility _btn1, Visibility _btn2, Visibility _btn3, Visibility _btn4)
        {
            App._listBooks._listVisibility = _btn1;
            App._statement._statementVisibility = _btn2;
            App._history._historyVisibility = _btn3;
            App._requests._requestVisibility = _btn4;
        }
    }
}
