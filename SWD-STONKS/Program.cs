using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace SWD_STONKS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stock s1 = new Stock("Vestas", 100);
            Stock s2 = new Stock("Pandora", 20);

            Portfolio po = new Portfolio();
            po.AddStockToPortfolio(s1).AddStockToPortfolio(s2).AddStockToPortfolio(s2);
            PortfolioDisplay PD = new PortfolioDisplay(po);
            Console.WriteLine("Current portfolio value: " + po.TotalValue);

            s1.Value = 200;

            s2.Value = 33;
            
            

            s1.Value = 111;

        }
    }
}
