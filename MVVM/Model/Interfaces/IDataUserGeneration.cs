using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model.Interfaces
{
    public interface IDataUserGeneration
    {
        void Generation_DataForUsers(List<string[]> data);
        User Generation_User(List<string[]> data, List<User> list_users);
        User Create_User(List<string[]> data, List<User> list_users);
    }
}
