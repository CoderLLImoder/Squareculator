using System;
using System.Linq;


namespace Squareculator
{
    public class Triangle: ITriangle
    {
        public double[] sides { get; }

        public Triangle(double aSide, double bSide, double cSide)
        {
            if (aSide <= 0 || bSide <= 0 || cSide <= 0)
                throw new ArgumentException("Стороны треугольника должны иметь длину с положительным значением");

            var sides = new double[] { aSide, bSide, cSide };
            if (sides.Sum() - 2 * sides.Max() <= 0)
                throw new ArgumentException("Сумма длин катетов, должна быть больше длины гиппотенузы");

            this.sides = sides;
        }

        public bool isRight {
            get
            {
                var hypotenuse = sides.Max();
                var cathetPowSum = sides.Where(s => !s.Equals(hypotenuse)).Sum(s => Math.Pow(s, 2));

                return Math.Pow(hypotenuse, 2) == cathetPowSum;
            }
        }

        public double GetSquare()
        {
            var halfP = sides.Sum() / 2;
            return Math.Sqrt(sides.Aggregate(halfP, (x, y) => x * (halfP - y)));
        }
    }
}
