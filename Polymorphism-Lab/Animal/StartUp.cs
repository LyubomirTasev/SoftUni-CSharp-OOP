using System;

namespace Animals
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Sashko", "Cat food");
            Animal cat = new Cat("Mirka", "Dog food");

            Console.WriteLine(dog.ExplainSelf());
            Console.WriteLine(cat.ExplainSelf());
        }
    }
}
