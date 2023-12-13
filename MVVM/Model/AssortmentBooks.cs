using BookMarket.MVVM.Model.Books;
using DevExpress.Mvvm.Native;
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
        private List<Book> _assortment;
        public AssortmentBooks()
        {
            _assortment = new List<Book>();
        }
        
        public List<Book> GetAssortment()
        {
            return _assortment;
        }
        public bool Add(Book book,int count)
        {
            int idx = _assortment.IndexOf(book);
            if(idx == -1)
            {
                _assortment.Add(book);
                _assortment[_assortment.Count - 1].Count += count;
                App._listBooks.ListBooks.Add(book);
                return true;
            }
            else
            {
                _assortment[idx].Count += count;
                return false;
            }
        }

        public void Buy(int idxbook)
        {
            _assortment[idxbook].Count--;
        }
    }
}
