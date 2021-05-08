using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingZone
{
    public class Window : IPart
    {
        
        public string GetPart()
        {
            return $"is working on {GetType().Name.ToLower()}";
        }
        public string GetMaterial(Material mat)
        {
            return $" | {mat}";
        }
    }
}
