using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.ViewModels
{
    internal class ChoosePageViewModel
    {
        public bool btn1 { get; set; }
        public bool btn2 { get; set; }
        public bool btn3 { get; set; }
        public bool btn4 { get; set; }
        public RelayCommand RadioButton_Category
        {
            get
            {
                return new RelayCommand((obj) =>
                {

                    if (btn1)
                    {
                        
                    }
                    else if(btn2)
                    {
                        
                    }
                    else if (btn3)
                    {
                        
                    }
                    else if (btn4)
                    {
                        
                    }
                });
            }
        }
    }
}
