using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model
{
    public class User
    {
        public string Username { get;}
        public string Communication { get;}
        public User(string username, string communication)
        {
            Username = username;
            Communication = communication;
        }
        public static bool operator ==(User user1, User user2)
        {
            return user1.Equals(user2);
        }
        public static bool operator !=(User user1, User user2)
        {
            return !user1.Equals(user2);
        }
        public override bool Equals(object obj)
        {
            return obj is User user &&
                Username == user.Username;
        }
        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }
    }
}
