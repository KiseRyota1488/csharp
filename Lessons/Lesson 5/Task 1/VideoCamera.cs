using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class VideoCamera :  IWatch
    {
        public int Id { get; set; }
        static int counter = 0;
        public int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                counter = value;
            }
        }
        public VideoCamera()
        {
            Counter++;
            Id = Counter;
        }
        public void Watch(Animal animal)
        {
            Console.WriteLine($"Camera{Id} is watching for {animal.GetType().Name}");
        }
    }
}
