using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class GoldCard : Card
    {
        public override decimal GetDiscountRate()
        {
            DiscountRate = 2;

            while (Turnover >= 100)
            {
                DiscountRate += 1;
                Turnover -=100;

                if (DiscountRate == 10)
                {
                    return 10;
                }
            }

            return DiscountRate;
        }
    }
}
