using System;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            B d = new B() { J = 5 };
            B f = new B() { J = 5 };


            Console.WriteLine(d.GetHashCode());
            Console.WriteLine(f.GetHashCode());
        }

    }

    class B
    {
        public int J { get; set; }
    }
    
}
