using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class ZooWorker : IWatch
    {
        public ZooWorker()
        {

        }
        public void Watch(Animal animal)
        {
            Console.WriteLine($"Zoo worker is watching for {animal.GetType().Name}");
        }
    }
}
