﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Interfaces
{
    public interface IPrivate : ISoldier
    {
        public decimal Salary { get; set; }
    }
}
