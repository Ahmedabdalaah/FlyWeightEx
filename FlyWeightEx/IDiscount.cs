using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightEx
{
    internal interface IDiscount
    {
        double GetDiscount(DateTime date);
    }
}
