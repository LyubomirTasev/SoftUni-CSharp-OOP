using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class BMW : Car
    {
        public BMW()
            :base("X5", "Black")
        {

        }

        public override void Start()
        {
            Console.WriteLine("Normal");
        }

        public override void Stop()
        {
            Console.WriteLine("Normal");
        }
    }
}
