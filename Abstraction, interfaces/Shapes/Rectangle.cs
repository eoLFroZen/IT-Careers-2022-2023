using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 0; i < height - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < width - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            for (int i = 0; i < width; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
