using BookMarket.MVVM.Model;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookMarket.MVVM.ViewModels
{
    public class ModelingManagementViewModel : ViewModelBase
    {
        public ModelingService modelingService;
        public RelayCommand SettingsButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    Helpers.CloseCreate();
                    Helpers.Synchronization_Info();
                    App._modelingSettings.View();                  
                });
            }
        }
        public RelayCommand Start_Modeling
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    modelingService = new ModelingService(App._modelingSettings.LowerValue_TimeDelivery, App._modelingSettings.UpperValue_TimeDelivery,
                        App._modelingSettings.LowerValue_Threshold, App._modelingSettings.UpperValue_Threshold, App._modelingSettings.Value_ModelingPeriod,
                        App._modelingSettings.Value_ModelingStep);
                    Thread thread = new Thread(() => { modelingService.Start_Modeling(); });
                    thread.Start();
                });
            }
        }

        public RelayCommand Stop_Modeling
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    if (modelingService != null)
                    {
                        modelingService.IsStoped = true;
                    }
                });
            }
        }

    }
}
