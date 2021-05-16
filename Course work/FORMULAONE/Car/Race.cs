using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace RacingStaff
{
    public class Race
    {
        public List<Bolide> cars = new List<Bolide>();
        public List<Bolide> eliminated = new List<Bolide>();
        public Track[] track = new Track[36]
        {
            new Track(15,3),
            new Track(17,3),
            new Track(19,3),
            new Track(21,3),
            new Track(21,4),
            new Track(22,5),
            new Track(23,6),
            new Track(24,7),
            new Track(24,8),
            new Track(25,9),
            new Track(25,10),
            new Track(25,11),
            new Track(23,12),
            new Track(21,12),
            new Track(19,12),
            new Track(17,11),
            new Track(16,10),
            new Track(14,10),
            new Track(12,10),
            new Track(10,10),
            new Track(9,11),
            new Track(7,11),
            new Track(6,10),
            new Track(6,9),
            new Track(6,8),
            new Track(7,7),
            new Track(9,7),
            new Track(10,6),
            new Track(9,5),
            new Track(7,5),
            new Track(6,4),
            new Track(7,3),
            new Track(8,2),
            new Track(10,2),
            new Track(11,3),
            new Track(13,3),
        };

        public ConsoleColor[] teamColors = new ConsoleColor[4];

        public void SetupTrack()
        {
            teamColors[0] = ConsoleColor.DarkGray;
            teamColors[1] = ConsoleColor.DarkCyan;
            teamColors[2] = ConsoleColor.Red;
            teamColors[3] = ConsoleColor.Blue;

            for (int i = 0; i < cars.Count; i++)
                while (!AddCar(cars[i])) ;
        }

        bool AddCar(Bolide car)
        {
            Random rnd = new Random();

            int pos = rnd.Next(track.Length);

            if (track[pos].carNumber == null && (track[pos].X != 15 && track[pos].Y != 7))
            {
                car.CurrentPosition = pos;
                track[pos].carNumber = car.Number;
                return true;
            }
            else
                return false;
        }

        public void RollError()
        {
            Random rnd = new Random();

            for (int i = 0; i < cars.Count; i++)
            {
                int tmpRnd = rnd.Next(1, 10000);

                if (tmpRnd == 1)
                {
                    Clear(0,0,100,50);

                    Console.SetCursorPosition(1, 17);
                    Console.WriteLine($"{cars[i].Name} {cars[i].LastName} got puncture");
                    eliminated.Add(cars[i]);
                    cars.Remove(cars[i]);

                    break;
                }
                else if (tmpRnd == 9999)
                {
                    Clear(0,0,100,50);

                    Console.SetCursorPosition(1, 17);
                    Console.WriteLine($"{cars[i].Name} {cars[i].LastName} got engine issue");
                    eliminated.Add(cars[i]);
                    cars.Remove(cars[i]);

                    break;
                }
            }

        }

        public async Task GettingDrivers()
        {
            using (FileStream fs = new FileStream(@"..\..\..\..\drivers.json", FileMode.OpenOrCreate))
            {
                cars = await JsonSerializer.DeserializeAsync<List<Bolide>>(fs);
            }
        }

        public void PrintTrack()
        {
            for (int i = 0; i < track.Length; i++)
            {
                Console.SetCursorPosition(track[i].X, track[i].Y);
                Console.Write("##");
            }
        }
        public void PrintTable()
        {
            Console.SetCursorPosition(35, 1);
            Console.WriteLine("Leaderboard:");

            SortByLaps();
            int i;
            for (i = 0; i < cars.Count; i++)
            {
                Console.SetCursorPosition(35, 3 + i);

                Console.WriteLine($"P{i + 1}: {cars[i]}");
            }

            Console.SetCursorPosition(35, 5 + i);
            Console.WriteLine("Eliminated:");
            for (int j = 0; j < eliminated.Count; j++, i++)
            {
                Console.SetCursorPosition(35, 7 + i);

                Console.WriteLine($"P{j + 1}: {eliminated[j]}");
            }
        }
        public void PrintDrivers()
        {

            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].ChangeCurSpeed();
                for (int j = 0; j < track.Length; j++)
                {
                    if (j == cars[i].CurrentPosition)
                    {
                        Console.SetCursorPosition(track[j].X, track[j].Y);

                        switch (cars[i].TeamId)
                        {
                            case 1:
                                Console.ForegroundColor = teamColors[0];
                                break;
                            case 2:
                                Console.ForegroundColor = teamColors[1];
                                break;
                            case 3:
                                Console.ForegroundColor = teamColors[2];
                                break;
                            case 4:
                                Console.ForegroundColor = teamColors[3];
                                break;

                            default:
                                break;
                        }
                        Console.Write(cars[i].Number);
                        Console.ResetColor();
                    }
                }
            }
        }
        public void ChangePosition()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].CurrentSpeed < (((360 - 280) / 2) + 280))
                {
                    cars[i].LapsCounter++;
                    cars[i].CurrentPosition++;
                }
                else
                {
                    cars[i].LapsCounter += 2;
                    cars[i].CurrentPosition += 2;
                    SwapPosCond(cars[i].CurrentPosition, i);

                }
            }
        }
        void SwapPosCond(int currentPos, int curInd)
        {
            for (int i = 0; i < cars.Count; i++)
                if (cars[i].CurrentPosition == currentPos && i != curInd)
                {
                    if (cars[i].CurrentSpeed > cars[curInd].CurrentSpeed)
                    {
                        cars[curInd].LapsCounter--;
                        cars[curInd].CurrentPosition--;
                    }
                    else
                    {
                        cars[i].LapsCounter--;
                        cars[i].CurrentPosition--;
                    }
                }
        }

        void SortByLaps()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (i < cars.Count - 1 && cars[i].LapsCounter > cars[i + 1].LapsCounter)
                {
                    Bolide temp;
                    temp = cars[i];
                    cars[i] = cars[i + 1];
                    cars[i + 1] = temp;
                    Overtake(cars[i], cars[i + 1]);
                }
                else if (i < cars.Count)
                    ReverseSort();
            }

        }

        void ReverseSort()
        {
            for (int i = cars.Count - 1; i > 0; i--)
                for (int j = i - 1; j >= 0; j--)
                    if (cars[i].LapsCounter > cars[j].LapsCounter)
                    {
                        Bolide temp;
                        temp = cars[i];
                        cars[i] = cars[j];
                        cars[j] = temp;
                        Overtake(cars[i], cars[j]);
                    }
        }
        public bool GameOverCond()
        {
            foreach (var item in cars)
            {
                if (item.LapsCounter / 36 >= 36)
                    return true;
            }
            return false;
        }
        public Bolide GetWinner()
        {
            if (GameOverCond())
            {
                return cars[0];
            }

            return (Bolide)new object();
        }
        public void Overtake(Bolide car1, Bolide car2)
        {
            Console.SetCursorPosition(1, 15);
            for (int i = 0; i < 35; i++)
                Console.Write(" ");

            Console.SetCursorPosition(1, 15);
            Console.WriteLine($"{car2.Name} overtaked {car1.Name}");
        }
        public void Clear(int x, int y, int width, int height)
        {
            int curTop = Console.CursorTop;
            int curLeft = Console.CursorLeft;
            for (; height > 0;)
            {
                Console.SetCursorPosition(x, y + --height);
                Console.Write(new string(' ', width));
            }
            Console.SetCursorPosition(curLeft, curTop);
        }
    }
}
