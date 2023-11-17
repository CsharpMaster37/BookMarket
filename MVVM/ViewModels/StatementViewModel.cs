﻿using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookMarket.MVVM.ViewModels
{
    public class StatementViewModel : ViewModelBase
    {
        public Visibility _statementVisibility { get; set; } = Visibility.Hidden;
    }
}
