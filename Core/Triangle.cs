﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Triangle : IFigure
    {
        public readonly double A;
        public readonly double B;
        public readonly double C;
        private readonly double area;

        public double Area => area;
        public readonly bool IsRightAngled;


        public Triangle(double a, double b, double c)
        {
            //  Свойство сторон треугольника:
            //  Сумма длин двух любых сторон треугольника больше длины оставшейся стороны
            if (a + b <= c || b + c <= a || c + a <= b)
            {
                throw new ArgumentException("Невозможно построить треугольник с такими сторонами");
            }

            A = a;
            B = b;
            C = c;

            //  Для проверки на прямоугольность используется теорема Пифагора:
            //  В прямоугольном треугольнике квадрат гипотенузы равен сумме квадратов катетов треугольника
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                IsRightAngled = true;
            }

            //  Для вычисления площади используется формула Герона:
            //  S = √(p·(p - a)·(p - b)·(p - c)), p = (a+b+c)/2
            double p = (A + B + C) / 2;
            area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
