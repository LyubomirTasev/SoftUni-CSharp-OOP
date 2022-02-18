using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            Team team = new Team("Zvezda");

            for (int i = 0; i < lines; i++)
            {
                try
                {
                    string[] personsInfo = Console.ReadLine().Split();
                    string firstName = personsInfo[0];
                    string lastName = personsInfo[1];
                    int age = int.Parse(personsInfo[2]);
                    decimal salary = decimal.Parse(personsInfo[3]);

                    Person person = new Person(firstName, lastName, age, salary);
                    people.Add(person);

                    foreach (Person p in people)
                    {
                        team.AddPlayer(p);
                    }
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }

            }

            decimal percentage = decimal.Parse(Console.ReadLine());

            people.ForEach(p => p.IncreaseSalary(percentage));
            people.ForEach(p => Console.WriteLine(p));




            //foreach (var person in people)
            //{
            //    Console.WriteLine(person);
            //}

            //people.OrderBy(x => x.FirstName)
            //    .ThenBy(x => x.Age)
            //    .ToList()
            //.ForEach(p => Console.WriteLine(p)); ОТ ПЪРВА ЗАДАЧА


        }
    }
}
