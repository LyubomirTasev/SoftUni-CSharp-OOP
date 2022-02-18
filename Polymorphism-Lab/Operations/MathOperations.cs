using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("Add(int a, int b)");
            return a + b;
        }

        public double Add(double x, double y, double z)
        {
            Console.WriteLine("Add(double x, double y, double z)");
            return x + y + z;
        }

        public decimal Add(decimal m, decimal n, decimal o)
        {
            Console.WriteLine("Add(decimal m, decimal n, decimal o)");
            return m + n + o;
        }
    }
}
