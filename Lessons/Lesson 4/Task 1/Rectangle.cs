using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Shapes
{
    class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Length { get; set; }

        public Rectangle(int height, int length)
        {
            Height = height;
            Length = length;
        }

        public override int Area()
        {
            return Height * Length;
        }
        public override int Perimetr()
        {
            return 2 * (Height + Length);
        }

        public override void PrintPoint()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Console.Write($"*");
                }
                Console.WriteLine();
            }
        }

    }
}
