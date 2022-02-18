using MillitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Implementation
{
    public abstract class Soldier : ISoldier
    {
        protected Soldier(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
