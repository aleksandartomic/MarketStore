using System;
using System.Text;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            BronzeCard bronzeCard = new BronzeCard()
            {
                Turnover = 0,
                PurchaseValue = 150
            };

            SilverCard silverCard = new SilverCard()
            {
               Turnover = 600,
                PurchaseValue = 850
            };

            GoldCard goldCard = new GoldCard()
            {
                Turnover = 1500,
                PurchaseValue = 1300
            };

            Console.WriteLine("1.Bronze");
            Console.WriteLine(FormatString(bronzeCard));
            Console.WriteLine("2.Silver");
            Console.WriteLine(FormatString(silverCard));
            Console.WriteLine("3.Gold");
            Console.WriteLine(FormatString(goldCard));
        }

        public static string FormatString(Card card)
        {
            var result = new StringBuilder();
            result.AppendLine($"Purchase value: ${card.PurchaseValue}");
            result.AppendLine($"Discount rate: {card.GetDiscountRate()}%");
            result.AppendLine($"Discount: ${card.DiscountCalculate()}");
            result.AppendLine($"Total: ${card.TotalCalculate()}");

            return result.ToString();
        }
    }
}
