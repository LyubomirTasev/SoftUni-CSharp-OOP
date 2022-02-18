using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCaloriess
{
    public class Toppings
    {
        private Dictionary<string, double> toppingTypes = new Dictionary<string, double>
        {
            {"Meat", 1.2},
            {"Veggies", 0.8},
            {"Cheese", 1.1},
            {"Sauce", 0.9}
        };

        private string type;
        private double weight;

        public Toppings(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type;
            private set
            {
                if (!toppingTypes.ContainsKey(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                type = value;
            }
        }

        public double Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{nameof(Type)} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }

        public double Calories() => 2 * Weight * toppingTypes[Type];


    }
}
