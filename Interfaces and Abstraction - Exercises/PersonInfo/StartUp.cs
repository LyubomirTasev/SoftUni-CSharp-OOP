using System;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string iD = Console.ReadLine();
            string birthDate = Console.ReadLine();

            IIdentifiable identifiable = new Citizen(name, age, iD, birthDate);
            IBirthable birthable = new Citizen(name, age, iD, birthDate);

            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);
        }
    }
}
