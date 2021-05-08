using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingZone
{
    class Worker : IWorker
    {
        public IPart part;
        public Material mat;
        public void Working()
        {
            Console.WriteLine($"Worker {part.GetPart()} {part.GetMaterial(mat)}");
        }
    }
}
