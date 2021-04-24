using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingZone
{
    public class Basement : IPart
    {
        public void GetPart()
        {
            Console.WriteLine($"Workers are working on {GetType().Name.ToLower()}");
        }
    }
}
