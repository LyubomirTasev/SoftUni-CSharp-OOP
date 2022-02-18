using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"{nameof(Name)} cannot be empty");
                }

                this.name = value;
            }
        }
        public double Cost
        {
            get => this.cost;
            private set
            {
                if (value < 0)
                {
                    throw new Exception($"{nameof(Cost)} cannot be negative");
                }

                this.cost = value;
            }
        }


    }
}
