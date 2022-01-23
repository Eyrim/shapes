using System;
using System.Collections.Generic;

namespace Shapes
{
    class Square : Interfaces.IShape
    {
        List<double> Sides;
        public Square(List<double> sides)
        {
            if (sides.Count != 1)
            {
                throw new Exceptions.InvalidDataException(message: "Wrong number of sides to initialise a square object");
            }

            else if(sides == null)
            {
                throw new Exceptions.InvalidDataException(message: "Wrong number of sides to initialise a square object");
            }

            else
            {
                this.Sides = sides;
            }
        }

        public double GetArea()
        {
            return this.Sides[0] * this.Sides[0];
        }
    }
}