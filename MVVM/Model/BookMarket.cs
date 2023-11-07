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
        public Market()
        {
            _assortmentBooks = new AssortmentBooks();
        }

        public IEnumerable<Book> GetBooksForUser(User user)
        {
            return _assortmentBooks.GetBooksForUser(user);
        }

        public void AddBook(Book book, int count)
        {
            _assortmentBooks.Add(book, count);
        }

        public void BuyBook(Book book)
        {
            _assortmentBooks.Buy(book);
        }
        public void Generation(int countType)
        {
            _assortmentBooks.Generation(countType);
        }
    }
}
