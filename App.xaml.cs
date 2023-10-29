using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using BookMarket.MVVM.Model;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BookMarket
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Market market = new Market();
            base.OnStartup(e);
        }
    }
}
