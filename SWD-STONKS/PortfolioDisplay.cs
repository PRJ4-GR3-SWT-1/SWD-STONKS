using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_STONKS
{
    class PortfolioDisplay : IObserver
    {
        private List<Portfolio> portfolios = new List<Portfolio>();

        public void Update(StockSubject sub)
        {
            foreach (var port in portfolios)
            {
                foreach (Stock stonk in port.StockList)
                {
                    Console.WriteLine($"{0}: {1}", stonk.Name, stonk.Value);
                }
            }
        }

        public void AddPortfolio(Portfolio port)
        {
            portfolios.Add(port);
        }
    }
}
