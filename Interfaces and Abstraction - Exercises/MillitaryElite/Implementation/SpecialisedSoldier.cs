using MillitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Implementation
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public Corps Corps { get; set; }
    }
}
