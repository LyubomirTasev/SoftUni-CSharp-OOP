using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Dog : Animal
    {
        //public override void Eat()
        //{
        //    base.Eat();
        //    Bark();
        //}
        public virtual void Bark()
        {
            Console.WriteLine("Bau Bau");
        }
    }
}
