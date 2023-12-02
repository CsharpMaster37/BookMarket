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
        public List<Book> _assortment;
        public AssortmentBooks()
        {
            _assortment = new List<Book>();
        }
        

        public void Add(Book book,int count)
        {
            int idx = _assortment.IndexOf(book);
            if(idx == -1)
            {
                _assortment.Add(book);
                _assortment[_assortment.Count - 1].Count += count;
                App._listBooks.ListBooks.Add(book);
            }
            else
                _assortment[idx].Count += count;
        }

        public void Buy(int idxbook)
        {
            _assortment[idxbook].Count--;
        }
    }
}
