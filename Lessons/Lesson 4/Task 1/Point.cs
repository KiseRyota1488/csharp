using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Point : Shape
    {
        public Point(int x, int y)
        {
            this.basePoint.X = x;
            this.basePoint.Y = y;
        }


        public override int Area()
        {
            return 0;
        }
        public override int Perimetr()
        {
            return 0;
        }
        

        public override void PrintPoint()
        {
            Console.Write($"*");
        }

    }
}
