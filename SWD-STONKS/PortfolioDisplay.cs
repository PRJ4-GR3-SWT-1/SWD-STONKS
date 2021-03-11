using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_STONKS
{
    class PortfolioDisplay : IObserver
    {
        private ICollection<Portfolio> portfolios;

        void public Update(Subject sub)
        {
            foreach (var port in portfolios)
            {
                Console.WriteLine($"{0}: {1}",port.Name,port.Price);
            }
        }
    }
}
