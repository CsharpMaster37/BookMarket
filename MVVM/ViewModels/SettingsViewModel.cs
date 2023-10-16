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
                    RaisePropertiesChanged();
                }
                else
                {
                    _retail = 0;
                    RaisePropertiesChanged();
                }
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
                if (Retail > 0)
                {
                    return new RelayCommand((obj) =>
                    {
                        Retail--;
                    });
                }
                return null;
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
                    RaisePropertiesChanged();
                }
                else
                {
                    _newbooks = 0;
                    RaisePropertiesChanged();
                }
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
                if (NewBooks > 0)
                {
                    return new RelayCommand((obj) =>
                    {
                        NewBooks--;
                    });
                }
                return null;
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
                RaisePropertiesChanged();
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
                RaisePropertiesChanged();
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
                RaisePropertiesChanged();
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
                RaisePropertiesChanged();
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
                RaisePropertiesChanged();
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
                RaisePropertiesChanged();
            }
        }

        #endregion
    }
}
