using System;

namespace Operations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();
            Console.WriteLine(mathOperations.Add(5.5, 6.62, 18.58));
        }
    }
}
