using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            const double wallSize = 0.4;
            double radiusInCircle = radius - wallSize;
            double radiusOutsideCircle = radius + wallSize;

            for (int y = radius; y >= -radius; y--)
            {
                for (double x = -radius; x < radius; x += 0.5)
                {
                    double triangleArea = x * x + y * y;
                    if (triangleArea <= radiusOutsideCircle * radiusOutsideCircle &&
                        triangleArea >= radiusInCircle * radiusInCircle)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
