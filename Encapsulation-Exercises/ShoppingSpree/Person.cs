using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bagOfProducts;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<Product>();
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
        public double Money
        {
            get => this.money;
            private set
            {
                if (value < 0)
                {
                    throw new Exception($"{nameof(Money)} cannot be negative");
                }

                this.money = value;
            }
        
        }

        public void IsAffordable(Product product)
        {
            if (product.Cost > this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }

            this.bagOfProducts.Add(product);
            this.Money -= product.Cost;
        }

        public override string ToString()
        {
            if (this.bagOfProducts.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }

            var products = this.bagOfProducts.Select(p => p.Name);

            return $"{this.Name} - {string.Join(", ", products)}";
        }
    }
}
