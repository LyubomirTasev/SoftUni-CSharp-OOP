using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCaloriess
{
    public class Pizza
    {
        private string name;

        private Dough dough;

        private List<Toppings> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Toppings>();
        }
        public string Name
        {
            get { return name; }
            private set 
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        public IReadOnlyCollection<Toppings> Toppings => this.toppings;

        public double CalculateCalories()
        {
            double result = this.Dough.Calories + toppings.Sum(x => x.Calories());
            return result;
        }

        public void AddTopping(Toppings topping)
        {
            if (toppings.Count == 10)
            {
                throw new InvalidOperationException("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }
    }
}
