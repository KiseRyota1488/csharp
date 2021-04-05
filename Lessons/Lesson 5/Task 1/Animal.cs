using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public abstract class Animal : IEat, ISleep, IWalk
    {
        public void Move()
        {
            Console.WriteLine($"{GetType().Name} is moving");
        }
        public void Eat()
        {
            Console.WriteLine($"{GetType().Name} is eating");
        }
        public void Sleep()
        {
            Console.WriteLine($"{GetType().Name} is sleeping");
        }

    }
}
