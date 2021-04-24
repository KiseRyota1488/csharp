using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingZone
{
    public class TeamLeader :IWorker
    {
        public Type lastPart { get; set; }

        public void Working()
        {
            Console.WriteLine($"Working on {lastPart.Name.ToLower()} part");
        }
    }
}
