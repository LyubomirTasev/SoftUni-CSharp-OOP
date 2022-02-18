using System;
using System.Collections.Generic;

namespace Shapes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<IDrawable> shapes = new List<IDrawable>();
            shapes.Add(new Circle(8));
            shapes.Add(new Rectangle(10, 5));
            shapes.Add(new Square(5));
            shapes.Add(new Rectangle(8, 4));

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
                shape.DrawShape();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
