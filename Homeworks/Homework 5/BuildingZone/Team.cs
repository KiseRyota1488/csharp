using System;
using System.Collections.Generic;

namespace BuildingZone
{
    
    public class Team
    {
        Worker worker = new Worker();
        TeamLeader teamLeader = new TeamLeader();

        public void Building()
        {
            teamLeader.lastPart = new Basement().GetType();

            for (int i = 0; i < 11; i++)
            {
                if (i == 0)
                    

                worker.currentPart = teamLeader.lastPart;

                teamLeader.Working();
                worker.Working();

            }
        }

        void DrawCurrentStage()
        {

        }
    }
}
