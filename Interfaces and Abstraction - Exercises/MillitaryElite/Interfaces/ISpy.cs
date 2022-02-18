using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Interfaces
{
    public interface ISpy : ISoldier
    {
        public int CodeNumber { get; set; }
    }
}
