using System;

namespace ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputInfo = input.Split();
                string name = inputInfo[0];
                string country = inputInfo[1];
                int age = int.Parse(inputInfo[2]);

                Citizen citizen = new Citizen(name, age, country);
                Console.WriteLine(citizen);
            }
        }
    }
}
