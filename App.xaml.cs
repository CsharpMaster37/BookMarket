using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using BookMarket.MVVM.Model;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using BookMarket.MVVM.ViewModels;

namespace BookMarket
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Market _market { get; }
        public static ModelingManagementViewModel _modelingManagement { get; }
        public static SystemManagementViewModel _systemManagement { get; }
        public static ModelingSettingsViewModel _modelingSettings { get; }
        public static CreateBookViewModel _createBook { get; }

        static App()
        {
            _market = new Market();
            _systemManagement = new SystemManagementViewModel();
            _createBook = new CreateBookViewModel();
            _modelingManagement = new ModelingManagementViewModel();
            _modelingSettings = new ModelingSettingsViewModel();
        }        
    }
}
