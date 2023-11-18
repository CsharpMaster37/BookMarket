using BookMarket.MVVM.Model.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookMarket.MVVM.Model
{
    public class AssortmentBooks : IAssortment
    {
        public readonly Dictionary<Book,int> _assortment;
        public AssortmentBooks()
        {
            _assortment = new Dictionary<Book,int>();
        }
        
        public IEnumerable<Book> GetBooksForUser(User user)
        {
            return _assortment.Keys.Where(x => x.User == user);
        }

        public void Add(AbstractItem book,int count)
        {
            try
            {
                _assortment.Add((Book)book, count);
            }
            catch
            {
                _assortment[(Book)book] += count;
            }
        }

        public void Buy(AbstractItem book)
        {
            _assortment[(Book)book]--;
        }
    }
}
