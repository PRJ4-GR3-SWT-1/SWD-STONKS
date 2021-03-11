using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace SWD_STONKS
{
    public class Stock : StockSubject
    {
        public string Name { get; set; }

        private double stockValue;
        public double Value
        {
            get
            {
                return stockValue;
            }
            set
            {
                stockValue = value;
                Notify();
            }
        }

        public Stock(string name, double value)
        { 
            Value = value;
            Name = name;
        }



       
    }
}