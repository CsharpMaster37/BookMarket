using DevExpress.Mvvm;
using DevExpress.Mvvm.UI.Interactivity.Internal;
using MaterialDesignThemes.Wpf.Converters.CircularProgressBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace BookMarket.MVVM.ViewModels
{
    public class ModelingSettingsViewModel : ViewModelBase
    {

        public Visibility _visibility { get; set; }
        public ModelingSettingsViewModel()
        {
            _visibility = Visibility.Hidden;
            DefaultSettings();
        }

        public RelayCommand DefaultButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    DefaultSettings();
                });
            }
        }

        public RelayCommand ApplyButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    _visibility = Visibility.Hidden;
                });
            }
        }

        public void View()
        {
            if(_visibility == Visibility.Visible) { _visibility = Visibility.Hidden; }
            else { _visibility = Visibility.Visible; }
        }
        private void DefaultSettings()
        {
            LowerValue_TimeDelivery = 2;
            UpperValue_TimeDelivery = 4;
            LowerValue_Threshold = 3;
            UpperValue_Threshold = 4;
            Value_ModelingPeriod = 20;
            Value_ModelingStep = 2;
        }

        #region Типы настроек

        public int LowerValue_TimeDelivery { get; set; }
        public int UpperValue_TimeDelivery { get; set; }
        public int LowerValue_Threshold { get; set; }
        public int UpperValue_Threshold { get; set; }
        public int Value_ModelingPeriod { get; set; }
        public int Value_ModelingStep { get; set; }

        #endregion
    }
}
