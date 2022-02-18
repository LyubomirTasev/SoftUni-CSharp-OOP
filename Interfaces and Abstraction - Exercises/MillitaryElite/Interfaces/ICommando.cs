using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        public List<IMission> Missions { get; set; }

        void CompleteMission(string codeName);
    }
}
