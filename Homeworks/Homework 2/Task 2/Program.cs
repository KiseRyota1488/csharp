using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] firstArr = new int[5];
            int[] secondArr = new int[5];
            int[] resultArr = new int[firstArr.Length + secondArr.Length];

            for (int i = 0; i < 5; i++)
            {
                firstArr[i] = rnd.Next(10);
                secondArr[i] = rnd.Next(10);
            }

            foreach (var item in firstArr)
            {
                Console.Write(item + " ");
            }
            foreach (var item in secondArr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n\n");



            //1
            Console.Write("1: ");
            foreach (var item in TwoArraysInOne(firstArr, secondArr))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //2
            Console.Write("2: ");
            foreach (var item in WithoutDoubles(firstArr, secondArr))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //3
            Console.Write("3: ");
            foreach (var item in WithoutCoincidence(firstArr, secondArr))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }

        static int[] TwoArraysInOne(int[] array1, int[] array2)
        {
            int[] resultArr = new int[array1.Length + array2.Length];

            array1.CopyTo(resultArr, 0);
            array2.CopyTo(resultArr, array1.Length);

            return resultArr;
        }

        static List<int> WithoutDoubles(int[] array1, int[] array2)
        {
            List<int> resultArr = new List<int>();
            
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if(array1[i] == array2[j])
                    {
                        resultArr.Add(array1[i]);
                        break;
                    }
                }
            }

            for(int i = 0;i<resultArr.Count();i++)
            {
                for(int j = i+1; j < resultArr.Count();j++)
                {
                    if (resultArr[i] == resultArr[j])
                        resultArr.RemoveAt(j);
                }
            }

            return resultArr;
        }

        static List<int> WithoutCoincidence(int[] array1, int[] array2)
        {
            List<int> resultArr = new List<int>();

            foreach (var item in array1)
            {
                if(Array.IndexOf(array2,item) == -1)
                    resultArr.Add(item);
            }

            return resultArr;
        }

    }
}
