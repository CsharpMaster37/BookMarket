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
        public bool IsEnabled_Start { get; set; } = true;
        public bool IsEnabled_Settings { get; set; } = true;
        public bool IsEnabled_Reset { get; set; } = true;
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
                    App._statistic.Reset();
                    if (App._listBooks.ListBooks.Count > 0)
                    {
                        //Helpers.Block_Button_for_Modeling(false);
                        modelingService = new ModelingService(App._modelingSettings.LowerValue_TimeDelivery, App._modelingSettings.UpperValue_TimeDelivery,
                        App._modelingSettings.LowerValue_Threshold, App._modelingSettings.UpperValue_Threshold, App._modelingSettings.Value_ModelingPeriod,
                        App._modelingSettings.Value_ModelingStep);
                        Thread thread = new Thread(() => 
                        {
                            Helpers.Block_Button_for_Modeling(false);
                            modelingService.Start_Modeling();
                            Helpers.Block_Button_for_Modeling(true);
                        });
                        thread.Start();
                    }
                    
                });
            }
        }

        public RelayCommand Reset
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    App._modelingSettings.DefaultSettings();
                    App._statistic.Reset();
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
