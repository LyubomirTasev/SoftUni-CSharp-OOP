using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class VolksWagen : Car
    {
        public VolksWagen(string model, string color)
            :base(model, color)
        {
        }

        public override void Start()
        {
            Console.WriteLine("Noisey!!");
        }

        public override void Stop()
        {
            Console.WriteLine("Too noisyy!");
        }
    }
}
