using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationExercises
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double heigth)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = heigth;
        }

        public double Length
        {
            get => this.lenght;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.lenght = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public string CalculateVolume()
        {
            double result = this.lenght * this.width * this.height;
            return $"Volume - {result:f2}";
        }

        public string CalculateLateralSurfaceArea()
        {
            //Lateral Surface Area = 2lh + 2wh
            double result =  (2 * this.lenght * this.height) +  (2 * this.width * this.height);
            return $"Lateral Surface Area - {result:f2}";
        }

        public string CalculateSurfaceArea()
        {
            //Surface Area = 2lw + 2lh + 2wh
            double result =  (2 * this.lenght * this.width) +  (2 * this.lenght * this.height) +  (2 * this.width * this.height);
            return $"Surface Area - {result:f2}";
        }

    }
}
