using BookMarket.MVVM.Model.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model
{
    public class Market
    {
        public AssortmentBooks _assortmentBooks;
        private readonly HashSet<int> unique;
        private Random random;
        public Market()
        {
            _assortmentBooks = new AssortmentBooks();
            unique = new HashSet<int>();
            random = new Random();
        }


        public void AddBook(Book book, int count)
        {
            _assortmentBooks.Add(book, count);
            if (count <= 3)
                App._statement.Add(book, random.Next(1,5), random.Next(1,15));
        }

        public bool BuyBook(int idxbook, User user)
        {
            if (_assortmentBooks._assortment[idxbook].Count > 0)
            {
                _assortmentBooks.Buy(idxbook);
                App._history.Add(_assortmentBooks._assortment[idxbook], user);
                if(_assortmentBooks._assortment[idxbook].Count <=3)
                    App._statement.Add(_assortmentBooks._assortment[idxbook], random.Next(1, 5), random.Next(1, 15));
                return true;
            }
            else
            {
                if(user is null || user.Communication == "" || user.Username == "")
                    App._requests.Add(_assortmentBooks._assortment[idxbook], null, idxbook);
                else
                    App._requests.Add(_assortmentBooks._assortment[idxbook], user, idxbook);
                return false;
            }
        }

        public bool BuyBook_ForModeling(int idxbook, User user,int lower_threeshold, int upper_threeshold, int lower_TimeDelivery, int upper_TimeDelivery)
        {
            if (_assortmentBooks._assortment[idxbook].Count > 0)
            {
                _assortmentBooks.Buy(idxbook);
                App._history.Add(_assortmentBooks._assortment[idxbook], user);
                if (_assortmentBooks._assortment[idxbook].Count <= random.Next(lower_threeshold, upper_threeshold))
                    App._statement.Add(_assortmentBooks._assortment[idxbook], random.Next(lower_TimeDelivery, upper_TimeDelivery), random.Next(5,10));
                return true;
            }
            else
            {
                App._requests.Add(_assortmentBooks._assortment[idxbook], user, idxbook);
                return false;
            }
        }

        public void Generation(int countType)
        {
            Random rd = new Random();
            int index;
            for (int i = 0; i < countType; i++)
            {
                while (true)
                {
                    index = rd.Next(0, App.ArrayGenerate.Count - 1);
                    if (!unique.Contains(index)) { unique.Add(index); break; }
                }
                string[] element = App.ArrayGenerate[index];
                AddBook(new Book(element[0], element[1], element[2], int.Parse(element[3]), int.Parse(element[4]), element[5], element[6], int.Parse(element[7])), rd.Next(1, 15));
            }
        }
    }
}
