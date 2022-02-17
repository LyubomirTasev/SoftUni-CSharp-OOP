using System;

namespace PlayersVSMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Wizard wiz = new Wizard("Gogo", 25);
            Console.WriteLine(wiz);
        }
    }
}
