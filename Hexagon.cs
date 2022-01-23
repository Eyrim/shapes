using System;
using System.Collections.Generic;

namespace Shapes
{
    class Hexagon : Interfaces.IShape
    {
        List<double> Sides;

        public Hexagon(List<double> sides)
        {
            if (sides.Count != 1)
            {
                throw new Exceptions.InvalidDataException(message: "Wrong number of sides to initialise a hexagon object");
            }

            else if (sides == null)
            {
                throw new Exceptions.InvalidDataException(message: "Wrong number of sides to initialise a hexagon object");
            }

            else
            {
                this.Sides = sides;
            }
        }

        public double GetArea()
        {
            double area = 0;

            area = (3 * Math.Sqrt(3)) / 2;
            area *= this.Sides[0];

            return area;
        }
    }
}