﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class HotBeverage : Beverage
    {
        public HotBeverage(string name, decimal price, double milimeters)
            : base(name, price, milimeters)
        {
        }
    }
}
