using System;
using BuildingZone;
using System.Collections.Generic;

namespace HouseBuilding
{
    enum Material
    {
        wooden = 1,
        glass,
        metallic
    }
    class Program
    {
        static void Main(string[] args)
        {
            Team workersTeam = new Team();
            

            workersTeam.Building();

            

            Console.SetCursorPosition(0, 15);
        }
    }
}
