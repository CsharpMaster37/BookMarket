using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BookMarket.MVVM.ViewModels
{
    class SettingsViewModel : ViewModelBase
    {
        #region Retail
        private int _retail;
        public int Retail
        {
            get { return _retail; }
            set
            {
                if (value >= 0)
                {
                    _retail = value;
                }
                else
                {
                    _retail = 0;
                }
                RaisePropertyChanged(() => Retail);
            }
        }

        public RelayCommand ClickAddRetail
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    Retail++;
                });
            }
        }

        public RelayCommand ClickSubRetail
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    Retail--;
                });
            }
        }
        #endregion

        #region NewBooks
        private int _newbooks;
        public int NewBooks
        {
            get { return _newbooks; }
            set 
            {
                if (value >= 0)
                {
                    _newbooks = value;
                }
                else
                {
                    _newbooks = 0;
                }
                RaisePropertyChanged(() => NewBooks);
            }
        }
        public RelayCommand ClickAddNewBooks
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    NewBooks++;
                });
            }
        }

        public RelayCommand ClickSubNewBooks
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    NewBooks--;
                });
            }
        }
        #endregion

        #region Modeling Step Range

        //Для значений левого ползунка
        static private int _left_ModelingStep = 1;
        public int ModelingStep_Left
        {
            get { return _left_ModelingStep; }
            private set
            {
                _left_ModelingStep = value;
                RaisePropertyChanged(() => ModelingStep_Left);
            }
        }

        private int _lowervalue_ModelingStep = _left_ModelingStep;
        public int ModelingStep_Lower
        {
            get { return _lowervalue_ModelingStep; }
            set
            {
                _lowervalue_ModelingStep = value;
                ModelingStep_Left = value;
                RaisePropertyChanged(() => ModelingStep_Lower);
            }
        }

        //Для значений правого ползунка
        static private int _right_ModelingStep = 3;
        public int ModelingStep_Right
        {
            get { return _right_ModelingStep; }
            private set
            {
                _right_ModelingStep = value;
                RaisePropertyChanged(() => ModelingStep_Right);
            }
        }

        private int _uppervalue_ModelingStep = _right_ModelingStep;
        public int ModelingStep_Upper
        {
            get { return _uppervalue_ModelingStep; }
            set
            {
                _uppervalue_ModelingStep = value;
                ModelingStep_Right = value;
                RaisePropertyChanged(() => ModelingStep_Upper);
            }
        }

        #endregion


        #region Delivery Time Range

        //Для значений левого ползунка
        static private int _left_DeliveryTime = 1;
        public int DeliveryTime_Left
        {
            get { return _left_DeliveryTime; }
            private set
            {
                _left_DeliveryTime = value;
                RaisePropertyChanged(() => DeliveryTime_Left);
            }
        }

        private int _lowervalue_DeliveryTime = _left_DeliveryTime;
        public int DeliveryTime_Lower
        {
            get { return _lowervalue_DeliveryTime; }
            set
            {
                _lowervalue_DeliveryTime = value;
                DeliveryTime_Left = value;
                RaisePropertyChanged(() => DeliveryTime_Lower);
            }
        }

        //Для значений правого ползунка
        static private int _right_DeliveryTime = 5;
        public int DeliveryTime_Right
        {
            get { return _right_DeliveryTime; }
            private set
            {
                _right_DeliveryTime = value;
                RaisePropertyChanged(() => DeliveryTime_Right);
            }
        }

        private int _uppervalue_DeliveryTime = _right_DeliveryTime;
        public int DeliveryTime_Upper
        {
            get { return _uppervalue_DeliveryTime; }
            set
            {
                _uppervalue_DeliveryTime = value;
                DeliveryTime_Right = value;
                RaisePropertyChanged(() => DeliveryTime_Upper);
            }
        }

        #endregion

        #region Threeshold Range

        //Для значений левого ползунка
        static private int _left_Threeshold = 3;
        public int Threeshold_Left
        {
            get { return _left_Threeshold; }
            private set
            {
                _left_Threeshold = value;
                RaisePropertyChanged(() => Threeshold_Left);
            }
        }

        private int _lowervalue_Threeshold = _left_Threeshold;
        public int Threeshold_Lower
        {
            get { return _lowervalue_Threeshold; }
            set
            {
                _lowervalue_Threeshold = value;
                Threeshold_Left = value;
                RaisePropertyChanged(() => Threeshold_Lower);
            }
        }

        //Для значений правого ползунка
        static private int _right_Threeshold = 5;
        public int Threeshold_Right
        {
            get { return _right_Threeshold; }
            private set
            {
                _right_Threeshold = value;
                RaisePropertyChanged(() => Threeshold_Right);
            }
        }

        private int _uppervalue_Threeshold = _right_Threeshold;
        public int Threeshold_Upper
        {
            get { return _uppervalue_Threeshold; }
            set
            {
                _uppervalue_Threeshold = value;
                Threeshold_Right = value;
                RaisePropertyChanged(() => Threeshold_Upper);
            }
        }

        #endregion

        #region Modeling period

        static private int _modeling_period_block = 20;
        public int Modeling_period_block
        {
            get { return _modeling_period_block;}
            set
            {
                _modeling_period_block = value;
                RaisePropertyChanged(() => Modeling_period_block);
            }
        }

        private int _modeling_period_slider = _modeling_period_block;
        public int Modeling_period_slider
        {
            get { return _modeling_period_slider; }
            set
            {
                _modeling_period_slider = value;
                Modeling_period_block = value;
                RaisePropertyChanged(() => Modeling_period_slider);
            }
        }
        #endregion

        #region Initial assortiment

        static private int _countbooks_block = 100;
        public int CountBooks_block
        {
            get { return _countbooks_block; }
            set
            {
                _countbooks_block = value;
                RaisePropertyChanged(() => CountBooks_block);
            }
        }

        private int _countbooks_slider = _countbooks_block;
        public int CountBooks_slider
        {
            get { return _countbooks_slider; }
            set
            {
                _countbooks_slider = value;
                CountBooks_block = value;
                RaisePropertyChanged(() => CountBooks_slider);
            }
        }
        #endregion
    }
}
