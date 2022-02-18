using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("S", "Blue", 5);

            Car volkswagen = new VolksWagen("Golf", "Red");
            volkswagen.Start();
            volkswagen.Stop();

            Car bmw = new BMW();
            bmw.Start();
            bmw.Stop();

            Console.WriteLine(seat.ToString());
            Console.WriteLine(seat.Start());
            Console.WriteLine(seat.Stop());
            Console.WriteLine(tesla.ToString());
        }
    }
}
