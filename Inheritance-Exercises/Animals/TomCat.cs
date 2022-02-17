using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class TomCat : Cat
    {
        private const string DefaultGender = "Male";

        public TomCat(string name, int age)
            : base(name, age, DefaultGender)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
