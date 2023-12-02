﻿using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.ViewModels
{
    public class StatisticControlViewModel : ViewModelBase
    {
        public int Profit { get; set; }
        public int ReceivedOrdersStatisticCount { get; set; }
        public int ProcessedOrdersStatisticCount { get; set; }
        public int CompletedApplicationsPublisherStatisticCount { get; set; }
        public int DayPassedCount { get; set; }
    }
}
