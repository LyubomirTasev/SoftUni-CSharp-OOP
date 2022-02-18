using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<DemoClass> people = new List<DemoClass>();
            Team team = new Team("G Unit");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] personsInfo = Console.ReadLine().Split();
                string firstName = personsInfo[0];
                string lastName = personsInfo[1];
                int age = int.Parse(personsInfo[2]);
                decimal salary = decimal.Parse(personsInfo[3]);

                DemoClass person = new DemoClass(firstName, lastName, age, salary);
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

            //decimal percentage = decimal.Parse(Console.ReadLine());

            //foreach (DemoClass person in people)
            //{
            //    person.IncreaseSalary(percentage);
            //}

            //foreach (DemoClass person in people/*.OrderBy(p => p.FirstName).ThenBy(p => p.Age)*/)
            //{
            //    Console.WriteLine(person);
            //}
        }
    }
}
