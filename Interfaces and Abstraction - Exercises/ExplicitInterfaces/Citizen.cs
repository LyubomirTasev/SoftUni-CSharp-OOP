using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        string IResident.GetName()
        {
            return $"{Name}";
        }

        string IPerson.GetName()
        {
            return $"Mr/Ms/Mrs {Name}";
        }
        public override string ToString()
        {
            return $"{(this as IResident).GetName()}{Environment.NewLine}{(this as IPerson).GetName()}";
        }
                    
    }
}
