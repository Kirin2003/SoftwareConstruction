using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    internal class MoneyComparator : IComparer<Order>
    {
        public int Compare(Order x, Order y)
        {
            return (int)(x.TotalPrice - y.TotalPrice);
        }
    }
}
