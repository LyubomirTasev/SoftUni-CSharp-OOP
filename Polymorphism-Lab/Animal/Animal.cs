using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, string food)
        {
            Name = name;
            Food = food;
        }

        public string Name { get;}
        public string Food { get; }

        public virtual string ExplainSelf()
        {
            return $"Hi, I'm just an animal, what do you want me to do?";
        }
    }
}
