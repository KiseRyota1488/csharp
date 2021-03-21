using System;
using System.Linq;
using System.Globalization;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 7, 9, 6, 4, 10, 5 };

            int sum = 0;

            for (int i = Array.IndexOf(arr, arr.Min())+1; i < Array.IndexOf(arr, arr.Max()); i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("Sum: {0}",sum);

        }

       

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
