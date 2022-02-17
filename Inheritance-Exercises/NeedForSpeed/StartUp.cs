using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle motor = new RaceMotorcycle(100, 200);
            motor.Drive(2);
        }
    }
}
