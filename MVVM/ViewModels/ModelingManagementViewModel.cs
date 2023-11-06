using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.ViewModels
{
    public class ModelingManagementViewModel : ViewModelBase
    {
        public RelayCommand SettingsButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    Helpers.CloseCreate();
                    App._modelingSettings.View();                  
                });
            }
        }

    }
}
