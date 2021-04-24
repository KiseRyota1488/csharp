using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingZone
{
    class Worker : IWorker
    {
        public Type currentPart { get; set; }
        public void Working()
        {
           Console.WriteLine($"Building {currentPart.Name.ToLower()} part");
        }
    }
}
