using System;
using System.Collections.Generic;

namespace Shapes
{
    class Pentagon : Interfaces.IShape
    {
        List<double> Sides;

        public Pentagon(List<double> sides)
        {
            if (sides.Count != 1)
            {
                throw new Exceptions.InvalidDataException(message: "Wrong number of sides to initialise a pentagon object");
            }

            else if(sides == null)
            {
                throw new Exceptions.InvalidDataException(message: "Wrong number of sides to initialise a pentagon object");
            }

            else
            {
                this.Sides = sides;
            }
        }

        public double GetArea()
        {
            double area = 0;

            // Found using
                // 1/4 * sqrt(5 * (5 + 2 * sqrt(5)))
            area += 1.720477401;
            area *= this.Sides[0] * this.Sides[0];

            return area;
        }
    }
}