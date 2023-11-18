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
        public readonly AssortmentBooks _assortmentBooks;
        private readonly HashSet<int> unique;
        public Market()
        {
            _assortmentBooks = new AssortmentBooks();
            unique = new HashSet<int>();
        }

        public IEnumerable<Book> GetBooksForUser(User user)
        {
            return _assortmentBooks.GetBooksForUser(user);
        }

        public void AddBook(Book book, int count)
        {
            _assortmentBooks.Add(book, count);
            App._listBooks.ListBooks.Add(book);
            if (count < 10)
                App._statement.Add(book, 5, 10); //ToDo: Заглушка
            //BuyBook(book, null);
        }

        public void BuyBook(Book book, User user)
        {
            if (_assortmentBooks._assortment[book] > 0) //ToDo: Сделать метод
            {
                _assortmentBooks.Buy(book);
                App._history.Add(book, user);
            }
            else
            {
                App._requests.Add(book, user);
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
            App._listBooks.Update(_assortmentBooks._assortment.Keys.ToList());
        }
    }
}
