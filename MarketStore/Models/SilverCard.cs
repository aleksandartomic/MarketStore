using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class SilverCard : Card
    {
        public override decimal GetDiscountRate()
        {
            if (Turnover >= 300)
            {
                return DiscountRate = 3.5m;
            }

            return DiscountRate = 2;
        }
    }
}
