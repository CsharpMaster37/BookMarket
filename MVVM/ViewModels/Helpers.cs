using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.ViewModels
{
    public class Helpers
    {
        public static void CloseSettings()
        {
            if(App._modelingSettings._visibility == System.Windows.Visibility.Visible)
                        App._modelingSettings._visibility = System.Windows.Visibility.Hidden;
        }
        public static void CloseCreate()
        {
            if (App._createBook._visibility == System.Windows.Visibility.Visible)
                App._createBook._visibility = System.Windows.Visibility.Hidden;
        }
    }
}
