using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingZone
{
    public class Door : House, IPart
    {
        public void GetPart()
        {
            Console.WriteLine(123);
        }
    }
}
