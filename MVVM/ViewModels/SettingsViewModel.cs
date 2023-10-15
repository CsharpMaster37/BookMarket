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
    }
}
