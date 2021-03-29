using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shape
    {
        public Position basePoint { get; set; }

        ConsoleColor color;

        abstract public int Area();
        abstract public int Perimetr();

        virtual public void Print() 
        {
            Console.WriteLine($"Class: {this.GetType().Name}\n Area: {Area()}");
        }

        abstract public void PrintPoint();
    }
}
