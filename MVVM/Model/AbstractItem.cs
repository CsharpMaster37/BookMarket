using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model
{
    public abstract class AbstractItem
    {
        public int Price { get; set; }
        public int RetailMargin { get; set; }
        public int DemandRating { get; set; }
    }
}
