﻿using BookMarket.MVVM.Model.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model
{
    public interface IAssortment
    {
        void Add(Book item,int count);
        void Buy(int item);
    }
}
