using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RacingStaff
{
    public class RaceDirection
    {
        int RaceCount { get; set; }
        int[] points = new int[10] { 25, 18, 15, 12, 10, 8, 6, 4, 2, 1 };

        public RaceDirection(int raceCount)
        {
            RaceCount = raceCount;
            
        }
        async Task Race()
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

            Console.SetCursorPosition(15, 19);
            Console.ForegroundColor = race.teamColors[race.GetWinner().TeamId - 1];
            Console.Write($"{race.GetWinner().Name} {race.GetWinner().LastName}");
            Console.ResetColor();
            Console.WriteLine($" has won a Silverstone gran prix!");

            AddPoints(race.cars);

            Console.SetCursorPosition(0, 30);
            Console.WriteLine("Press ANY key to start next gran prix");
            Console.ReadKey();
            race.Clear(0, 0, 100, 40);

        }

        public async Task CarryGranPrix()
        {
            for (int i = 0; i < RaceCount; i++)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"Gran prix: {i+1}");
                await Race();
            }
        }
        
        void AddPoints(List<Bolide> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].Points = points[i];
            }

            Console.SetCursorPosition(0, 22);
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{cars[i].Name} {cars[i].LastName}: \t{cars[i].Points} points");
            }
        }
    }
}
