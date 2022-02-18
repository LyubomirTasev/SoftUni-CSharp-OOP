using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Citizen> citizenBuyers = new List<Citizen>();
            List<Rebel> rebelBuyers = new List<Rebel>();

            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                string name = inputInfo[0];
                int age = int.Parse(inputInfo[1]);

                if (inputInfo.Length == 4)
                {
                    string id = inputInfo[2];
                    string birthdate = inputInfo[3];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    citizenBuyers.Add(citizen);
                }
                else if (inputInfo.Length == 3)
                {
                    string gang = inputInfo[2];

                    Rebel rebel = new Rebel(name, age, gang);
                    rebelBuyers.Add(rebel);
                }
            }

            string person = Console.ReadLine();

            while (person != "End")
            {
                Citizen currCitizen = citizenBuyers.FirstOrDefault(c => c.Name == person);
                Rebel currRebel = rebelBuyers.FirstOrDefault(r => r.Name == person);

                if (currCitizen != null)
                {
                    currCitizen.BuyFood();
                }
                else if (currRebel != null)
                {
                    currRebel.BuyFood();
                }

                person = Console.ReadLine();
            }

            Console.WriteLine(citizenBuyers.Sum(f => f.Food) + rebelBuyers.Sum(f => f.Food));
        }

        //public static void BirthdayCelebration()
        //{
        //    List<IBirthable> birthables = new List<IBirthable>();

        //    string input = Console.ReadLine();

        //    while (input != "End")
        //    {
        //        string[] inputInfo = input.Split();
        //        string title = inputInfo[0];

        //        switch (title)
        //        {
        //            case "Pet":
        //                string name = inputInfo[1];
        //                string birthday = inputInfo[2];

        //                Pet pet = new Pet(birthday, name);
        //                birthables.Add(pet);
        //                break;

        //            case "Citizen":
        //                string citizenName = inputInfo[1];
        //                int age = int.Parse(inputInfo[2]);
        //                string citizenId = inputInfo[3];
        //                string birthdate = inputInfo[4];

        //                Citizen citizen = new Citizen(citizenName, age, citizenId, birthdate);
        //                birthables.Add(citizen);
        //                break;
        //        }

        //        input = Console.ReadLine();
        //    }

        //    string year = Console.ReadLine();

        //    foreach (var birthable in birthables)
        //    {
        //        if (birthable.Birthday.EndsWith(year))
        //        {
        //            Console.WriteLine(birthable.Birthday);
        //        }
        //    }
        //}

        //public static void BorderControl()
        //{
        //    string input;
        //    List<IIdentifiable> detainedIDs = new List<IIdentifiable>();
        //     while ((input = Console.ReadLine()) != "End")                                               
        //     {                                                                                           
        //         string[] borderControlInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);   
        //         string name = borderControlInfo[0];                                                     
        //         switch (borderControlInfo.Length)
        //         {                                                                                       
        //             case 3:                                                                             
        //                 int age = int.Parse(borderControlInfo[1]);                                      
        //                 string id = borderControlInfo[2];                                               
        //                 Citizen currCitizen = new Citizen(name, age, id);                              
        //                 detainedIDs.Add(currCitizen);                                                   
        //                 break;                                                                          
        //             case 2:                                                                             
        //                 id = borderControlInfo[1];                                                      
        //                 Robot currRobot = new Robot(name, id);                                          
        //                 detainedIDs.Add(currRobot);                                                     
        //                 break;                                                                          
        //         }                                                                                       
        //     }                                                                                           
                                                                                                         
        //     string fakeIDEndingNumber = Console.ReadLine();                                             
        //     detainedIDs = detainedIDs.Where(c => c.Id.EndsWith(fakeIDEndingNumber)).ToList();           
        //     Console.WriteLine(string.Join(Environment.NewLine, detainedIDs.Select(i => i.Id)));         
        //}
    }
}
