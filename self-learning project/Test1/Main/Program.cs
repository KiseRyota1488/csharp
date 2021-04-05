using System;

namespace Main
{
    interface IB
    {
        public void Move();
    }
    class Program
    {
        
        static void Main(string[] args)
        {



        }

    }

    class Team : IB
    {
        public int Age { get; set; }
        public void Move()
        {
            Console.WriteLine("11");
        }
    }
}
