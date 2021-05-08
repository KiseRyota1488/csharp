using System;
using System.Collections.Generic;

namespace BuildingZone
{
    
    public class Team
    {
        List<Worker> workers = new List<Worker>() { new Worker(), new Worker(), new Worker() };
        TeamLeader teamLeader = new TeamLeader();
        House house = new House();

        public void Building()
        {

            int builderIt = 0;
            for (int i = 0; i < 11; i++)
            {
                
                Console.SetCursorPosition(0, 15);
                Console.WriteLine("Press SPACE to continue building");
                Console.ReadKey();
                Console.Clear();
                Console.SetCursorPosition(0, 12);
                teamLeader.Working();
                
                workers[builderIt].part = teamLeader.part;
                workers[builderIt].mat = teamLeader.curMat;

                Console.SetCursorPosition(0, 13);
                workers[builderIt].Working();


                if (builderIt == 2)
                    builderIt = 0;
                else
                    builderIt++;

                if (i == 0)
                    house.AddBasement();
                if (i == 4)
                    house.AddWall();
                if (i == 5)
                    house.AddDoor();
                if (i == 9)
                    house.AddWindow();
                if (i == 10)
                    house.AddRoof();

                house.DrawHouse();
            }
        }

    }
}
