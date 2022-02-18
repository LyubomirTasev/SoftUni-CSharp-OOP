using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Interfaces
{
    public interface IRepair
    {
        public string PartName { get; set; }
        public int HoursWorked { get; set; }
    }
}
