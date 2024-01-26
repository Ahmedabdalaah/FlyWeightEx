using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightEx
{
    internal class ItemDiscount : IDiscount
    {
        public double GetDiscount(DateTime date)
        {
            // call data from database
            return 0.15;
        }
    }
}
