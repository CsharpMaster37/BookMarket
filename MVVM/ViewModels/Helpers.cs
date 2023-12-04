using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookMarket.MVVM.ViewModels
{
    public class Helpers
    {

        public static void Block_Button_for_Modeling(bool key)
        {
            App._systemManagement.IsEnabled_Add = key;
            App._systemManagement.IsEnabled_Clear = key;
            App._systemManagement.IsEnabled_Generate = key;
            App._modelingManagement.IsEnabled_Start = key;
            App._modelingManagement.IsEnabled_Settings = key;
            App._modelingManagement.IsEnabled_Reset = key;
        }
        public static void CloseSettings()
        {
            if(App._modelingSettings._visibility == Visibility.Visible)
                        App._modelingSettings._visibility = Visibility.Hidden;
        }
        public static void CloseCreate()
        {
            if (App._createBook._visibility == Visibility.Visible)
                App._createBook._visibility = Visibility.Hidden;
            if(App._messageBox.MsgBoxVisibility == Visibility.Visible)
                App._messageBox.MsgBoxVisibility = Visibility.Hidden;
        }
        public static void Synchronization_Button()
        {
            CloseSettings();
            CloseCreate();
        }
        public static void GenerateButton()
        {
            if (App._systemManagement._visibility_count == Visibility.Visible)
                App._systemManagement._visibility_count = Visibility.Hidden;
            else
                App._systemManagement._visibility_count = Visibility.Visible;

            if (App._systemManagement._visibility_count_button == Visibility.Visible)
                App._systemManagement._visibility_count_button = Visibility.Hidden;
            else
                App._systemManagement._visibility_count_button = Visibility.Visible;
        }

        public static void Synchronization_Info()
        {
            App._bookInformation.CloseInfo();
            App._buyBook.CloseBuy();
        }

    }
}
