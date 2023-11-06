using DevExpress.Mvvm;
using MaterialDesignThemes.Wpf.Converters.CircularProgressBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookMarket.MVVM.ViewModels
{
    public class ModelingSettingsViewModel : ViewModelBase
    {
        public Visibility _visibility { get; set; } = Visibility.Hidden;
        public void View()
        {
            if(_visibility == Visibility.Visible) { _visibility = Visibility.Hidden; }
            else { _visibility = Visibility.Visible; }
        }

    }
}
