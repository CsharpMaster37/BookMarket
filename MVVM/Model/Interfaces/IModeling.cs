using BookMarket.MVVM.Model.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model.Interfaces
{
    public interface IModeling
    {
        void Start_Modeling();
        void Check_Request();
        void Next_Day();
        void Step_Passed();
        void Success_Buy();
    }
}
