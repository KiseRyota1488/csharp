using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingStaff
{
    public class Track
    {
        public int[] RaceTrack = new int[50];

        public void PrintTrack(int[] cars)
        {
            int carPos = 0;
            for (int i = 0; i < 20; i++)
            {
                if (RaceTrack[i] == -1)
                    Console.Write("**");
                else
                {
                    Console.Write(cars[carPos]);
                    carPos++;
                }
            }
        }

        public void SetupTrack(int [] cars)
        {
            for (int i = 0; i < 20; i++)
                RaceTrack[i] = -1;

            for (int i = 0; i < cars.Length; i++)
                while (!AddCar(cars[i])) ;
        }

        bool AddCar(int num)
        {
            Random rnd = new Random();

            int pos = rnd.Next(RaceTrack.Length);

            if (RaceTrack[pos] == -1)
            {
                RaceTrack[pos] = num;
                return true;
            }
            else
                return false;
        }


    }
}
