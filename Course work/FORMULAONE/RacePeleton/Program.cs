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
            Race race = new Race();

            await race.GettingDrivers();
            race.SetupTrack();
            while (!race.GameOverCond())
            {
                
                race.PrintTrack();
                race.PrintDrivers();
                race.PrintTable();
                race.ChangePosition();


                Thread.Sleep(300);
                race.RollError();
            }

            Console.SetCursorPosition(15, 20);
            Console.ForegroundColor = race.teamColors[race.GetWinner().TeamId-1];
            Console.Write($"{race.GetWinner().Name} {race.GetWinner().LastName}");
            Console.ResetColor();
            Console.WriteLine($" has won a Silverstone gran prix!");


            Console.SetCursorPosition(0, 25);
        }
    }
}