using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookMarket.MVVM.ViewModels
{
    public static class Helpers
    {
        public static Visibility ToggleVisibility(Visibility element)
        {
            if (element == Visibility.Visible) { return Visibility.Hidden; }
            else return Visibility.Visible;
        }
    }
}
