using BookMarket.MVVM.Model.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model
{
    public class AssortmentBooks : IAssortment
    {
        private readonly Dictionary<Book,int> _assortmentBooks;
        public AssortmentBooks()
        {
            _assortmentBooks = new Dictionary<Book,int>();
        }
        
        public IEnumerable<Book> GetBooksForUser(User user)
        {
            return _assortmentBooks.Keys.Where(x => x.User == user);
        }

        public void Add(IElements book)
        {
            try
            {
                _assortmentBooks.Add((Book)book, 1);
            }
            catch
            {
                _assortmentBooks[(Book)book]++;
            }
        }

        public void Buy(IElements book)
        {
            _assortmentBooks[(Book)book]--;
        }
    }
}
