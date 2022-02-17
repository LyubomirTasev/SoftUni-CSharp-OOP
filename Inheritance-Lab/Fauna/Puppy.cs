using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weep weep");
        }

        public override void Bark()
        {
            Console.WriteLine("I'm too young to bark.");
        }
    }
}
