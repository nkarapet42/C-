using System;
using System.Numerics;

namespace MyArea
{
    class Circle
    {
        private double Radius { get; }

        public Circle(double radius) => Radius = radius;

        public static double AreaOfCircle(Circle circle)
        {
            if (circle == null) throw new Exception("Create Circle");
            if (circle.Radius <= 0) throw new Exception("Invalid radius");

            return (Math.PI * circle.Radius * circle.Radius);
        }
    }

    class Triangle
    {
        private double A { get; }
        private double B { get; }
        private double C { get; }

        private static void  CheckTriangle (Triangle point)
        {
            if (point == null)
                throw new Exception("Create the triangle");
            if (point.A <= 0 || point.B <= 0 || point.C <= 0)
                throw new Exception("Triangle sides is not valid");
            if (point.A + point.B <= point.C
                || point.A + point.C <= point.B
                || point.B + point.C <= point.A)
                throw new Exception("Triangle is wrong");
        }

        public  static void CheckRightTriangle(Triangle point)
        {
            CheckTriangle(point);
            double a = Math.Pow(point.A, 2);
            double b = Math.Pow(point.B, 2);
            double c = Math.Pow(point.C, 2);
            if ((a + b == c) || (a + c == b) || (c + b == a))
                Console.WriteLine("Triangle is Right");
            else Console.WriteLine("Triangle isn't Right");
        }

        public static double AreaOfTriangle (Triangle point)
        {
            CheckTriangle(point);
            double s = (point.A + point.B + point.C) / 2;
            double area = Math.Sqrt(s * (s - point.A) * (s - point.B) * (s - point.C));
            return (area);
        }

        public Triangle(double a, double b, double c) => (A, B, C) = (a, b, c);
    }
}