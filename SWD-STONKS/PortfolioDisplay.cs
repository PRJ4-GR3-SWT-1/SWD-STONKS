using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_STONKS
{
    class PortfolioDisplay : IObserver
    {
        private ICollection<Portfolio> portfolios;

        public void Update(Subject sub)
        {
            foreach (var port in portfolios)
            {
                foreach (Stock stonk in port.stocks)
                {
                    Console.WriteLine($"{0}: {1}", stonk.Name, stonk.Value);
                }
            }
        }
    }
}
