using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> starterArray = new List<int>() { 1, 3, -5, -3, 4, -1 };

            List<int> resultedArray = new List<int>();

            resultedArray.AddRange(starterArray.FindAll(item => item < 0));
            resultedArray.AddRange(starterArray.FindAll(item => item >= 0));
            
            foreach (var item in resultedArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
