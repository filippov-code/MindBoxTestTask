using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Circle : IFigure
    {
        public readonly double Radius;
        private readonly double area;

        public double Area => area;


        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше 0");
            }

            Radius = radius;
            area = Math.PI* Math.Pow(Radius, 2);
        }
    }
}
