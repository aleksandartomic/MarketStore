using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public abstract class Card
    {
        public decimal Turnover { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal PurchaseValue { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public abstract decimal GetDiscountRate();

        public decimal TotalCalculate()
        {
            return Total = PurchaseValue - Discount;
        }

        public decimal DiscountCalculate()
        {
            return Discount = PurchaseValue * DiscountRate / 100;
        }
    }
}
