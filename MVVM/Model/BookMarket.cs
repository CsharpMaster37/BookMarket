﻿using BookMarket.MVVM.Model.Books;
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
            App._listBooks.ListBooks.Add(book);
            if (count <= 3)
                App._statement.Add(book, random.Next(1,5), random.Next(1,15)); //ToDo: Выправить метод под Modeling
        }

        public void BuyBook(int idxbook, User user)
        {
            if (_assortmentBooks._assortment[idxbook].Count > 0)
            {
                _assortmentBooks.Buy(idxbook);
                App._history.Add(_assortmentBooks._assortment[idxbook], user);
            }
            else
            {
                if(user.Communication != "" && user.Username != "")
                    App._requests.Add(_assortmentBooks._assortment[idxbook], user);
                else
                    App._requests.Add(_assortmentBooks._assortment[idxbook], null);
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
