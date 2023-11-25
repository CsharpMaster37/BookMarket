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
            CreateArrayForGenerate();

        }
        private static void CreateArrayForGenerate()
        {
            StreamReader sr = new StreamReader("FileGenerate.txt");
            while (!sr.EndOfStream)
                ArrayGenerate.Add(sr.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
