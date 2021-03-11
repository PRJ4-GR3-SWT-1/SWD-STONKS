using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_STONKS
{
    class PortfolioDisplay : IObserver
    {
        private List<Portfolio> portfolios = new List<Portfolio>();

        public PortfolioDisplay(Portfolio port)
        {
            portfolios.Add(port);
            foreach (Stock stonk in port.StockList)
            {
                stonk.Attach(this);
            }
        }
        public void attachSubject(Portfolio port)
        {
            foreach (Stock stonk in port.StockList)
            {
                stonk.Attach(this);
            }
        }

        public void Update(StockSubject sub)
        {
            foreach (var port in portfolios)
            {
                foreach (Stock stonk in port.StockList)
                {
                    Console.WriteLine($"{stonk.Name}: {stonk.Value}");
                }
            }
        }

        public void AddPortfolio(Portfolio port)
        {
            portfolios.Add(port);
        }
    }
}
