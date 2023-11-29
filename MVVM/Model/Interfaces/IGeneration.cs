using BookMarket.MVVM.Model.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model.Interfaces
{
    public interface IGeneration
    {
        User Generation_User();
        User Create_User();
        void Generation_DataForUsers();
        void Generation_Buy(User user);
    }
}
