using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookMarket.MVVM.ViewModels
{
    public class HistoryViewModel : ViewModelBase
    {
        public Visibility _historyVisibility { get; set; } = Visibility.Hidden;
    }
}
