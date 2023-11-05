using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.ViewModels
{
    public class SystemManagementViewModel : ViewModelBase
    {
        public RelayCommand AddBookButton
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    App._createBook.View();
                });
            }
        }
    }
}
