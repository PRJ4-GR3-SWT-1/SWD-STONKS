﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace SWD_STONKS
{
    public class Stock : StockSubject
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Stock()
        {
        }


       
    }
}