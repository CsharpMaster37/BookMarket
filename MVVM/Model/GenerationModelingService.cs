using BookMarket.MVVM.Model.Books;
using BookMarket.MVVM.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.IO;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace BookMarket.MVVM.Model
{
    public class GenerationModelingService : IGenerationModeling
    {
        private Random random = new Random();
        public List<string[]> data = new List<string[]>();
        public List<User> list_users;
        public IDataUserGeneration dataUserGeneration;
        public GenerationModelingService(ref List<User> list) 
        {
            dataUserGeneration = new DataUserGeneration();
            dataUserGeneration.Generation_DataForUsers(data);
            list_users = list;
        }
        public User Generation_User() => dataUserGeneration.Generation_User(data, list_users);
        public bool Generation_Buy(User user, int lower_threeshold, int upper_threeshold, int lower_TimeDelivery, int upper_TimeDelivery)
        {
            int randomBook = random.Next(0, App._market._assortmentBooks.GetAssortment().Count);
            App._modelingManagement.modelingService.ReceivedOrders++;
            bool flag = false;
            Application.Current.Dispatcher.Invoke(() => { flag = App._market.BuyBook_ForModeling(randomBook, user,lower_threeshold,upper_threeshold,lower_TimeDelivery,upper_TimeDelivery);});
            return flag;
        }
    }
}
