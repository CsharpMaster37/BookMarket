﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model.Interfaces
{
    public interface IStatement
    {
        bool DayPassed();
        void Done();
    }
}