using System;

namespace Polymorphism
{
    public class Person : Mammal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Talking...");
        }

        public override void Move()
        {
            Console.WriteLine("Walking...");
        }
    }
}
