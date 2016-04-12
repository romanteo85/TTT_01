using System;

namespace Geometry
{
    public class Triangle
    {
        public double LengthA { get; }
        public double LengthB { get; }
        public double LengthC { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0) throw new ArgumentOutOfRangeException(nameof(a), "Значение длины должно быть положительным числом");
            if (b <= 0) throw new ArgumentOutOfRangeException(nameof(b), "Значение длины должно быть положительным числом");
            if (c <= 0) throw new ArgumentOutOfRangeException(nameof(c), "Значение длины должно быть положительным числом");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArithmeticException("Треугольник с указанными размерами не возможен");

            LengthA = a;
            LengthB = b;
            LengthC = c;
        }

        public double CalcSquare()
        {
            double p = (LengthA + LengthB + LengthC) / 2;
            return Math.Sqrt(p * (p - LengthA) * (p - LengthB) * (p - LengthC));
        }

        public bool IsRightTriangle()
        {
            double maxSideLength = Math.Max(Math.Max(LengthA, LengthB), LengthC);
            return Math.Abs(LengthA * LengthA + LengthB * LengthB + LengthC * LengthC - 2 * maxSideLength * maxSideLength) < double.Epsilon;
        }
    }
}
