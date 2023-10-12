using System;

namespace TestJuniorLib
{
    public class ShapeCalculator
    {
        public double CalculateCircleArea(double radius) // Для вычисления площади круга по радиусу.
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.");
            }

            return Math.Round(Math.PI * radius * radius);
        }

        public double ChekingRightTriangle(double side1, double side2, double side3)
        {
            bool Triangle;
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Длины сторон должны быть положительными числами.");
            }

            double[] sides = new double[] { side1, side2, side3 };
            Array.Sort(sides);

            Triangle = Math.Abs(Math.Pow(sides[0], 2f) + (Math.Pow(sides[1], 2f))) == Math.Pow(sides[2], 2f); // true - прямоугольный false - не прямоугольный           
            Console.WriteLine(Triangle);
            if (Triangle) return CalculateRightTriangleArea(side1, side2, side3); //True
            else return CalculateTriangleArea(side1, side2, side3); // False
        }

        private static double CalculateTriangleArea(double side1, double side2, double side3) // Для вычисления площади треугольника по трем сторонам.
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
            return area;
        }

        private static double CalculateRightTriangleArea(double side1, double side2, double side3) // Для вычисления площади треугольника по трем сторонам.
        {
            double[] sides = new double[] { side1, side2, side3 };
            Array.Sort(sides);

            return sides[0] * sides[1] * 0.5;
        }
    }
}
