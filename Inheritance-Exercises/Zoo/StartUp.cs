using System;

namespace Zoo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Lizard liz = new Lizard("Lizardinho");
            Console.WriteLine(liz.Name);
        }
    }
}
