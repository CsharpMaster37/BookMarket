using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BookMarket.MVVM.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        private Visibility _framesettings = Visibility.Hidden;
        public Visibility FrameSettings
        {  
            get { return _framesettings; }
            set
            {
                _framesettings = value;
                RaisePropertyChanged(() => FrameSettings);
            }
        }
        public RelayCommand SettingsButton
        {
            get { return new RelayCommand((obj) => FrameSettings = Helpers.ToggleVisibility(FrameSettings)); }
        }

        //private bool _radioButton_Category1;
        //public bool RadioButton_Category1
        //{
        //    get { return _radioButton_Category1; }
        //    set
        //    {
        //        _radioButton_Category1 = value;
        //        RaisePropertyChanged(() => RadioButton_Category1);
        //    }
        //}


        //private bool _radioButton_Category2;
        //public bool RadioButton_Category2
        //{
        //    get { return _radioButton_Category2; }
        //    set
        //    {
        //        _radioButton_Category2 = value;
        //        RaisePropertyChanged(() => RadioButton_Category2);
        //    }
        //}


        //private bool _radioButton_Category3;
        //public bool RadioButton_Category3
        //{
        //    get { return _radioButton_Category3; }
        //    set
        //    {
        //        _radioButton_Category3 = value;
        //        RaisePropertyChanged(() => RadioButton_Category3);
        //    }
        //}


        //private bool _radioButton_Category4;
        //public bool RadioButton_Category4
        //{
        //    get { return _radioButton_Category4; }
        //    set
        //    {
        //        _radioButton_Category4 = value;
        //        RaisePropertyChanged(() => RadioButton_Category4);
        //    }
        //}


        public RelayCommand RadioButton_Category1
        {
            get { return new RelayCommand((obj) => Visibility_Category1 = Visibility.Visible); }
        }
        public RelayCommand RadioButton_Category2
        {
            get { return new RelayCommand((obj) => Visibility_Category2 = Visibility.Visible); }
        }
        public RelayCommand RadioButton_Category3
        {
            get { return new RelayCommand((obj) => Visibility_Category3 = Visibility.Visible); }
        }
        public RelayCommand RadioButton_Category4
        {
            get { return new RelayCommand((obj) => Visibility_Category4 = Visibility.Visible); }
        }

        private Visibility visibility_Category1 = Visibility.Visible;
        public Visibility Visibility_Category1
        {
            get { return visibility_Category1; }
            set
            {
                visibility_Category1 = value;
                if (visibility_Category1 == Visibility.Visible)
                {
                    Visibility_Category2 = Visibility.Hidden;
                    Visibility_Category3 = Visibility.Hidden;
                    Visibility_Category4 = Visibility.Hidden;
                }
                RaisePropertyChanged(() => Visibility_Category1);
            }
        }

        private Visibility visibility_Category2 = Visibility.Hidden;
        public Visibility Visibility_Category2
        {
            get { return visibility_Category2; }
            set
            {
                visibility_Category2 = value;
                if (visibility_Category2 == Visibility.Visible)
                {
                    Visibility_Category1 = Visibility.Hidden;
                    Visibility_Category3 = Visibility.Hidden;
                    Visibility_Category4 = Visibility.Hidden;
                }
                RaisePropertyChanged(() => Visibility_Category2);
            }
        }

        private Visibility visibility_Category3 = Visibility.Hidden;
        public Visibility Visibility_Category3
        {
            get { return visibility_Category3; }
            set
            {
                visibility_Category3 = value;
                if (visibility_Category3 == Visibility.Visible)
                {
                    Visibility_Category1 = Visibility.Hidden;
                    Visibility_Category2 = Visibility.Hidden;
                    Visibility_Category4 = Visibility.Hidden;
                }
                RaisePropertyChanged(() => Visibility_Category3);
            }
        }

        private Visibility visibility_Category4 = Visibility.Hidden;
        public Visibility Visibility_Category4
        {
            get { return visibility_Category4; }
            set
            {
                visibility_Category4 = value;
                if (visibility_Category4 == Visibility.Visible)
                {
                    Visibility_Category1 = Visibility.Hidden;
                    Visibility_Category2 = Visibility.Hidden;
                    Visibility_Category3 = Visibility.Hidden;
                }
                RaisePropertyChanged(() => Visibility_Category4);
            }
        }
    }
}
