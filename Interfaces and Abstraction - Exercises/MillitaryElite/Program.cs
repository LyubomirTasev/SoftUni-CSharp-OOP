using MillitaryElite.Implementation;
using MillitaryElite.Interfaces;
using System;
using System.Collections.Generic;

namespace MillitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ISoldier> soldiers = new Dictionary<string, ISoldier>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = inputInfo[0];
                string id = inputInfo[1];
                string firstName = inputInfo[2];
                string lastName = inputInfo[3];

                if (action == "Private")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    IPrivate @private = new Private(id, firstName, lastName, salary);

                    soldiers.Add(id, @private);
                }

                else if (action == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);

                    ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < inputInfo.Length; i++)
                    {
                        string inputId = inputInfo[i];

                        IPrivate @private = soldiers[inputId] as IPrivate;

                        lieutenantGeneral.Privates.Add(@private);
                    }

                    soldiers.Add(id, lieutenantGeneral);
                }

                else if (action == "Engineer")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    string corpsAsString = inputInfo[5];

                    bool isValidEnum = Enum.TryParse(corpsAsString, out Corps result);

                    if (!isValidEnum)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    IEngineer engineer = new Engineer(id, firstName, lastName, salary, result);

                    for (int i = 6; i < inputInfo.Length; i += 2)
                    {
                        string partName = inputInfo[i];
                        int hours = int.Parse(inputInfo[i + 1]);

                        IRepair repair = new Repair(partName, hours);

                        engineer.Repairs.Add(repair);
                    }

                    soldiers.Add(id, engineer);
                }

                else if (action == "Commando")
                {
                    decimal salary = decimal.Parse(inputInfo[4]);
                    string corpsAsString = inputInfo[5];

                    bool isValidEnum = Enum.TryParse(corpsAsString, out Corps result);

                    if (!isValidEnum)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    ICommando commando = new Commando(id, firstName, lastName, salary, result);

                    for (int i = 6; i < inputInfo.Length; i += 2)
                    {
                        string missionCode = inputInfo[i];
                        string missionStateAsString = inputInfo[i + 1];

                        bool IsValidMission = Enum.TryParse(missionStateAsString, out Status status);

                        if (!IsValidMission)
                        {
                            continue;
                        }

                        IMission mission = new Mission(missionCode, status);
                        commando.Missions.Add(mission);
                    }

                    soldiers.Add(id, commando);
                }

                else if (action == "Spy")
                {
                    int codeNumber = int.Parse(inputInfo[4]);

                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);

                    soldiers.Add(id, spy);
                }

                input = Console.ReadLine();
            }

            foreach (var item in soldiers)
            {
                Console.WriteLine(item.Value.ToString());
            }
        }
    }
}
