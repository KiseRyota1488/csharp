using System;
using System.Collections.Generic;

namespace BuildingZone
{
    
    public class Team
    {
        Worker worker = new Worker();
        TeamLeader teamLeader = new TeamLeader();
        List<Type> buildedParts = new List<Type>();

        public void Building()
        {
            teamLeader.lastPart = new Basement().GetType();

            for (int i = 0; i < 11; i++)
            {
                // потрібно масив в якому будуть класи + викликатися getpart


                worker.currentPart = teamLeader.lastPart;

                teamLeader.Working();
                worker.Working();

                buildedParts.Add(teamLeader.lastPart);
            }
        }

        void DrawCurrentStage()
        {

        }
    }
}
