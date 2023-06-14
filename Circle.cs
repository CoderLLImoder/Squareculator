using System;

namespace Squareculator
{
    public class Circle: IRadiusable
    {
        public double radius { get; }

        public Circle(double radius) 
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше 0.");

            this.radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

}
