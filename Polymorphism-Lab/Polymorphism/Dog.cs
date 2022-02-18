using System;

namespace Polymorphism
{
    public class Dog : Mammal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof Woof");
        }

        public override void Move()
        {
            Console.WriteLine("Running...");
        }

        public void TailWag()
        {
            Console.WriteLine("Wagging my tail from happiness!");
        }
    }
}
