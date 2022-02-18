using System;

namespace Polymorphism
{
    public class Cat : Mammal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public override void Move()
        {
            Console.WriteLine("Sneaking...");
        }
    }
}
