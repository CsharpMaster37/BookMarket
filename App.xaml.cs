using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using BookMarket.MVVM.Model;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using BookMarket.MVVM.ViewModels;
using BookMarket.MVVM.View.UserControls;
using System.Web.UI;
using BookMarket.MVVM.Model.Interfaces;

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
        public static List<string[]> ArrayGenerate { get; set; }
        public static ListBooksViewModel _listBooks { get; set; }
        public static StatementViewModel _statement { get; set; }
        public static HistoryViewModel _history { get; set; }
        public static RequestsViewModel _requests { get; set; }
        public static BookInformationViewModel _bookInformation { get; set; }
        public static BuyBookViewModel _buyBook { get; set; }
        public static StatisticControlViewModel _statistic { get; set; }
        public static ShowMessageBox _messageBox { get; set; }
        public static IDataBookGeneration dataBookGeneration { get; set; }
        static App()
        {
            _market = new Market();
            _systemManagement = new SystemManagementViewModel();
            _createBook = new CreateBookViewModel();
            _modelingManagement = new ModelingManagementViewModel();
            _modelingSettings = new ModelingSettingsViewModel();
            _listBooks = new ListBooksViewModel();
            ArrayGenerate = new List<string[]>();
            _statement = new StatementViewModel();
            _history = new HistoryViewModel();
            _requests = new RequestsViewModel();
            _bookInformation = new BookInformationViewModel();
            _buyBook = new BuyBookViewModel();
            _statistic = new StatisticControlViewModel();
            _messageBox = new ShowMessageBox();
            dataBookGeneration = new DataBookGeneration();
            dataBookGeneration.CreateArrayForGenerateBook(ArrayGenerate);

        }
        public static void Error_MessageBox(string message)
        {
            _messageBox.Message = message;
            _messageBox.MsgBoxVisibility = Visibility.Visible;
        }
    }
}
