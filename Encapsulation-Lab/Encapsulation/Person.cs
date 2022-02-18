using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (age < 0 || age > 130)
                {
                    throw new ArgumentException($"{value} is not a valid person age");
                }
                else
                {
                    age = value;
                }
            }
        }

    }
}
