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
    public class GenerationModelingService : IGeneration
    {
        private Random random = new Random();
        public List<string[]> data = new List<string[]>();
        public List<User> list_users;
        public GenerationModelingService(ref List<User> list) 
        {
            Generation_DataForUsers();
            list_users = list;
        }
        public User Generation_User()
        {
            int Choose = random.Next(1, 5);
            if (list_users.Count > 0 && ((Choose <= 3) || list_users.Count >= (App._modelingManagement.modelingService.CountBooks)/2))
            {
                int Choose_User = random.Next(0, list_users.Count-1);
                return list_users[Choose_User];
            }
            else
            {
                return Create_User();
            }
        }
        public void Generation_DataForUsers()
        {
            StreamReader sr = new StreamReader("../../Users.txt");
            while (!sr.EndOfStream)
            {
               data.Add(sr.ReadLine().Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries));
            }
        }
        public User Create_User()
        {
            int qTry = 0;
            while(true)
            {
                int choose_index = random.Next(0,data.Count-1);
                User user = new User(data[choose_index][0], data[choose_index][1]);
                if(!list_users.Contains(user) || qTry > 10)
                    return user;
                qTry++;
            }
        }
        public bool Generation_Buy(User user, int lower_threeshold, int upper_threeshold, int lower_TimeDelivery, int upper_TimeDelivery)
        {
            int randomBook = random.Next(0, App._market._assortmentBooks._assortment.Count);
            App._modelingManagement.modelingService.ReceivedOrders++;
            bool flag = false;
            Application.Current.Dispatcher.Invoke(() => { flag = App._market.BuyBook_ForModeling(randomBook, user,lower_threeshold,upper_threeshold,lower_TimeDelivery,upper_TimeDelivery); });
            return flag;
        }
    }
}
