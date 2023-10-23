using BookMarket.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookMarket
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Settings.Content = new SettingsPage();
            ListBooks.Content = new ListBooksPage();
            Orders.Content = new OrderPage();
            SalesHistory.Content = new SalesHistoryPage();
            PurchaseRequests.Content = new PurchaseRequestsPage();
            Information.Content = new InformationPage();
            Statistics.Content = new StatisticsPage();
        }
        private void Drag(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e) => this.WindowState = WindowState.Minimized;

    }
}
