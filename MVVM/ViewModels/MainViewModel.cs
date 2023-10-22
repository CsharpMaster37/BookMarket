using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BookMarket.MVVM.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        private Visibility _framesettings = Visibility.Hidden;
        public Visibility FrameSettings
        {  
            get { return _framesettings; }
            set
            {
                _framesettings = value;
                RaisePropertyChanged(() => FrameSettings);
            }
        }
        public RelayCommand SettingsButton
        {
            get { return new RelayCommand((obj) => FrameSettings = Helpers.ToggleVisibility(FrameSettings)); }
        }
    }
}
