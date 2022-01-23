using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Interfaces.IShape[] shapes = new Interfaces.IShape[4];

            shapes[0] = ShapeFactory.CreateShape(ShapeEnum.Triangle, sides: new List<double> {3, 4, 5});
            shapes[1] = ShapeFactory.CreateShape(ShapeEnum.Hexagon, sides: new List<double> {3});
            shapes[2] = ShapeFactory.CreateShape(ShapeEnum.Pentagon, sides: new List<double> {3});
            shapes[3] = ShapeFactory.CreateShape(ShapeEnum.Square, sides: new List<double> {3});

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i].GetArea());
            }
        }
    }
}
