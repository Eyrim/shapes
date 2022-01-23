using System;
using System.Collections.Generic;

namespace Shapes
{
    class ShapeFactory
    {
        public static Interfaces.IShape CreateShape(ShapeEnum shape, List<double> sides=null)
        {
            switch (shape)
            {
                case ShapeEnum.Square:
                    return new Square(sides);

                case ShapeEnum.Triangle:
                    return new Triangle(sides);

                case ShapeEnum.Pentagon:
                    return new Pentagon(sides);

                case ShapeEnum.Hexagon:
                    return new Hexagon(sides);

                default:
                    throw new Exceptions.InvalidShapeException(message: "There is no such shape");
            }
        }
    }
}