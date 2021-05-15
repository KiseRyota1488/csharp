using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RacingStaff
{
    public class Race
    {
        public Bolide[] cars = new Bolide[2];
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



        public void SetupTrack()
        {
            for (int i = 0; i < cars.Length; i++)
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

        public async Task GettingDrivers()
        {
            using (FileStream fs = new FileStream(@"..\..\..\..\drivers.json", FileMode.OpenOrCreate))
            {
                cars = await JsonSerializer.DeserializeAsync<Bolide[]>(fs);
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
            for (int i = 0; i < cars.Length; i++)
            {
                Console.SetCursorPosition(35, 3 + i);

                Console.WriteLine(cars[i]);
            }
        }
        public void PrintDrivers()
        {

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].ChangeCurSpeed();
                for (int j = 0; j < track.Length; j++)
                {
                    if (j == cars[i].CurrentPosition)
                    {
                        Console.SetCursorPosition(track[j].X, track[j].Y);
                        Console.Write(cars[i].Number);
                    }
                }
            }
        }
        public void ChangePosition()
        {
            for (int i = 0; i < cars.Length; i++)
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
            for (int i = 0; i < cars.Length; i++)
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
            int max = -1;
            for (int i = 0; i < cars.Length; i++)
            {
                if (i < cars.Length - 1 && cars[i].LapsCounter > cars[i + 1].LapsCounter)
                    Swap(ref cars[i], ref cars[i + 1]);
                else if (i < cars.Length)
                    ReverseSort();
            }
                
        }

        void ReverseSort()
        {
            for (int i = cars.Length-1; i > 0; i--)
            {
                for (int j = i-1; j >= 0; j--)
                {
                    if (cars[i].LapsCounter > cars[j].LapsCounter)
                        Swap(ref cars[i], ref cars[j]);
                }


            }
        }

        void Swap<T>(ref T lhs,ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
