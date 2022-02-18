using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class Car
    {
        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; set; }
        public string Color { get; set; }

        public abstract void Start();
        public abstract void Stop();

    }
}
