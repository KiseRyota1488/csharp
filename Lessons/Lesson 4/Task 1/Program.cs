using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor color = ConsoleColor.Yellow;
            Console.ForegroundColor = color;

            Point p = new Point(3,3);
            Rectangle rc = new Rectangle(8,5);

            
            rc.PrintPoint();

            p.PrintPoint();
            
        }
    }
}
