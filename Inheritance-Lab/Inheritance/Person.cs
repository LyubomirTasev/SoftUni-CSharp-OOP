using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Sleep()
        {
            Console.WriteLine($"I'm a {this.GetType().Name} and I'm sleeping");
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
