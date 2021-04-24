using System;

namespace Test1
{
    delegate void M(string s);
    class Program
    {
        static void Main(string[] args)
        {
            M v = hell;
            v += hell;
            
        }
        static void hell(string s)
        {
            Console.WriteLine(s);
        }
    }
}
