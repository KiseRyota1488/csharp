using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square : Shape
    {
        public int Side { get; set; }

        public override int Area()
        {
            return Side * Side;
        }
        public override int Perimetr()
        {
            return 4 * Side;
        }

        public override void PrintPoint()
        {
            for (int i = 0; i < Side; i++)
            {
                for (int j = 0; j < Side; j++)
                {
                    Console.Write($"*");
                }
                Console.WriteLine();
            }
        }

    }
}
