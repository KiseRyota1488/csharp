using System;
using System.Threading;
using System.Threading.Tasks;
using RacingStaff;

namespace RacePeleton
{
    class Program
    {
        static async Task Main(string[] args)
        {
            RaceDirection raceDirector = new RaceDirection(5);

            await raceDirector.CarryGranPrix();

            Console.SetCursorPosition(0, 25);
        }
    }
}