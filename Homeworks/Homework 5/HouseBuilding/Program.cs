using System;
using BuildingZone;
using System.Collections.Generic;

namespace HouseBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamLeader tl = new TeamLeader() { lastPart = new House().GetType() };

            tl.Working();

            Team t = new Team();

            t.Building();
        }
    }
}
