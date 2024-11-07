using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rinnbo
{
    internal class Data
    {
        public static List<StockPrice> GetStocks()
        {
            Random random = new Random(DateTime.Now.GetHashCode());
            double randomPrice()
            {
                return random.Next(-30, 70)/10.0;
            }
            List<StockPrice> stocks = new List<StockPrice>();
            DateTime startTime = new DateTime(2024, 11, 7, 9, 0, 0);
            double price = 30;
            for (int i = 0; i < 1000; i++)
            {
                stocks.Add(new StockPrice
                {
                    DealTime = startTime.AddMinutes(i),
                    Price = price +randomPrice()
                });
            }
            return stocks;
        }
    }
    
}
