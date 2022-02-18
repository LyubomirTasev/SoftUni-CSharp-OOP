using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCaloriess
{
    public class Dough
    {
        private const string DoughtExceptionMessage = "Invalid type of dough.";
        private const string WeightExceptionMessage = "Dough weight should be in the range [1..200].";

        private Dictionary<string, double> flourTypeCalories = new Dictionary<string, double>
        {
            {"White", 1.5 },
            {"Wholegrain", 1 }
        };

        private Dictionary<string, double> bakingTechniqueCalories = new Dictionary<string, double>
        {
            {"Crispy", 0.9 },
            {"Chewy", 1.1 },
            {"Homemade", 1 }
        };

        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get => this.flourType;
            private set
            {
                if (!flourTypeCalories.ContainsKey(value))
                {
                    throw new ArgumentException(DoughtExceptionMessage);
                }

                this.flourType = value;
            }
        }
        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {
                if (!bakingTechniqueCalories.ContainsKey(value))
                {
                    throw new ArgumentException(DoughtExceptionMessage);
                }

                this.bakingTechnique = value;
            }
        }
        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException(WeightExceptionMessage);
                }

                this.weight = value;
            }
        }

        public double Calories => 2 * Weight * flourTypeCalories[FlourType] * bakingTechniqueCalories[BakingTechnique];
    }
}
