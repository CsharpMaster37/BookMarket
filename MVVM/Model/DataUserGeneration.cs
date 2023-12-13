using BookMarket.MVVM.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model
{
    public class DataUserGeneration : IDataUserGeneration
    {
        private Random random = new Random();
        public void Generation_DataForUsers(List<string[]> data)
        {
            StreamReader sr = new StreamReader("../../Users.txt");
            while (!sr.EndOfStream)
            {
                data.Add(sr.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
            }
        }
        public User Generation_User(List<string[]> data, List<User> list_users)
        {
            int Choose = random.Next(1, 5);
            if (list_users.Count > 0 && ((Choose <= 3) || list_users.Count >= (App._modelingManagement.modelingService.CountBooks) / 2))
            {
                int Choose_User = random.Next(0, list_users.Count - 1);
                return list_users[Choose_User];
            }
            else
            {
                return Create_User(data, list_users);
            }
        }
        public User Create_User(List<string[]> data, List<User> list_users)
        {
            int qTry = 0;
            while (true)
            {
                int choose_index = random.Next(0, data.Count - 1);
                User user = new User(data[choose_index][0], data[choose_index][1]);
                if (!list_users.Contains(user) || qTry > 10)
                    return user;
                qTry++;
            }
        }
    }
}
