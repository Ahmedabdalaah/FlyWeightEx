using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightEx
{
    internal class DiscountCalculate
    {
        public IDiscount GetDiscountCalc(string type )
        {
            IDiscount discount = null;
            Dictionary<string, IDiscount> clculatelist = new Dictionary<string, IDiscount>();
            if (clculatelist.ContainsKey(type))
            {
                return clculatelist[type];
            }
            else
            {
                switch (type)
                {
                    case "day":
                        discount = new DiscountDay();
                        clculatelist.Add("day", discount);
                        break;
                    case "item":
                        discount = new ItemDiscount();
                        clculatelist.Add("item", discount);
                        break;
                }
                return discount;
            }
        }
    }
}
