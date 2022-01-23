using System;
using System.Collections.Generic;

namespace Shapes
{
    class Triangle : Interfaces.IShape
    {
        List<double> Sides;

        public Triangle(List<double> sides)
        {
            if (sides.Count != 3)
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

        /// <summary>
        /// Implements Herons formula
        /// </summary>
        public double GetArea()
        {
            double area = 0;
            double s = CalcSemiPerimeter();

            area = (s - this.Sides[0]);
            area *= (s - this.Sides[1]);
            area *= (s - this.Sides[2]);

            return Math.Sqrt(s * area);
        }

        private double CalcSemiPerimeter()
        {
            double s = 0;
        
            s = this.Sides[0] + this.Sides[1] + this.Sides[2];
            s /= 2;
            
            return s;
        }
    }
}