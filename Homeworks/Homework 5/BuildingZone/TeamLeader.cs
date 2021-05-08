using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingZone
{
    public class TeamLeader :IWorker
    {
        int It = 0;


        IPart[] shouldBuild = new IPart[11] { new Basement(), new Walls(),new Walls(),
            new Walls(), new Walls(), new Door(), new Window(), new Window(),
            new Window(), new Window(), new Roof()};

        public IPart part;
        public Material curMat;
        public void Working()
        {
            Random rnd = new Random();
            int mat = rnd.Next(3) + 1;
            part = shouldBuild[It];
            curMat = (Material)mat;
            //Console.WriteLine($"Team leader {part.GetPart()} {part.GetMaterial(curMat)}");
            It++;
        }
    }
}
