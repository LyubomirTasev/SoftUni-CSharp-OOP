using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal animal = new Person();
            animal.Move();



            //if (animal is Dog dog) // is Type pattern
            //{
            //    dog.TailWag();
            //}
        }
    }
}
