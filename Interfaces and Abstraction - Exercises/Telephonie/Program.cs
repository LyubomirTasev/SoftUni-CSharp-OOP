using System;
using System.Linq;

namespace Telephonie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            foreach (var phoneNumber in phoneNumbers)
            {
                if (!phoneNumber.All(c => char.IsDigit(c)))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                ICalling calling = null;

                if (phoneNumber.Length == 7)
                {
                    calling = new StationaryPhone();
                }
                else if (phoneNumber.Length == 10)
                {
                    calling = new Smartphone();
                }

                calling.Call(phoneNumber);
            }

            foreach (var url in websites)
            {
                if (url.Any(c => char.IsDigit(c)))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }

                Smartphone smartphone = new Smartphone();
                smartphone.Browse(url);
            }
        }
    }
}
