using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using RacingStaff;

namespace RacePeleton
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Race race = new Race();

            await race.GettingDrivers();
            race.SetupTrack();

            while(true)
            {
                race.PrintTrack();
                race.PrintDrivers();
                race.PrintTable();
                race.ChangePosition();

                Thread.Sleep(1000);
            }


            Console.SetCursorPosition(0, 20);
        }
    }
}