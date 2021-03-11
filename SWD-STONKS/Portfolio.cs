using System.Collections.Generic;

namespace SWD_STONKS
{
    public class Portfolio :IObserver
    {
        public List<Stock> StockList = new List<Stock>();
        public void Update(StockSubject su)
        {
            for (int i = 0; i < StockList.Count; i++)
            {
                totalValue += StockList[i].Value;
            }
        }

        public void AddStockToPortfolio(Stock stock)
        {
            StockList.Add(stock);
        }

        private double totalValue;
        public double TotalValue { get; }
    }
}