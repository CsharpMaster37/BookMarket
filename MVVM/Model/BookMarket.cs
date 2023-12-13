using BookMarket.MVVM.Model.Books;
using BookMarket.MVVM.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model
{
    public class Market
    {
        public IAssortment _assortmentBooks;
        private readonly HashSet<int> unique;
        private Random random;
        public IDataBookGeneration dataBookGeneration;
        public Market()
        {
            dataBookGeneration = new DataBookGeneration();
            _assortmentBooks = new AssortmentBooks();
            unique = new HashSet<int>();
            random = new Random();
        }


        public void AddBook(Book book, int count)
        {
            if (_assortmentBooks.Add(book, count) && count <= 3)
                App._statement.Add(book, random.Next(1,5), random.Next(1,15));
        }

        public bool BuyBook(int idxbook, User user)
        {
            if (_assortmentBooks.GetAssortment()[idxbook].Count > 0)
            {
                _assortmentBooks.Buy(idxbook);
                App._history.Add(_assortmentBooks.GetAssortment()[idxbook], user);
                if(_assortmentBooks.GetAssortment()[idxbook].Count <=3)
                    App._statement.Add(_assortmentBooks.GetAssortment()[idxbook], random.Next(1, 5), random.Next(1, 15));
                return true;
            }
            else
            {
                if(user is null || user.Communication == "" || user.Username == "")
                    App._requests.Add(_assortmentBooks.GetAssortment()[idxbook], null, idxbook);
                else
                    App._requests.Add(_assortmentBooks.GetAssortment()[idxbook], user, idxbook);
                return false;
            }
        }

        public bool BuyBook_ForModeling(int idxbook, User user,int lower_threeshold, int upper_threeshold, int lower_TimeDelivery, int upper_TimeDelivery)
        {
            if (_assortmentBooks.GetAssortment()[idxbook].Count > 0)
            {
                _assortmentBooks.Buy(idxbook);
                App._history.Add(_assortmentBooks.GetAssortment()[idxbook], user);
                if (_assortmentBooks.GetAssortment()[idxbook].Count <= random.Next(lower_threeshold, upper_threeshold))
                    App._statement.Add(_assortmentBooks.GetAssortment()[idxbook], random.Next(lower_TimeDelivery, upper_TimeDelivery), random.Next(5,10));
                return true;
            }
            else
            {
                App._requests.Add(_assortmentBooks.GetAssortment()[idxbook], user, idxbook);
                return false;
            }
        }

        public void Generation(int countType) => dataBookGeneration.Generation(countType, unique);
    }
}
