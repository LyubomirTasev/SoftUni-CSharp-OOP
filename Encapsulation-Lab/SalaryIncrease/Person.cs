using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryIncrease
{
    public class Person
    {
        private int age;

        private readonly string name;

        private readonly IReadOnlyCollection<string> nickNames;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 130)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException($"{value} is not a valid person age.");
                }
            }
        }
        public Person(int age)
        {
            Age = age;
        }
        public Person(int age, string name, params string[] nickNames)
            :this(age)
        {
            this.name = name;
            this.nickNames = new List<string>(nickNames);
        }

        
        public string GetName()
        {
            return name;
        }
    }
}
