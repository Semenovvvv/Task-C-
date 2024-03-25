namespace Task
{
    public class Program
    {
        public enum Figures
        {
            Circle,
            Triangle
        }

        public class GeometryCalculator
        {
            public static double CalculateArea(Figures figure, params double[] parameters)
            {
                switch (figure)
                {
                    case Figures.Circle:
                        return CalculateCircleArea(parameters[0]);
                    case Figures.Triangle:
                        return CalculateTriangleArea(parameters[0], parameters[1], parameters[2]);
                    default:
                        throw new ArgumentException("Неизвестный тип фигуры");
                }
            }

            public static double CalculateCircleArea(double radius)
            {
                if (radius <= 0)
                {
                    throw new ArgumentException("Радиус должен быть положительным числом.");
                }

                return Math.PI * radius * radius;
            }

            public static double CalculateTriangleArea(double side1, double side2, double side3)
            {
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    throw new ArgumentException("Длины сторон должны быть положительными числами.");
                }

                double s = (side1 + side2 + side3) / 2;

                if (IsRightTriangle(side1, side2, side3))
                {
                    double[] sides = { side1, side2, side3 };
                    Array.Sort(sides);
                    return 0.5 * sides[0] * sides[1];
                }
                return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            }

            public static bool IsRightTriangle(double side1, double side2, double side3)
            {
                var Sqr = (double number) => Math.Pow(number, 2);
                double[] sides = { side1, side2, side3 };
                var maxSide = sides.Max();

                return Math.Abs(Sqr(sides[0]) + Sqr(sides[1]) + Sqr(sides[2]) - Sqr(maxSide)) == Sqr(maxSide);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GeometryCalculator.CalculateArea(Figures.Triangle, 3, 4, 5)); 
        }
    }
}
