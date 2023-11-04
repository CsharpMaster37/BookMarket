﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model
{
    public interface IAssortment
    {
        void Add(AbstractItem item);
        void Buy(AbstractItem item);
    }
}
