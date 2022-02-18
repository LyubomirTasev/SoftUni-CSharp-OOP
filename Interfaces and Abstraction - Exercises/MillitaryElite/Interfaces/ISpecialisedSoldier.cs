using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Interfaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
        public Corps Corps { get; set; }
    }
}
