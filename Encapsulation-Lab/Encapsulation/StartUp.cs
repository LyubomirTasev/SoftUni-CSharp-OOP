using System;

namespace Encapsulation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 23;
            Console.WriteLine(person.Age);

            person.Age = 200;
            Console.WriteLine(person.Age);
        }
    }
}
