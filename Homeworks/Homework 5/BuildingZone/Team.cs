using System;
using System.Collections.Generic;

namespace BuildingZone
{
    
    public class Team
    {
        List<Worker> workers = new List<Worker>() {new Worker(), new Worker(), new Worker() };
        TeamLeader teamLeader = new TeamLeader();
        List<IPart> buildedPart = new List<IPart>();
        
        public void Building()
        {
            int builderIt = 0;
            for (int i = 0; i < 11; i++)
            {
                workers[builderIt].part = teamLeader.part;
                workers[builderIt].mat = teamLeader.curMat;

                buildedPart.Add(workers[builderIt].part);

                if (builderIt == 2)
                    builderIt = 0;
                else
                    builderIt++;

            }
        }

    }
}
